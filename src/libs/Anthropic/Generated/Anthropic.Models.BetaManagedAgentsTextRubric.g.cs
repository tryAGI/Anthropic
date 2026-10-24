
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
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text";

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
            string type = "text")
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

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsTextRubric"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsTextRubric FromContent(string content)
        {
            return new BetaManagedAgentsTextRubric
            {
                Content = content,
            };
        }

    }
}