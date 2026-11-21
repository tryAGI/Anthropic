
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The Bundle has an attachment this API does not support editing, so its instructions can be changed only in claude.ai.
    /// </summary>
    public sealed partial class BetaBundleAttachmentNotSupportedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"bundle_attachment_not_supported"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "bundle_attachment_not_supported";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBundleAttachmentNotSupportedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBundleAttachmentNotSupportedErrorDetails(
            string errorCode = "bundle_attachment_not_supported")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBundleAttachmentNotSupportedErrorDetails" /> class.
        /// </summary>
        public BetaBundleAttachmentNotSupportedErrorDetails()
        {
        }

    }
}