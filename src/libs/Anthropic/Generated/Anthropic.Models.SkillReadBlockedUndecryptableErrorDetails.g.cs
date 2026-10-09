
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A custom skill the request names is stored under an encryption key state the workspace cannot currently decrypt.
    /// </summary>
    public sealed partial class SkillReadBlockedUndecryptableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"skill_read_blocked_undecryptable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "skill_read_blocked_undecryptable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillReadBlockedUndecryptableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillReadBlockedUndecryptableErrorDetails(
            string errorCode = "skill_read_blocked_undecryptable")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillReadBlockedUndecryptableErrorDetails" /> class.
        /// </summary>
        public SkillReadBlockedUndecryptableErrorDetails()
        {
        }

    }
}