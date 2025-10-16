
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkingConfigEnabled
    {
        /// <summary>
        /// Determines how many tokens Claude can use for its internal reasoning process. Larger budgets can enable more thorough analysis for complex problems, improving response quality. <br/>
        /// Must be ≥1024 and less than `max_tokens`.<br/>
        /// See [extended thinking](https://docs.claude.com/en/docs/build-with-claude/extended-thinking) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ThinkingConfigEnabledTypeJsonConverter))]
        public global::Anthropic.ThinkingConfigEnabledType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigEnabled" /> class.
        /// </summary>
        /// <param name="budgetTokens">
        /// Determines how many tokens Claude can use for its internal reasoning process. Larger budgets can enable more thorough analysis for complex problems, improving response quality. <br/>
        /// Must be ≥1024 and less than `max_tokens`.<br/>
        /// See [extended thinking](https://docs.claude.com/en/docs/build-with-claude/extended-thinking) for details.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingConfigEnabled(
            int budgetTokens,
            global::Anthropic.ThinkingConfigEnabledType type)
        {
            this.BudgetTokens = budgetTokens;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingConfigEnabled" /> class.
        /// </summary>
        public ThinkingConfigEnabled()
        {
        }
    }
}