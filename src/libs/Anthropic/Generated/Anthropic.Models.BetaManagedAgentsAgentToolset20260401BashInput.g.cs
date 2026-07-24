
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Input payload for the `bash` tool of the<br/>
    /// `agent_toolset_20260401` toolset. All fields are optional;<br/>
    /// a normal invocation supplies `command`, while `restart=true`<br/>
    /// (with no `command`) reboots the runner-side bash session.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolset20260401BashInput
    {
        /// <summary>
        /// Shell command to execute. Omit only when `restart` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; set; }

        /// <summary>
        /// When true, restart the persistent bash session instead of<br/>
        /// running a command. Subsequent calls without `restart` will<br/>
        /// run against the fresh session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restart")]
        public bool? Restart { get; set; }

        /// <summary>
        /// Per-call timeout in milliseconds. Defaults to the<br/>
        /// runner-wide tool timeout when omitted or zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401BashInput" /> class.
        /// </summary>
        /// <param name="command">
        /// Shell command to execute. Omit only when `restart` is true.
        /// </param>
        /// <param name="restart">
        /// When true, restart the persistent bash session instead of<br/>
        /// running a command. Subsequent calls without `restart` will<br/>
        /// run against the fresh session.
        /// </param>
        /// <param name="timeoutMs">
        /// Per-call timeout in milliseconds. Defaults to the<br/>
        /// runner-wide tool timeout when omitted or zero.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolset20260401BashInput(
            string? command,
            bool? restart,
            int? timeoutMs)
        {
            this.Command = command;
            this.Restart = restart;
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401BashInput" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolset20260401BashInput()
        {
        }

    }
}