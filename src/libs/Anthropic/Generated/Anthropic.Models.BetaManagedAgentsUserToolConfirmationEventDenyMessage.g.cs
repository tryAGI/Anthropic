
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Optional message providing context for a 'deny' decision. Only allowed when result is 'deny'.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserToolConfirmationEventDenyMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}