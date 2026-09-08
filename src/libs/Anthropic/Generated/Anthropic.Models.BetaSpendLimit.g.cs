
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A configured spend limit: a cap on metered spend for one scope and period.
    /// </summary>
    public sealed partial class BetaSpendLimit
    {
        /// <summary>
        /// Limit amount as a non-negative integer decimal string in the minor unit of `currency` (cents for USD): "50000" is $500.00. `null` means no numeric cap is configured at this scope — see the effective report for whether a limit applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// RFC 3339 datetime at which the spend limit was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ISO 4217 code of the organization's billing currency; the unit for `amount`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Unique tagged ID of the spend limit (`spl_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Length of the window the limit resets over. `amount` caps spend within each period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSpendLimitPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSpendLimitPeriod Period { get; set; }

        /// <summary>
        /// What the limit applies to. A tagged union on `type`; each variant carries the identifier for its scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Scope2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Scope2 Scope { get; set; }

        /// <summary>
        /// Object type. Always `spend_limit`.<br/>
        /// Default Value: spend_limit
        /// </summary>
        /// <default>"spend_limit"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "spend_limit";

        /// <summary>
        /// RFC 3339 datetime at which the spend limit was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSpendLimit" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 datetime at which the spend limit was created.
        /// </param>
        /// <param name="currency">
        /// ISO 4217 code of the organization's billing currency; the unit for `amount`.
        /// </param>
        /// <param name="id">
        /// Unique tagged ID of the spend limit (`spl_...`).
        /// </param>
        /// <param name="period">
        /// Length of the window the limit resets over. `amount` caps spend within each period.
        /// </param>
        /// <param name="scope">
        /// What the limit applies to. A tagged union on `type`; each variant carries the identifier for its scope.
        /// </param>
        /// <param name="updatedAt">
        /// RFC 3339 datetime at which the spend limit was last modified.
        /// </param>
        /// <param name="amount">
        /// Limit amount as a non-negative integer decimal string in the minor unit of `currency` (cents for USD): "50000" is $500.00. `null` means no numeric cap is configured at this scope — see the effective report for whether a limit applies.
        /// </param>
        /// <param name="type">
        /// Object type. Always `spend_limit`.<br/>
        /// Default Value: spend_limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSpendLimit(
            global::System.DateTime createdAt,
            string currency,
            string id,
            global::Anthropic.BetaSpendLimitPeriod period,
            global::Anthropic.Scope2 scope,
            global::System.DateTime updatedAt,
            string? amount,
            string type = "spend_limit")
        {
            this.Amount = amount;
            this.CreatedAt = createdAt;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Period = period;
            this.Scope = scope;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSpendLimit" /> class.
        /// </summary>
        public BetaSpendLimit()
        {
        }

    }
}