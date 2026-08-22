
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRotateTunnelTokenRequestBody
    {
        /// <summary>
        /// Optional free-text reason for the rotation, recorded for audit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRotateTunnelTokenRequestBody" /> class.
        /// </summary>
        /// <param name="reason">
        /// Optional free-text reason for the rotation, recorded for audit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRotateTunnelTokenRequestBody(
            string? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRotateTunnelTokenRequestBody" /> class.
        /// </summary>
        public BetaRotateTunnelTokenRequestBody()
        {
        }

    }
}