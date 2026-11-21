
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// This stored settings document currently cannot be read or replaced. Contact support, or, if you no longer need these settings, delete the group's settings or clear the default.
    /// </summary>
    public sealed partial class BetaCmekFeatureUnsupportedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cmek_feature_unsupported"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cmek_feature_unsupported";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekFeatureUnsupportedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekFeatureUnsupportedErrorDetails(
            string errorCode = "cmek_feature_unsupported")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekFeatureUnsupportedErrorDetails" /> class.
        /// </summary>
        public BetaCmekFeatureUnsupportedErrorDetails()
        {
        }

    }
}