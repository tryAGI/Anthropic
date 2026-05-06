
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An execution thread within a `session`. Each session has one primary thread plus zero or more child threads spawned by the coordinator.<br/>
    /// Example: {"type":"session_thread","id":"sthr_011CZkZVWa6oIjw0rgXZpnBt","session_id":"sesn_011CZkZAtmR3yMPDzynEDxu7","status":"idle","agent":{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1,"name":"Researcher","description":"A focused research subagent.","model":{"id":"claude-sonnet-4-6","speed":"standard"},"system":"You are a research subagent that gathers and summarises sources for the coordinating agent.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_ask"}},"configs":[]}],"mcp_servers":[],"skills":[]},"parent_thread_id":null,"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null,"usage":{"input_tokens":0,"output_tokens":0,"cache_read_input_tokens":0,"cache_creation":{"ephemeral_5m_input_tokens":0,"ephemeral_1h_input_tokens":0}},"stats":{"duration_seconds":0,"startup_seconds":0,"active_seconds":0}}
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionThreadTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionThreadType Type { get; set; }

        /// <summary>
        /// Unique identifier for this thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The session this thread belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Current execution status of the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionThreadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionThreadStatus Status { get; set; }

        /// <summary>
        /// Resolved agent definition for this thread. Snapshot of the agent at thread creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionThreadAgent Agent { get; set; }

        /// <summary>
        /// Parent thread that spawned this thread. Null for the primary thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_thread_id")]
        public string? ParentThreadId { get; set; }

        /// <summary>
        /// When the thread was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the thread was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// When the thread was archived. Null if not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Cumulative token usage for this thread. Null until the thread's first idle transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Anthropic.BetaManagedAgentsSessionThreadUsage? Usage { get; set; }

        /// <summary>
        /// Timing statistics for this thread. Null until the thread's first status transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Anthropic.BetaManagedAgentsSessionThreadStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThread" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this thread.
        /// </param>
        /// <param name="sessionId">
        /// The session this thread belongs to.
        /// </param>
        /// <param name="status">
        /// Current execution status of the thread.
        /// </param>
        /// <param name="agent">
        /// Resolved agent definition for this thread. Snapshot of the agent at thread creation time.
        /// </param>
        /// <param name="createdAt">
        /// When the thread was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the thread was last updated.
        /// </param>
        /// <param name="type"></param>
        /// <param name="parentThreadId">
        /// Parent thread that spawned this thread. Null for the primary thread.
        /// </param>
        /// <param name="archivedAt">
        /// When the thread was archived. Null if not archived.
        /// </param>
        /// <param name="usage">
        /// Cumulative token usage for this thread. Null until the thread's first idle transition.
        /// </param>
        /// <param name="stats">
        /// Timing statistics for this thread. Null until the thread's first status transition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionThread(
            string id,
            string sessionId,
            global::Anthropic.BetaManagedAgentsSessionThreadStatus status,
            global::Anthropic.BetaManagedAgentsSessionThreadAgent agent,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaManagedAgentsSessionThreadType type,
            string? parentThreadId,
            global::System.DateTime? archivedAt,
            global::Anthropic.BetaManagedAgentsSessionThreadUsage? usage,
            global::Anthropic.BetaManagedAgentsSessionThreadStats? stats)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Status = status;
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.ParentThreadId = parentThreadId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
            this.Usage = usage;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThread" /> class.
        /// </summary>
        public BetaManagedAgentsSessionThread()
        {
        }
    }
}