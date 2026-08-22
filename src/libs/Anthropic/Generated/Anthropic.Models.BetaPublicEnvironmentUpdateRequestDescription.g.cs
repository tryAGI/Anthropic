
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Updated description of the environment. Omit to preserve; null clears to null; an empty string is stored as an empty string.
    /// </summary>
    public sealed partial class BetaPublicEnvironmentUpdateRequestDescription
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}