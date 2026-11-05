
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Key failed Anthropic's validation, so the request was refused. The message gives the reason, if there is one.
    /// </summary>
    public sealed partial class ExternalKeyValidationFailedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_key_validation_failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_key_validation_failed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalKeyValidationFailedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalKeyValidationFailedErrorDetails(
            string errorCode = "external_key_validation_failed")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalKeyValidationFailedErrorDetails" /> class.
        /// </summary>
        public ExternalKeyValidationFailedErrorDetails()
        {
        }

    }
}