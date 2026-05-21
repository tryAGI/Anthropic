
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rubric content provided inline as text.
    /// </summary>
    public sealed partial class BetaManagedAgentsTextRubric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsTextRubricTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsTextRubricType Type { get; set; }

        /// <summary>
        /// Rubric content. Plain text or markdown — the grader treats it as freeform text.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTextRubric" /> class.
        /// </summary>
        /// <param name="content">
        /// Rubric content. Plain text or markdown — the grader treats it as freeform text.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsTextRubric(
            string content,
            global::Anthropic.BetaManagedAgentsTextRubricType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsTextRubric" /> class.
        /// </summary>
        public BetaManagedAgentsTextRubric()
        {
        }

    }
}