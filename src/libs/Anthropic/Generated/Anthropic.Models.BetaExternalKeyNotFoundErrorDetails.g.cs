
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has no active External Key with this ID. The message names the field.
    /// </summary>
    public sealed partial class BetaExternalKeyNotFoundErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_key_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_key_not_found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyNotFoundErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalKeyNotFoundErrorDetails(
            string errorCode = "external_key_not_found")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyNotFoundErrorDetails" /> class.
        /// </summary>
        public BetaExternalKeyNotFoundErrorDetails()
        {
        }

    }
}