
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of sessions.<br/>
    /// Example: {"data":[{"type":"session","id":"sesn_011CZkZAtmR3yMPDzynEDxu7","status":"idle","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null,"budget":null,"environment_id":"env_011CZkZ9X2dpNyB7HsEFoRfW","title":"Order #1234 inquiry","metadata":{},"agent":{"type":"agent","id":"agent_011CZkYpogX7uDKUyvBTophP","version":1,"name":"My First Agent","description":"A general-purpose starter agent.","model":{"id":"claude-opus-5","speed":"standard"},"system":"You are a general-purpose agent that can research, write code, run commands, and use connected tools to complete the user\u0027s task end to end.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_ask"}},"configs":[]}],"mcp_servers":[{"type":"url","name":"example-mcp","url":"https://example-server.modelcontextprotocol.io/sse"}],"skills":[{"type":"anthropic","skill_id":"xlsx","version":"1"},{"type":"custom","skill_id":"skill_011CZkZFNu9hAbo3jZPRgTmx","version":"2"}],"multiagent":null},"resources":[{"type":"file","id":"sesrsc_011CZkZBJq5dWxk9fVLNcPht","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"},{"type":"github_repository","id":"sesrsc_011CZkZCKr6eXym1gWMPdQiu","url":"https://github.com/example-org/example-repo","mount_path":"/workspace/example-repo","checkout":{"type":"branch","name":"main"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}],"vault_ids":["vlt_011CZkZDLs7fYzm1hXNPeRjv"],"usage":{"input_tokens":0,"output_tokens":0,"cache_read_input_tokens":0},"stats":{"duration_seconds":0,"active_seconds":0},"outcome_evaluations":[{"type":"outcome_evaluation","outcome_id":"outc_011CZkZRSw2kEfs6ncTVmjxP","description":"Produce a 2-page summary as summary.md","result":"satisfied","iteration":0,"completed_at":"2026-03-15T10:02:31Z","explanation":"All five sections present with inline citations."}]}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo=","prev_page":"page_MjAyNS0wNS0xM1QwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListSessions
    {
        /// <summary>
        /// List of sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page. Null when no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Opaque cursor for the previous page. Null when on the first page. Pass as the `page` parameter to navigate backward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_page")]
        public string? PrevPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessions" /> class.
        /// </summary>
        /// <param name="data">
        /// List of sessions.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
        /// <param name="prevPage">
        /// Opaque cursor for the previous page. Null when on the first page. Pass as the `page` parameter to navigate backward.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListSessions(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? data,
            string? nextPage,
            string? prevPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
            this.PrevPage = prevPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessions" /> class.
        /// </summary>
        public BetaManagedAgentsListSessions()
        {
        }

    }
}