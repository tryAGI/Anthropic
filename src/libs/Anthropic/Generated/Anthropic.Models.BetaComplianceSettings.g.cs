
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaComplianceSettings
    {
        /// <summary>
        /// Whether the Compliance API is enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.StateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.State State { get; set; }

        /// <summary>
        /// Default Value: compliance_settings
        /// </summary>
        /// <default>"compliance_settings"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compliance_settings";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceSettings" /> class.
        /// </summary>
        /// <param name="state">
        /// Whether the Compliance API is enabled for this organization.
        /// </param>
        /// <param name="type">
        /// Default Value: compliance_settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceSettings(
            global::Anthropic.State state,
            string type = "compliance_settings")
        {
            this.State = state;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceSettings" /> class.
        /// </summary>
        public BetaComplianceSettings()
        {
        }

    }
}