
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The content scan of the version in `plugin_version_id` is still running. Retry once the scan finishes.
    /// </summary>
    public sealed partial class BetaScanPendingErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"scan_pending"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "scan_pending";

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
        /// Initializes a new instance of the <see cref="BetaScanPendingErrorDetails" /> class.
        /// </summary>
        /// <param name="pluginVersionId"></param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaScanPendingErrorDetails(
            string pluginVersionId,
            string errorCode = "scan_pending")
        {
            this.ErrorCode = errorCode;
            this.PluginVersionId = pluginVersionId ?? throw new global::System.ArgumentNullException(nameof(pluginVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaScanPendingErrorDetails" /> class.
        /// </summary>
        public BetaScanPendingErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaScanPendingErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaScanPendingErrorDetails FromPluginVersionId(string pluginVersionId)
        {
            return new BetaScanPendingErrorDetails
            {
                PluginVersionId = pluginVersionId,
            };
        }

    }
}