
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request names a region code that the control does not take from this organization. The message names the field.
    /// </summary>
    public sealed partial class BetaRegionNotSupportedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"region_not_supported"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "region_not_supported";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRegionNotSupportedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRegionNotSupportedErrorDetails(
            string errorCode = "region_not_supported")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRegionNotSupportedErrorDetails" /> class.
        /// </summary>
        public BetaRegionNotSupportedErrorDetails()
        {
        }

    }
}