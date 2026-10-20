
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An organization webhook endpoint's new signing secret.
    /// </summary>
    public sealed partial class BetaOrganizationWebhookEndpointSigningSecret
    {
        /// <summary>
        /// The new signing secret. Deliveries are signed with it from now on, and no other response returns it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SigningSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationWebhookEndpointSigningSecret" /> class.
        /// </summary>
        /// <param name="signingSecret">
        /// The new signing secret. Deliveries are signed with it from now on, and no other response returns it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationWebhookEndpointSigningSecret(
            string signingSecret)
        {
            this.SigningSecret = signingSecret ?? throw new global::System.ArgumentNullException(nameof(signingSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationWebhookEndpointSigningSecret" /> class.
        /// </summary>
        public BetaOrganizationWebhookEndpointSigningSecret()
        {
        }

    }
}