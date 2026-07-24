
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of deployment runs. Sorted by created_at descending (most recent first).
    /// </summary>
    public sealed partial class BetaManagedAgentsListDeploymentRunsData
    {
        /// <summary>
        /// List of deployment runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentRun> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListDeploymentRunsData" /> class.
        /// </summary>
        /// <param name="data">
        /// List of deployment runs.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListDeploymentRunsData(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsDeploymentRun> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListDeploymentRunsData" /> class.
        /// </summary>
        public BetaManagedAgentsListDeploymentRunsData()
        {
        }

    }
}