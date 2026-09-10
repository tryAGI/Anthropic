
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The server judged the invocation high-risk; it does not execute and a synthetic error tool result is appended.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentAutoEvaluatedPermissionDeny
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"deny"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "deny";

        /// <summary>
        /// The judgement's grounds in registry-bound terms. Open registry; currently "high_risk" (judged high-risk; the call does not run). Clients must tolerate values outside this set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReasonCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentAutoEvaluatedPermissionDeny" /> class.
        /// </summary>
        /// <param name="reasonCode">
        /// The judgement's grounds in registry-bound terms. Open registry; currently "high_risk" (judged high-risk; the call does not run). Clients must tolerate values outside this set.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentAutoEvaluatedPermissionDeny(
            string reasonCode,
            string type = "deny")
        {
            this.Type = type;
            this.ReasonCode = reasonCode ?? throw new global::System.ArgumentNullException(nameof(reasonCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentAutoEvaluatedPermissionDeny" /> class.
        /// </summary>
        public BetaManagedAgentsAgentAutoEvaluatedPermissionDeny()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAgentAutoEvaluatedPermissionDeny"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAgentAutoEvaluatedPermissionDeny FromReasonCode(string reasonCode)
        {
            return new BetaManagedAgentsAgentAutoEvaluatedPermissionDeny
            {
                ReasonCode = reasonCode,
            };
        }

    }
}