
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Managed Agents `session`.<br/>
    /// Example: {"type":"session","id":"sesn_011CZkZAtmR3yMPDzynEDxu7","status":"idle","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","environment_id":"env_011CZkZ9X2dpNyB7HsEFoRfW","title":"Order #1234 inquiry","metadata":{},"agent":{"type":"agent","id":"agent_011CZkYpogX7uDKUyvBTophP","version":1,"name":"My First Agent","description":"A general-purpose starter agent.","model":{"id":"claude-sonnet-4-6","speed":"standard"},"system":"You are a general-purpose agent that can research, write code, run commands, and use connected tools to complete the user\u0027s task end to end.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_ask"}},"configs":[]}],"mcp_servers":[{"type":"url","name":"example-mcp","url":"https://example-server.modelcontextprotocol.io/sse"}],"skills":[{"type":"anthropic","skill_id":"xlsx","version":"1"},{"type":"custom","skill_id":"skill_011CZkZFNu9hAbo3jZPRgTlx","version":"2"}]},"resources":[{"type":"file","id":"sesrsc_011CZkZBJq5dWxk9fVLNcPht","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"},{"type":"github_repository","id":"sesrsc_011CZkZCKr6eXyl0gWMOdQiu","url":"https://github.com/example-org/example-repo","mount_path":"/workspace/example-repo","checkout":{"type":"branch","name":"main"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}],"vault_ids":["vlt_011CZkZDLs7fYzm1hXNPeRjv"],"usage":{"input_tokens":0,"output_tokens":0,"cache_read_input_tokens":0},"stats":{"duration_seconds":0,"active_seconds":0}}
    /// </summary>
    public sealed partial class BetaManagedAgentsSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// SessionStatus enum
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionStatus Status { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Resolved `agent` definition for a `session`. Snapshot of the `agent` at `session` creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionAgent Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource> Resources { get; set; }

        /// <summary>
        /// Vault IDs attached to the session at creation. Empty when no vaults were supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VaultIds { get; set; }

        /// <summary>
        /// Cumulative token usage for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionUsage Usage { get; set; }

        /// <summary>
        /// Timing statistics for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionStats Stats { get; set; }

        /// <summary>
        /// When the session was archived. Null if not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSession" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// SessionStatus enum
        /// </param>
        /// <param name="createdAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="environmentId"></param>
        /// <param name="metadata"></param>
        /// <param name="agent">
        /// Resolved `agent` definition for a `session`. Snapshot of the `agent` at `session` creation time.
        /// </param>
        /// <param name="resources"></param>
        /// <param name="vaultIds">
        /// Vault IDs attached to the session at creation. Empty when no vaults were supplied.
        /// </param>
        /// <param name="usage">
        /// Cumulative token usage for the session.
        /// </param>
        /// <param name="stats">
        /// Timing statistics for the session.
        /// </param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="archivedAt">
        /// When the session was archived. Null if not archived.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSession(
            string id,
            global::Anthropic.BetaManagedAgentsSessionStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string environmentId,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::Anthropic.BetaManagedAgentsSessionAgent agent,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource> resources,
            global::System.Collections.Generic.IList<string> vaultIds,
            global::Anthropic.BetaManagedAgentsSessionUsage usage,
            global::Anthropic.BetaManagedAgentsSessionStats stats,
            global::Anthropic.BetaManagedAgentsSessionType type,
            string? title,
            global::System.DateTime? archivedAt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.Title = title;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.VaultIds = vaultIds ?? throw new global::System.ArgumentNullException(nameof(vaultIds));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSession" /> class.
        /// </summary>
        public BetaManagedAgentsSession()
        {
        }
    }
}