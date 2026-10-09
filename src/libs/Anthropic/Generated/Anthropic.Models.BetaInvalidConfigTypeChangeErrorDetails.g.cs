
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `config.type` differs from the environment's stored type, which cannot change after creation.
    /// </summary>
    public sealed partial class BetaInvalidConfigTypeChangeErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"invalid_config_type_change"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "invalid_config_type_change";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidConfigTypeChangeErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInvalidConfigTypeChangeErrorDetails(
            string errorCode = "invalid_config_type_change")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidConfigTypeChangeErrorDetails" /> class.
        /// </summary>
        public BetaInvalidConfigTypeChangeErrorDetails()
        {
        }

    }
}