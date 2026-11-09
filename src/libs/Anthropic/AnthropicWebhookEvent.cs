using System.Text.Json.Serialization;

// ReSharper disable RedundantNameQualifier

namespace Anthropic;

/// <summary>
/// A webhook payload delivered to an organization webhook endpoint.
/// </summary>
/// <remarks>
/// The specification declares this schema but no operation returns it, so it is not part of the
/// generated model set. Payloads are thin on purpose: switch on <see cref="Data"/> and fetch the
/// resource by its id to read current state.
/// </remarks>
public sealed class AnthropicWebhookEvent
{
    /// <summary>
    /// Object type. Always `event` for webhook payloads.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "event";

    /// <summary>
    /// Unique event identifier for idempotency.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Timestamp of when the event occurred — not when the delivery was attempted.
    /// </summary>
    [JsonPropertyName("created_at")]
    public global::System.DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// The event itself: its type plus the ids of the resources it refers to.
    /// </summary>
    [JsonPropertyName("data")]
    public global::Anthropic.BetaWebhookEventData Data { get; set; }
}
