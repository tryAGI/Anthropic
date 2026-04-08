
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for creating a vault.<br/>
    /// Example: {"display_name":"Example vault","metadata":{"environment":"production"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateVaultRequest
    {
        /// <summary>
        /// Human-readable name for the vault. 1-255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata to attach to the vault. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateVaultRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable name for the vault. 1-255 characters.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata to attach to the vault. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCreateVaultRequest(
            string displayName,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateVaultRequest" /> class.
        /// </summary>
        public BetaManagedAgentsCreateVaultRequest()
        {
        }
    }
}