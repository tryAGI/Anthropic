
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Context management configuration.<br/>
    /// This allows you to control how Claude manages context across multiple requests, such as whether to clear function results or not.
    /// </summary>
    public sealed partial class BetaCreateMessageParamsContextManagement
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}