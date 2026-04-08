
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"display_name":"Example credential","metadata":{"environment":"production"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateCredentialRequestBody
    {
        /// <summary>
        /// Updated human-readable name for the credential. 1-255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omitted keys are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string?>? Metadata { get; set; }

        /// <summary>
        /// Updated authentication configuration. The `type` is immutable; the variant sent must match the stored credential's type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialUpdateAuthJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateCredentialRequestBody" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Updated human-readable name for the credential. 1-255 characters.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omitted keys are preserved.
        /// </param>
        /// <param name="auth">
        /// Updated authentication configuration. The `type` is immutable; the variant sent must match the stored credential's type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateCredentialRequestBody(
            string? displayName,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata,
            global::Anthropic.BetaManagedAgentsCredentialUpdateAuth? auth)
        {
            this.DisplayName = displayName;
            this.Metadata = metadata;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateCredentialRequestBody" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateCredentialRequestBody()
        {
        }
    }
}