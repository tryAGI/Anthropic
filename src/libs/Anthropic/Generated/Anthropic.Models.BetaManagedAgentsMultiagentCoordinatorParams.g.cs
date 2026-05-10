
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A coordinator topology: the session's primary thread orchestrates work by spawning session threads, each running an agent drawn from the `agents` roster.<br/>
    /// Example: {"type":"coordinator","agents":["agent_011CZkYqphY8vELVzwCUpqiQ",{"type":"self"}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentCoordinatorParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMultiagentCoordinatorParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParamsType Type { get; set; }

        /// <summary>
        /// Agents the coordinator may spawn as session threads. 1–20 entries. Each entry is an agent ID string, a versioned `{"type":"agent","id","version"}` reference, or `{"type":"self"}` to allow recursive self-invocation. Entries must reference distinct agents (after resolving `self` and string forms); at most one `self`. Referenced agents must exist, must not be archived, and must not themselves have `multiagent` set (depth limit 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentCoordinatorParams" /> class.
        /// </summary>
        /// <param name="agents">
        /// Agents the coordinator may spawn as session threads. 1–20 entries. Each entry is an agent ID string, a versioned `{"type":"agent","id","version"}` reference, or `{"type":"self"}` to allow recursive self-invocation. Entries must reference distinct agents (after resolving `self` and string forms); at most one `self`. Referenced agents must exist, must not be archived, and must not themselves have `multiagent` set (depth limit 1).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentCoordinatorParams(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentRosterEntryParams> agents,
            global::Anthropic.BetaManagedAgentsMultiagentCoordinatorParamsType type)
        {
            this.Type = type;
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentCoordinatorParams" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentCoordinatorParams()
        {
        }

    }
}