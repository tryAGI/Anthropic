
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rubric content provided inline as text.<br/>
    /// Example: {"type":"text","content":"Must cover all five sections; cite sources inline."}
    /// </summary>
    public sealed partial class BetaManagedAgentsTextRubricParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTextRubricParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsTextRubricParamsType Type { get; set; }

        /// <summary>
        /// Rubric content. Plain text or markdown — the grader treats it as freeform text. Maximum 262144 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTextRubricParams" /> class.
        /// </summary>
        /// <param name="content">
        /// Rubric content. Plain text or markdown — the grader treats it as freeform text. Maximum 262144 characters.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTextRubricParams(
            string content,
            global::Anthropic.BetaManagedAgentsTextRubricParamsType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTextRubricParams" /> class.
        /// </summary>
        public BetaManagedAgentsTextRubricParams()
        {
        }
    }
}