
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The program's tiers, keyed by tier: `a` (Specialized Access), `b` (Red Team Access) and `c` (Defense Access). A response reports either every tier or none. When it reports them, as retrieving the profile normally does, every tier has a key, whether or not it applies to the profile. When it does not, as in the list of user profiles, `tiers` is `{}`, which does not mean that the tiers are inactive. No tier implies another, so read the tier you need. Anthropic may add tiers; ignore a key you do not recognize.
    /// </summary>
    public sealed partial class UserProfileCyberProgramTiers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}