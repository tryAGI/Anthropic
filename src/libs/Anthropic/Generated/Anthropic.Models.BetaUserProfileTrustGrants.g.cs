
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Trust grants for this profile, keyed by grant name. Key omitted when no grant is active or in flight.
    /// </summary>
    public sealed partial class BetaUserProfileTrustGrants
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}