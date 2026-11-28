
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The bucket is already in use, or was in use recently. Name a different bucket.
    /// </summary>
    public sealed partial class BetaStorageInUseErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_in_use"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_in_use";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageInUseErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageInUseErrorDetails(
            string errorCode = "storage_in_use")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageInUseErrorDetails" /> class.
        /// </summary>
        public BetaStorageInUseErrorDetails()
        {
        }

    }
}