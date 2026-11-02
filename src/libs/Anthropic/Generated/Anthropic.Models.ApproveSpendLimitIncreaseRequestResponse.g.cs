
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApproveSpendLimitIncreaseRequestResponse
    {
        /// <summary>
        /// Who submitted the increase request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.SpendLimitIncreaseRequestActorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.SpendLimitIncreaseRequestActor Actor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.SpendLimitPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.SpendLimitPeriod Period { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        public global::System.DateTime? ResolvedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_by")]
        public global::Anthropic.SpendLimitIncreaseRequestResolvedBy? ResolvedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        public global::Anthropic.SpendLimit? SpendLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_summary")]
        public global::Anthropic.SpendSummary? SpendSummary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.SpendLimitIncreaseRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.SpendLimitIncreaseRequestStatus Status { get; set; }

        /// <summary>
        /// Default Value: spend_limit_increase_request
        /// </summary>
        /// <default>"spend_limit_increase_request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "spend_limit_increase_request";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveSpendLimitIncreaseRequestResponse" /> class.
        /// </summary>
        /// <param name="actor">
        /// Who submitted the increase request.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="period"></param>
        /// <param name="status"></param>
        /// <param name="resolvedAt"></param>
        /// <param name="resolvedBy"></param>
        /// <param name="spendLimit"></param>
        /// <param name="spendSummary"></param>
        /// <param name="type">
        /// Default Value: spend_limit_increase_request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveSpendLimitIncreaseRequestResponse(
            global::Anthropic.SpendLimitIncreaseRequestActor actor,
            global::System.DateTime createdAt,
            string id,
            global::Anthropic.SpendLimitPeriod period,
            global::Anthropic.SpendLimitIncreaseRequestStatus status,
            global::System.DateTime? resolvedAt,
            global::Anthropic.SpendLimitIncreaseRequestResolvedBy? resolvedBy,
            global::Anthropic.SpendLimit? spendLimit,
            global::Anthropic.SpendSummary? spendSummary,
            string type = "spend_limit_increase_request")
        {
            this.Actor = actor;
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Period = period;
            this.ResolvedAt = resolvedAt;
            this.ResolvedBy = resolvedBy;
            this.SpendLimit = spendLimit;
            this.SpendSummary = spendSummary;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveSpendLimitIncreaseRequestResponse" /> class.
        /// </summary>
        public ApproveSpendLimitIncreaseRequestResponse()
        {
        }

    }
}