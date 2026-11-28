
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// On Claude Platform on AWS, the External Storage ID in the request is neither a bucket ARN nor an `estrg_` ID, or is the `estrg_` ID of AWS storage. Name AWS storage by its bucket ARN, `arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;`, which responses return as its `id`.
    /// </summary>
    public sealed partial class BetaInvalidStorageArnErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"invalid_storage_arn"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "invalid_storage_arn";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidStorageArnErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInvalidStorageArnErrorDetails(
            string errorCode = "invalid_storage_arn")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidStorageArnErrorDetails" /> class.
        /// </summary>
        public BetaInvalidStorageArnErrorDetails()
        {
        }

    }
}