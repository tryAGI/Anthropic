
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginMarketplaceValidationPluginWarnings
    {
        /// <summary>
        /// The plugin's name, as its entry in marketplace.json declares it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The parts of the plugin a synchronization would leave out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning> Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationPluginWarnings" /> class.
        /// </summary>
        /// <param name="name">
        /// The plugin's name, as its entry in marketplace.json declares it.
        /// </param>
        /// <param name="warnings">
        /// The parts of the plugin a synchronization would leave out.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginMarketplaceValidationPluginWarnings(
            string name,
            global::System.Collections.Generic.IList<global::Anthropic.BetaPluginMarketplaceValidationPluginWarning> warnings)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationPluginWarnings" /> class.
        /// </summary>
        public BetaPluginMarketplaceValidationPluginWarnings()
        {
        }

    }
}