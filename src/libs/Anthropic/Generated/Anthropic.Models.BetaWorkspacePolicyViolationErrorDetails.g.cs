
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request breaks the organization's Workspace Policy. The message says which rule it broke; an organization admin can see and change the policy in the Console.
    /// </summary>
    public sealed partial class BetaWorkspacePolicyViolationErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workspace_policy_violation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "workspace_policy_violation";

        /// <summary>
        /// The request field the broken rule applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWorkspacePolicyFieldJsonConverter))]
        public global::Anthropic.BetaWorkspacePolicyField Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspacePolicyViolationErrorDetails" /> class.
        /// </summary>
        /// <param name="field">
        /// The request field the broken rule applies to.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspacePolicyViolationErrorDetails(
            global::Anthropic.BetaWorkspacePolicyField field,
            string errorCode = "workspace_policy_violation")
        {
            this.ErrorCode = errorCode;
            this.Field = field;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspacePolicyViolationErrorDetails" /> class.
        /// </summary>
        public BetaWorkspacePolicyViolationErrorDetails()
        {
        }

    }
}