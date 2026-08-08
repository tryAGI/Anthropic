
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of deployments.<br/>
    /// Example: {"data":[{"type":"deployment","id":"depl_011CZkZcDH3vPqd7xnEfwTai","name":"Daily order report","description":"Compiles yesterday\u0027s orders into a report every weekday morning.","agent":{"type":"agent","id":"agent_011CZkYpogX7uDKUyvBTophP","version":1},"environment_id":"env_011CZkZ9X2dpNyB7HsEFoRfW","vault_ids":["vlt_011CZkZDLs7fYzm1hXNPeRjv"],"initial_events":[{"type":"user.message","content":[{"type":"text","text":"Compile yesterday\u0027s orders into report.md."}]}],"resources":[],"metadata":{},"schedule":{"type":"cron","expression":"0 9 * * 1-5","timezone":"America/Los_Angeles","last_run_at":"2026-03-16T16:00:09Z","upcoming_runs_at":["2026-03-17T16:00:00Z","2026-03-18T16:00:00Z"]},"status":"active","paused_reason":null,"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListDeploymentsData
    {
        /// <summary>
        /// List of deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeployment> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListDeploymentsData" /> class.
        /// </summary>
        /// <param name="data">
        /// List of deployments.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListDeploymentsData(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeployment> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListDeploymentsData" /> class.
        /// </summary>
        public BetaManagedAgentsListDeploymentsData()
        {
        }

    }
}