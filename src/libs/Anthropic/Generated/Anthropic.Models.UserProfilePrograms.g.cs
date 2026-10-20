
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user profile's standing in each program. A program is a set of capabilities or exemptions that Anthropic approves for the entity the profile represents. A program reads `null` when the profile has no status in it, when the caller's organization is not entitled to read programs, or when the response does not report that program. Retrieving the profile reports every program. Anthropic may add programs; ignore a key you do not recognize.<br/>
    /// Example: {"cyber":{"status":"active","tiers":{"a":{"status":"inactive"},"b":{"status":"active"},"c":{"status":"inactive"}},"requirements":{"data_retention":true,"human_review":true}},"efs":{"status":"active","features":{"data_retention_exemption":{"status":"inactive"},"cmek":{"status":"active"},"storage":{"status":"inactive"}}}}
    /// </summary>
    public sealed partial class UserProfilePrograms
    {
        /// <summary>
        /// The profile's standing in the Cyber Verification Program. `null` when the profile has no status in it. Only retrieving the profile gives the full answer: a list or update response can show `null`, or a status other than `active`, for a profile that reads `active` when retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyber")]
        public global::Anthropic.UserProfileCyberProgram? Cyber { get; set; }

        /// <summary>
        /// The profile's standing in Enterprise Frontier Safeguards. `null` unless the platform's attestation for the program is in place on this profile, or the entity it represents has applied to the program. A list of user profiles does not report this program: there it reads `null` for every profile, so retrieve the profile to read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efs")]
        public global::Anthropic.UserProfileEfsProgram? Efs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfilePrograms" /> class.
        /// </summary>
        /// <param name="cyber">
        /// The profile's standing in the Cyber Verification Program. `null` when the profile has no status in it. Only retrieving the profile gives the full answer: a list or update response can show `null`, or a status other than `active`, for a profile that reads `active` when retrieved.
        /// </param>
        /// <param name="efs">
        /// The profile's standing in Enterprise Frontier Safeguards. `null` unless the platform's attestation for the program is in place on this profile, or the entity it represents has applied to the program. A list of user profiles does not report this program: there it reads `null` for every profile, so retrieve the profile to read it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfilePrograms(
            global::Anthropic.UserProfileCyberProgram? cyber,
            global::Anthropic.UserProfileEfsProgram? efs)
        {
            this.Cyber = cyber;
            this.Efs = efs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfilePrograms" /> class.
        /// </summary>
        public UserProfilePrograms()
        {
        }

    }
}