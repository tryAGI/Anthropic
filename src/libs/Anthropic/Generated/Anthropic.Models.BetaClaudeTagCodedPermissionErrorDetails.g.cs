
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeTagCodedPermissionErrorDetails
    {
        /// <summary>
        /// A stable code that names the cause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagCodedPermissionErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// A stable code that names the cause.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagCodedPermissionErrorDetails(
            string errorCode)
        {
            this.ErrorCode = errorCode ?? throw new global::System.ArgumentNullException(nameof(errorCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagCodedPermissionErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagCodedPermissionErrorDetails()
        {
        }

    }
}