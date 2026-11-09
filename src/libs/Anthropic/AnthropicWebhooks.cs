// ReSharper disable RedundantNameQualifier

namespace Anthropic;

/// <summary>
/// Verifies and parses webhook deliveries from Anthropic.
/// </summary>
/// <remarks>
/// Deliveries carry the <c>webhook-id</c>, <c>webhook-timestamp</c> and <c>webhook-signature</c>
/// headers; the signed content is <c>{id}.{timestamp}.{body}</c>, HMAC-SHA256 under the endpoint's
/// <c>whsec_</c> signing secret. Verify the body exactly as it arrived — re-serializing the JSON
/// changes the bytes and invalidates the signature.
/// </remarks>
public static class AnthropicWebhooks
{
    /// <summary>
    /// Environment variable read when no signing secret is passed explicitly.
    /// </summary>
    public const string SigningKeyEnvironmentVariableName = "ANTHROPIC_WEBHOOK_SIGNING_KEY";

    /// <summary>
    /// Verifies a delivery and returns the parsed event.
    /// </summary>
    /// <param name="headers">The request headers, passed through untouched.</param>
    /// <param name="payload">The raw request body, exactly as received.</param>
    /// <param name="signingSecret">
    /// The endpoint signing secret. Falls back to the
    /// <c>ANTHROPIC_WEBHOOK_SIGNING_KEY</c> environment variable when null.
    /// </param>
    /// <param name="timestampTolerance">How stale a delivery may be. Defaults to five minutes.</param>
    /// <exception cref="WebhookVerificationException">The signature is missing, stale or invalid.</exception>
    /// <exception cref="global::System.ArgumentException">No signing secret is available.</exception>
    public static global::Anthropic.AnthropicWebhookEvent Unwrap(
        global::System.Collections.Generic.IReadOnlyDictionary<string, string> headers,
        string payload,
        string? signingSecret = null,
        global::System.TimeSpan? timestampTolerance = null)
    {
        payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));

        var verifier = CreateVerifier(signingSecret, timestampTolerance);
        verifier.VerifyOrThrow(headers, global::System.Text.Encoding.UTF8.GetBytes(payload));

        return Parse(payload);
    }

    /// <summary>
    /// Verifies a delivery held in an <see cref="System.Net.Http.HttpRequestMessage"/> and returns
    /// the parsed event.
    /// </summary>
    /// <param name="request">The request carrying the webhook headers.</param>
    /// <param name="payload">The raw request body, exactly as received.</param>
    /// <param name="signingSecret">
    /// The endpoint signing secret. Falls back to the
    /// <c>ANTHROPIC_WEBHOOK_SIGNING_KEY</c> environment variable when null.
    /// </param>
    /// <param name="timestampTolerance">How stale a delivery may be. Defaults to five minutes.</param>
    /// <exception cref="WebhookVerificationException">The signature is missing, stale or invalid.</exception>
    /// <exception cref="global::System.ArgumentException">No signing secret is available.</exception>
    public static global::Anthropic.AnthropicWebhookEvent Unwrap(
        global::System.Net.Http.HttpRequestMessage request,
        string payload,
        string? signingSecret = null,
        global::System.TimeSpan? timestampTolerance = null)
    {
        payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));

        var verifier = CreateVerifier(signingSecret, timestampTolerance);
        verifier.VerifyOrThrow(request, global::System.Text.Encoding.UTF8.GetBytes(payload));

        return Parse(payload);
    }

    /// <summary>
    /// Creates a verifier for the given secret, or for the secret in the environment.
    /// </summary>
    /// <param name="signingSecret">
    /// The endpoint signing secret. Falls back to the
    /// <c>ANTHROPIC_WEBHOOK_SIGNING_KEY</c> environment variable when null.
    /// </param>
    /// <param name="timestampTolerance">How stale a delivery may be. Defaults to five minutes.</param>
    /// <exception cref="global::System.ArgumentException">No signing secret is available.</exception>
    public static global::Anthropic.AnthropicWebhookVerifier CreateVerifier(
        string? signingSecret = null,
        global::System.TimeSpan? timestampTolerance = null)
    {
        var secret = signingSecret is { Length: > 0 }
            ? signingSecret
            : global::System.Environment.GetEnvironmentVariable(SigningKeyEnvironmentVariableName) is { Length: > 0 } fromEnvironment
                ? fromEnvironment
                : throw new global::System.ArgumentException(
                    $"No webhook signing secret was provided and {SigningKeyEnvironmentVariableName} is not set.",
                    nameof(signingSecret));

        return new global::Anthropic.AnthropicWebhookVerifier(secret, timestampTolerance);
    }

    private static global::Anthropic.AnthropicWebhookEvent Parse(string payload)
    {
        // The envelope is read by hand so the union below can use its own generated,
        // trimming-safe serializer context.
        using var document = global::System.Text.Json.JsonDocument.Parse(payload);
        var root = document.RootElement;
        if (root.ValueKind != global::System.Text.Json.JsonValueKind.Object)
        {
            throw new global::System.Text.Json.JsonException("The webhook payload is not a JSON object.");
        }

        if (!root.TryGetProperty("data", out var data))
        {
            throw new global::System.Text.Json.JsonException("The webhook payload has no 'data' property.");
        }

        return new global::Anthropic.AnthropicWebhookEvent
        {
            Type = root.TryGetProperty("type", out var type) ? type.GetString() ?? "event" : "event",
            Id = root.TryGetProperty("id", out var id) ? id.GetString() ?? string.Empty : string.Empty,
            CreatedAt = root.TryGetProperty("created_at", out var createdAt) &&
                        createdAt.TryGetDateTimeOffset(out var createdAtValue)
                ? createdAtValue
                : default,
            Data = global::Anthropic.BetaWebhookEventData.FromJson(data.GetRawText())
                   ?? throw new global::System.Text.Json.JsonException("The webhook payload has an unrecognized 'data' property."),
        };
    }
}
