
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSpendLimitIncreaseRequestSchema
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSpendLimitIncreaseRequestSchemaPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSpendLimitIncreaseRequestSchemaPeriod Period { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        public global::System.DateTime? ResolvedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_by")]
        public global::Anthropic.ResolvedByVariant12? ResolvedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_summary")]
        public global::Anthropic.BetaSpendSummary? SpendSummary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSpendLimitIncreaseRequestSchemaStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSpendLimitIncreaseRequestSchemaStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaSpendLimitIncreaseRequestSchema" /> class.
        /// </summary>
        /// <param name="actor">
        /// A user within the organization. `name` and `email_address` are<br/>
        /// null when the underlying account is unavailable or has been deleted;<br/>
        /// `deleted` is true only for deleted accounts.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="period"></param>
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
        public BetaSpendLimitIncreaseRequestSchema(
            global::Anthropic.BetaUserActorSchema actor,
            global::System.DateTime createdAt,
            string id,
            global::Anthropic.BetaSpendLimitIncreaseRequestSchemaPeriod period,
            global::Anthropic.BetaSpendLimitIncreaseRequestSchemaStatus status,
            global::System.DateTime? resolvedAt,
            global::Anthropic.ResolvedByVariant12? resolvedBy,
            global::Anthropic.BetaSpendSummary? spendSummary,
            string type = "spend_limit_increase_request")
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Period = period;
            this.ResolvedAt = resolvedAt;
            this.ResolvedBy = resolvedBy;
            this.SpendSummary = spendSummary;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSpendLimitIncreaseRequestSchema" /> class.
        /// </summary>
        public BetaSpendLimitIncreaseRequestSchema()
        {
        }

    }
}