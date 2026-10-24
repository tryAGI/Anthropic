
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Text content within a search result.
    /// </summary>
    public sealed partial class BetaManagedAgentsSearchResultContent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSearchResultContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSearchResultContent(
            string text,
            string type = "text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSearchResultContent" /> class.
        /// </summary>
        public BetaManagedAgentsSearchResultContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsSearchResultContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsSearchResultContent FromText(string text)
        {
            return new BetaManagedAgentsSearchResultContent
            {
                Text = text,
            };
        }

    }
}