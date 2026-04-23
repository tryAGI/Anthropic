
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateMemoryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precondition")]
        public global::Anthropic.BetaManagedAgentsContentSha256Precondition? Precondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateMemoryParams" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="path"></param>
        /// <param name="precondition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateMemoryParams(
            string? content,
            string? path,
            global::Anthropic.BetaManagedAgentsContentSha256Precondition? precondition)
        {
            this.Content = content;
            this.Path = path;
            this.Precondition = precondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateMemoryParams" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateMemoryParams()
        {
        }
    }
}