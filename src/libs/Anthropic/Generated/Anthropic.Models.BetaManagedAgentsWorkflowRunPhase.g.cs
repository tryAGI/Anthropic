
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A phase that a workflow run's plan declares.<br/>
    /// Example: {"id":"wrph_011CZm4Kq7RtY2Wn8Vx3LbHd","name":"Collect the sources","description":"Finds each vendor\u0027s pricing page."}
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunPhase
    {
        /// <summary>
        /// Unique identifier for the phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name that the agent gave the phase, passed on as written.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description that the agent gave the phase, passed on as written, or `null` if it gave none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunPhase" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the phase.
        /// </param>
        /// <param name="name">
        /// Name that the agent gave the phase, passed on as written.
        /// </param>
        /// <param name="description">
        /// Description that the agent gave the phase, passed on as written, or `null` if it gave none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunPhase(
            string id,
            string name,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunPhase" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunPhase()
        {
        }

    }
}