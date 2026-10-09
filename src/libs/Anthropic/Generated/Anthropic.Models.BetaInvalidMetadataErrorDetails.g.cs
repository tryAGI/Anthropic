
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `metadata` has too many keys, a key or value that is too long, or a reserved key. The message names each problem.
    /// </summary>
    public sealed partial class BetaInvalidMetadataErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"invalid_metadata"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "invalid_metadata";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidMetadataErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInvalidMetadataErrorDetails(
            string errorCode = "invalid_metadata")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidMetadataErrorDetails" /> class.
        /// </summary>
        public BetaInvalidMetadataErrorDetails()
        {
        }

    }
}