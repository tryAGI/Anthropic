
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApproveSpendLimitIncreaseRequestResponse
    {
        /// <summary>
        /// A user within the organization. `name` and `email_address` are<br/>
        /// null when the underlying account is unavailable or has been deleted;<br/>
        /// `deleted` is true only for deleted accounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUserActorSchema Actor { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaApproveSpendLimitIncreaseRequestResponsePeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponsePeriod Period { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        public global::System.DateTime? ResolvedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_by")]
        public global::Anthropic.ResolvedByVariant1? ResolvedBy { get; set; }

        /// <summary>
        /// A configured spend limit: a cap on metered spend for one scope and period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSpendLimit SpendLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_summary")]
        public global::Anthropic.BetaSpendSummary? SpendSummary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaApproveSpendLimitIncreaseRequestResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaApproveSpendLimitIncreaseRequestResponse" /> class.
        /// </summary>
        /// <param name="actor">
        /// A user within the organization. `name` and `email_address` are<br/>
        /// null when the underlying account is unavailable or has been deleted;<br/>
        /// `deleted` is true only for deleted accounts.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="period"></param>
        /// <param name="spendLimit">
        /// A configured spend limit: a cap on metered spend for one scope and period.
        /// </param>
        /// <param name="status"></param>
        /// <param name="resolvedAt"></param>
        /// <param name="resolvedBy"></param>
        /// <param name="spendSummary"></param>
        /// <param name="type">
        /// Default Value: spend_limit_increase_request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApproveSpendLimitIncreaseRequestResponse(
            global::Anthropic.BetaUserActorSchema actor,
            global::System.DateTime createdAt,
            string id,
            global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponsePeriod period,
            global::Anthropic.BetaSpendLimit spendLimit,
            global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseStatus status,
            global::System.DateTime? resolvedAt,
            global::Anthropic.ResolvedByVariant1? resolvedBy,
            global::Anthropic.BetaSpendSummary? spendSummary,
            string type = "spend_limit_increase_request")
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Period = period;
            this.ResolvedAt = resolvedAt;
            this.ResolvedBy = resolvedBy;
            this.SpendLimit = spendLimit ?? throw new global::System.ArgumentNullException(nameof(spendLimit));
            this.SpendSummary = spendSummary;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApproveSpendLimitIncreaseRequestResponse" /> class.
        /// </summary>
        public BetaApproveSpendLimitIncreaseRequestResponse()
        {
        }

    }
}