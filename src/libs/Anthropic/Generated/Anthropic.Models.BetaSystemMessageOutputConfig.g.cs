
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-message output configuration on a role:"system" input message.<br/>
    /// Fields here apply per-turn; ``format`` remains top-level only. An<br/>
    /// empty ``{}`` is accepted on a message that carries content; a message<br/>
    /// with neither content nor output_config fields is rejected.
    /// </summary>
    public sealed partial class BetaSystemMessageOutputConfig
    {
        /// <summary>
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer.<br/>
        /// Valid values are `low`, `medium`, `high`, `xhigh`, or `max`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::Anthropic.BetaEffortLevel? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSystemMessageOutputConfig" /> class.
        /// </summary>
        /// <param name="effort">
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer.<br/>
        /// Valid values are `low`, `medium`, `high`, `xhigh`, or `max`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSystemMessageOutputConfig(
            global::Anthropic.BetaEffortLevel? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSystemMessageOutputConfig" /> class.
        /// </summary>
        public BetaSystemMessageOutputConfig()
        {
        }

    }
}