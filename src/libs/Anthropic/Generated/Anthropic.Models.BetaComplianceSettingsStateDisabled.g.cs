
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaComplianceSettingsStateDisabled
    {
        /// <summary>
        /// Default Value: disabled
        /// </summary>
        /// <default>"disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceSettingsStateDisabled" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceSettingsStateDisabled(
            string type = "disabled")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceSettingsStateDisabled" /> class.
        /// </summary>
        public BetaComplianceSettingsStateDisabled()
        {
        }

    }
}