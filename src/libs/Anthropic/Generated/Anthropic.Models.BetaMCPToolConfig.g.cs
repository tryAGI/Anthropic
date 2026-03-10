
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for a specific tool in an MCP toolset.
    /// </summary>
    public sealed partial class BetaMCPToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaMCPToolConfig" /> class.
        /// </summary>
        /// <param name="deferLoading"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMCPToolConfig(
            bool? deferLoading,
            bool? enabled)
        {
            this.DeferLoading = deferLoading;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPToolConfig" /> class.
        /// </summary>
        public BetaMCPToolConfig()
        {
        }
    }
}