
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How long to wait for work to arrive before returning. Must be 1-999 in milliseconds. Defaults to non-blocking (returns immediately if no work is available).
    /// </summary>
    public sealed partial class BetaPollWorkV1EnvironmentsEnvironmentIdWorkPollGetBlockMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}