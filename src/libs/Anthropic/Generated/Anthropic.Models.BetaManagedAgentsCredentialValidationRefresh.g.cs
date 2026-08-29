
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Details of the refresh-token exchange attempted on a 401. Null when no refresh was attempted.
    /// </summary>
    public sealed partial class BetaManagedAgentsCredentialValidationRefresh
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}