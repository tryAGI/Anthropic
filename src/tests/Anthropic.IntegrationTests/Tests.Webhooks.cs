using System.Security.Cryptography;
using System.Text;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    private const string WebhookPayload =
        """
        {"type":"event","id":"whe_0f1e2d3c","created_at":"2026-03-15T10:00:00Z","data":{"type":"session.status_idled","id":"sesn_011CZkZAtmR3yMPDzynEDxu7","organization_id":"org_011CZkZZAe0sMna4vkBdtrfx","workspace_id":"wrkspc_011CZkZaBF1tNoB5wlCeusgy"}}
        """;

    [TestMethod]
    public void UnwrapVerifiesAndParsesWebhookDelivery()
    {
        var secretBytes = new byte[32];
        RandomNumberGenerator.Fill(secretBytes);
        var secret = "whsec_" + Convert.ToBase64String(secretBytes);

        var headers = SignWebhook(secretBytes, WebhookPayload, DateTimeOffset.UtcNow);

        var @event = AnthropicWebhooks.Unwrap(headers, WebhookPayload, secret);

        @event.Id.Should().Be("whe_0f1e2d3c");
        @event.CreatedAt.Should().Be(DateTimeOffset.Parse("2026-03-15T10:00:00Z", System.Globalization.CultureInfo.InvariantCulture));
        @event.Data.SessionStatusIdled.Should().NotBeNull();
        @event.Data.SessionStatusIdled!.Id.Should().Be("sesn_011CZkZAtmR3yMPDzynEDxu7");
    }

    [TestMethod]
    public void UnwrapRejectsATamperedPayload()
    {
        var secretBytes = new byte[32];
        RandomNumberGenerator.Fill(secretBytes);
        var secret = "whsec_" + Convert.ToBase64String(secretBytes);

        var headers = SignWebhook(secretBytes, WebhookPayload, DateTimeOffset.UtcNow);
        var tampered = WebhookPayload.Replace("sesn_011CZkZAtmR3yMPDzynEDxu7", "sesn_attacker", StringComparison.Ordinal);

        var act = () => AnthropicWebhooks.Unwrap(headers, tampered, secret);

        act.Should().Throw<WebhookVerificationException>()
            .Which.Error.Should().Be(WebhookVerificationError.InvalidSignature);
    }

    [TestMethod]
    public void UnwrapRejectsAStaleDelivery()
    {
        var secretBytes = new byte[32];
        RandomNumberGenerator.Fill(secretBytes);
        var secret = "whsec_" + Convert.ToBase64String(secretBytes);

        var headers = SignWebhook(secretBytes, WebhookPayload, DateTimeOffset.UtcNow.AddHours(-1));

        var act = () => AnthropicWebhooks.Unwrap(headers, WebhookPayload, secret);

        act.Should().Throw<WebhookVerificationException>()
            .Which.Error.Should().Be(WebhookVerificationError.StaleTimestamp);
    }

    private static Dictionary<string, string> SignWebhook(
        byte[] secretBytes,
        string payload,
        DateTimeOffset timestamp)
    {
        const string id = "msg_2VHZmzqPRgqUQpvGzBEY7E";
        var unixTimestamp = timestamp.ToUnixTimeSeconds().ToString(System.Globalization.CultureInfo.InvariantCulture);
        var signedContent = $"{id}.{unixTimestamp}.{payload}";
        var signature = Convert.ToBase64String(HMACSHA256.HashData(secretBytes, Encoding.UTF8.GetBytes(signedContent)));

        return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["webhook-id"] = id,
            ["webhook-timestamp"] = unixTimestamp,
            ["webhook-signature"] = "v1," + signature,
        };
    }
}
