
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The content scan of the version in `plugin_version_id` failed, errored or reached no verdict, so the version cannot be served.
    /// </summary>
    public sealed partial class BetaScanFailedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"scan_failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "scan_failed";

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
        /// Initializes a new instance of the <see cref="BetaScanFailedErrorDetails" /> class.
        /// </summary>
        /// <param name="pluginVersionId"></param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaScanFailedErrorDetails(
            string pluginVersionId,
            string errorCode = "scan_failed")
        {
            this.ErrorCode = errorCode;
            this.PluginVersionId = pluginVersionId ?? throw new global::System.ArgumentNullException(nameof(pluginVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaScanFailedErrorDetails" /> class.
        /// </summary>
        public BetaScanFailedErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaScanFailedErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaScanFailedErrorDetails FromPluginVersionId(string pluginVersionId)
        {
            return new BetaScanFailedErrorDetails
            {
                PluginVersionId = pluginVersionId,
            };
        }

    }
}