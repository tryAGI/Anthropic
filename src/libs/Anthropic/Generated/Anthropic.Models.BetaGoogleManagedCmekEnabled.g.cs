
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is on and has a key for at least one region.
    /// </summary>
    public sealed partial class BetaGoogleManagedCmekEnabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// The ID of the External Key configured for each region (`ekey_...`), keyed by region code. A region with no key is left out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ExternalKeyIds { get; set; }

        /// <summary>
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedCmekRegionStatus> Status { get; set; }

        /// <summary>
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredKey> RetiredKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedCmekEnabled" /> class.
        /// </summary>
        /// <param name="externalKeyIds">
        /// The ID of the External Key configured for each region (`ekey_...`), keyed by region code. A region with no key is left out.
        /// </param>
        /// <param name="status">
        /// Each region's status for the control, keyed by region code. A region that your organization is not offered may have no entry, and Anthropic may add regions.
        /// </param>
        /// <param name="retiredKeys">
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedCmekEnabled(
            global::System.Collections.Generic.Dictionary<string, string> externalKeyIds,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaGoogleManagedCmekRegionStatus> status,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredKey> retiredKeys,
            string type = "enabled")
        {
            this.Type = type;
            this.ExternalKeyIds = externalKeyIds ?? throw new global::System.ArgumentNullException(nameof(externalKeyIds));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.RetiredKeys = retiredKeys ?? throw new global::System.ArgumentNullException(nameof(retiredKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedCmekEnabled" /> class.
        /// </summary>
        public BetaGoogleManagedCmekEnabled()
        {
        }

    }
}