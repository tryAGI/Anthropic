
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of threads within a `session`.<br/>
    /// Example: {"data":[{"type":"session_thread","id":"sthr_011CZkZVWa6oIjw0rgXZpnBt","session_id":"sesn_011CZkZAtmR3yMPDzynEDxu7","status":"idle","agent":{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1,"name":"Researcher","description":"A focused research subagent.","model":{"id":"claude-sonnet-4-6","speed":"standard"},"system":"You are a research subagent that gathers and summarises sources for the coordinating agent.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_ask"}},"configs":[]}],"mcp_servers":[],"skills":[]},"parent_thread_id":null,"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null,"usage":{"input_tokens":0,"output_tokens":0,"cache_read_input_tokens":0,"cache_creation":{"ephemeral_5m_input_tokens":0,"ephemeral_1h_input_tokens":0}},"stats":{"duration_seconds":0,"startup_seconds":0,"active_seconds":0}}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListSessionThreads
    {
        /// <summary>
        /// Threads in the session, primary first then children in spawn order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThread>? Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page. Null when no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionThreads" /> class.
        /// </summary>
        /// <param name="data">
        /// Threads in the session, primary first then children in spawn order.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListSessionThreads(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThread>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionThreads" /> class.
        /// </summary>
        public BetaManagedAgentsListSessionThreads()
        {
        }

    }
}