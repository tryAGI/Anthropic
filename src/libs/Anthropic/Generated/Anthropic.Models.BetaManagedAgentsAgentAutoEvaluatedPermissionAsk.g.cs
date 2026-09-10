
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The server reached no judgement; the invocation is held for client approval.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentAutoEvaluatedPermissionAsk
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"ask"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ask";

        /// <summary>
        /// The judgement's grounds in registry-bound terms, for client branching and audit rather than end-user display. Open registry; currently "indeterminate" (no judgement was reached). Clients must tolerate values outside this set.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentAutoEvaluatedPermissionAsk" /> class.
        /// </summary>
        /// <param name="reasonCode">
        /// The judgement's grounds in registry-bound terms, for client branching and audit rather than end-user display. Open registry; currently "indeterminate" (no judgement was reached). Clients must tolerate values outside this set.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentAutoEvaluatedPermissionAsk(
            string reasonCode,
            string type = "ask")
        {
            this.Type = type;
            this.ReasonCode = reasonCode ?? throw new global::System.ArgumentNullException(nameof(reasonCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentAutoEvaluatedPermissionAsk" /> class.
        /// </summary>
        public BetaManagedAgentsAgentAutoEvaluatedPermissionAsk()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAgentAutoEvaluatedPermissionAsk"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAgentAutoEvaluatedPermissionAsk FromReasonCode(string reasonCode)
        {
            return new BetaManagedAgentsAgentAutoEvaluatedPermissionAsk
            {
                ReasonCode = reasonCode,
            };
        }

    }
}