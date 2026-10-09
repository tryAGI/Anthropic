
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The Plugin version was stored but is not yet usable in claude.ai. `plugin_id` and `plugin_version_id` identify what was stored.
    /// </summary>
    public sealed partial class BetaRegistrationPendingErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"registration_pending"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "registration_pending";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRegistrationPendingErrorDetails" /> class.
        /// </summary>
        /// <param name="pluginId"></param>
        /// <param name="pluginVersionId"></param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRegistrationPendingErrorDetails(
            string pluginId,
            string pluginVersionId,
            string errorCode = "registration_pending")
        {
            this.ErrorCode = errorCode;
            this.PluginId = pluginId ?? throw new global::System.ArgumentNullException(nameof(pluginId));
            this.PluginVersionId = pluginVersionId ?? throw new global::System.ArgumentNullException(nameof(pluginVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRegistrationPendingErrorDetails" /> class.
        /// </summary>
        public BetaRegistrationPendingErrorDetails()
        {
        }

    }
}