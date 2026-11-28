
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaComplianceSettings
    {
        /// <summary>
        /// Read-only. Whether Access Transparency is on for the organization. Returned only when the request sends the `anthropic-beta: efs-2026-10-01` header and Access Transparency is available to the organization; otherwise omitted. If the status can't be read, getting Compliance Settings returns an error; an update still saves, but then reports `disabled` whatever the real status, so get the settings again to check it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_transparency")]
        public global::Anthropic.BetaAccessTransparency? AccessTransparency { get; set; }

        /// <summary>
        /// Whether the Compliance API is enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceSettingsStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceSettingsState State { get; set; }

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
        /// <param name="accessTransparency">
        /// Read-only. Whether Access Transparency is on for the organization. Returned only when the request sends the `anthropic-beta: efs-2026-10-01` header and Access Transparency is available to the organization; otherwise omitted. If the status can't be read, getting Compliance Settings returns an error; an update still saves, but then reports `disabled` whatever the real status, so get the settings again to check it.
        /// </param>
        /// <param name="type">
        /// Default Value: compliance_settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceSettings(
            global::Anthropic.BetaComplianceSettingsState state,
            global::Anthropic.BetaAccessTransparency? accessTransparency,
            string type = "compliance_settings")
        {
            this.AccessTransparency = accessTransparency;
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