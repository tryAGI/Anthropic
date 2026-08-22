
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Optional recurring cron schedule. When present, the deployment fires automatically. Both expression and timezone are required when schedule is set.
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateDeploymentParamsSchedule
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}