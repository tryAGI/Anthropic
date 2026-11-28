
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `provider_config.region` is not a region where External Storage is available.
    /// </summary>
    public sealed partial class BetaUnsupportedRegionErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"unsupported_region"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "unsupported_region";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUnsupportedRegionErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUnsupportedRegionErrorDetails(
            string errorCode = "unsupported_region")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUnsupportedRegionErrorDetails" /> class.
        /// </summary>
        public BetaUnsupportedRegionErrorDetails()
        {
        }

    }
}