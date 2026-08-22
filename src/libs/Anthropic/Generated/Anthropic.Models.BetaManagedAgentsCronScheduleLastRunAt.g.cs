
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Time the most recent scheduled run actually started. Null until one completes; preserved after the deployment is archived. Manual runs do not update this.
    /// </summary>
    public sealed partial class BetaManagedAgentsCronScheduleLastRunAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}