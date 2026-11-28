
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Turns the control on, or changes its keys while it is on.
    /// </summary>
    public sealed partial class BetaGoogleManagedCmekEnabledParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// The External Key to use in each region, keyed by region code, such as `us` or `eu`. An External Key ID (`ekey_...`) sets that region's key, `null` removes it, and a region you leave out keeps its key. While the control is on, at least one region must have a key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_ids")]
        public object? ExternalKeyIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedCmekEnabledParams" /> class.
        /// </summary>
        /// <param name="externalKeyIds">
        /// The External Key to use in each region, keyed by region code, such as `us` or `eu`. An External Key ID (`ekey_...`) sets that region's key, `null` removes it, and a region you leave out keeps its key. While the control is on, at least one region must have a key.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedCmekEnabledParams(
            object? externalKeyIds,
            string type = "enabled")
        {
            this.Type = type;
            this.ExternalKeyIds = externalKeyIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedCmekEnabledParams" /> class.
        /// </summary>
        public BetaGoogleManagedCmekEnabledParams()
        {
        }

    }
}