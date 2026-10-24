
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent completed its turn naturally and is ready for the next user message.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionEndTurn
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"end_turn"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "end_turn";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionEndTurn" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionEndTurn(
            string type = "end_turn")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionEndTurn" /> class.
        /// </summary>
        public BetaManagedAgentsSessionEndTurn()
        {
        }

    }
}