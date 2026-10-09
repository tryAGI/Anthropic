
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The marketplace already holds this name. `plugin_id` is the Plugin that holds it, and is absent when a standalone skill holds the name.
    /// </summary>
    public sealed partial class BetaPluginNameTakenErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"plugin_name_taken"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "plugin_name_taken";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        public string? PluginId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginNameTakenErrorDetails" /> class.
        /// </summary>
        /// <param name="pluginId"></param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginNameTakenErrorDetails(
            string? pluginId,
            string errorCode = "plugin_name_taken")
        {
            this.ErrorCode = errorCode;
            this.PluginId = pluginId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginNameTakenErrorDetails" /> class.
        /// </summary>
        public BetaPluginNameTakenErrorDetails()
        {
        }

    }
}