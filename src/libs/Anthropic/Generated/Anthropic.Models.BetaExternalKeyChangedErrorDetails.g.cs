
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The external key changed while the request was validating it. Send the request again.
    /// </summary>
    public sealed partial class BetaExternalKeyChangedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_key_changed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_key_changed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyChangedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalKeyChangedErrorDetails(
            string errorCode = "external_key_changed")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyChangedErrorDetails" /> class.
        /// </summary>
        public BetaExternalKeyChangedErrorDetails()
        {
        }

    }
}