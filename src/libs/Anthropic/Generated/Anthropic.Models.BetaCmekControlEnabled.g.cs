
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is on and has a key for at least one region.
    /// </summary>
    public sealed partial class BetaCmekControlEnabled
    {
        /// <summary>
        /// The ID of the External Key configured for each region (`ekey_...`), keyed by region code. A region with no key is left out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ExternalKeyIds { get; set; }

        /// <summary>
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredKey> RetiredKeys { get; set; }

        /// <summary>
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Status { get; set; }

        /// <summary>
        /// Default Value: enabled
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekControlEnabled" /> class.
        /// </summary>
        /// <param name="externalKeyIds">
        /// The ID of the External Key configured for each region (`ekey_...`), keyed by region code. A region with no key is left out.
        /// </param>
        /// <param name="retiredKeys">
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="status">
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </param>
        /// <param name="type">
        /// Default Value: enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekControlEnabled(
            global::System.Collections.Generic.Dictionary<string, string> externalKeyIds,
            global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredKey> retiredKeys,
            object status,
            string type = "enabled")
        {
            this.ExternalKeyIds = externalKeyIds ?? throw new global::System.ArgumentNullException(nameof(externalKeyIds));
            this.RetiredKeys = retiredKeys ?? throw new global::System.ArgumentNullException(nameof(retiredKeys));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekControlEnabled" /> class.
        /// </summary>
        public BetaCmekControlEnabled()
        {
        }

    }
}