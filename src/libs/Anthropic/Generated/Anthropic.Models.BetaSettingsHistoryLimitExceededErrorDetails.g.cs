
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has reached its settings history limit, a cap on stored versions of its settings documents. Nothing in the API or claude.ai lowers the count, so contact support. Creating or deleting group settings, creating or clearing the default settings, and reordering are refused. Changing the mode still works, unless it would copy the organization settings into a new default.
    /// </summary>
    public sealed partial class BetaSettingsHistoryLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"settings_history_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "settings_history_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSettingsHistoryLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSettingsHistoryLimitExceededErrorDetails(
            string errorCode = "settings_history_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSettingsHistoryLimitExceededErrorDetails" /> class.
        /// </summary>
        public BetaSettingsHistoryLimitExceededErrorDetails()
        {
        }

    }
}