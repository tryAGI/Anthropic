
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestMCPServerToolConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMCPServerToolConfiguration" /> class.
        /// </summary>
        /// <param name="allowedTools"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestMCPServerToolConfiguration(
            global::System.Collections.Generic.IList<string>? allowedTools,
            bool? enabled)
        {
            this.AllowedTools = allowedTools;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMCPServerToolConfiguration" /> class.
        /// </summary>
        public BetaRequestMCPServerToolConfiguration()
        {
        }
    }
}