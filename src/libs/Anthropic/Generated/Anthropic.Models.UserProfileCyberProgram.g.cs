
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user profile's standing in the Cyber Verification Program, which relaxes cyber safeguards for requests that name the profile.<br/>
    /// Example: {"status":"active","tiers":{"a":{"status":"inactive"},"b":{"status":"active"},"c":{"status":"inactive"}},"requirements":{"data_retention":true,"human_review":true}}
    /// </summary>
    public sealed partial class UserProfileCyberProgram
    {
        /// <summary>
        /// `active` when at least one tier is `active`, or when the profile has the program's access to earlier models. That access is not a tier: a profile that has it alone reads `active` with every tier `inactive`, or with `tiers` `{}` on a response that does not report tiers. When nothing is `active`, `pending` means that an application or enrollment is under review, or that what Anthropic approved does not yet apply to this profile, and `rejected` means that the application or enrollment was declined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileProgramStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileProgramStatus Status { get; set; }

        /// <summary>
        /// The program's tiers, keyed by tier: `a` (Specialized Access), `b` (Red Team Access) and `c` (Defense Access). A response reports either every tier or none. When it reports them, as retrieving the profile normally does, every tier has a key, whether or not it applies to the profile. When it does not, as in the list of user profiles, `tiers` is `{}`, which does not mean that the tiers are inactive. No tier implies another, so read the tier you need. Anthropic may add tiers; ignore a key you do not recognize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileCyberTier> Tiers { get; set; }

        /// <summary>
        /// What a request that names the profile must allow to get the relaxed safeguards of every `active` tier. `null` when no tier is `active`, and wherever `tiers` is `{}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::Anthropic.UserProfileCyberRequirements? Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileCyberProgram" /> class.
        /// </summary>
        /// <param name="status">
        /// `active` when at least one tier is `active`, or when the profile has the program's access to earlier models. That access is not a tier: a profile that has it alone reads `active` with every tier `inactive`, or with `tiers` `{}` on a response that does not report tiers. When nothing is `active`, `pending` means that an application or enrollment is under review, or that what Anthropic approved does not yet apply to this profile, and `rejected` means that the application or enrollment was declined.
        /// </param>
        /// <param name="tiers">
        /// The program's tiers, keyed by tier: `a` (Specialized Access), `b` (Red Team Access) and `c` (Defense Access). A response reports either every tier or none. When it reports them, as retrieving the profile normally does, every tier has a key, whether or not it applies to the profile. When it does not, as in the list of user profiles, `tiers` is `{}`, which does not mean that the tiers are inactive. No tier implies another, so read the tier you need. Anthropic may add tiers; ignore a key you do not recognize.
        /// </param>
        /// <param name="requirements">
        /// What a request that names the profile must allow to get the relaxed safeguards of every `active` tier. `null` when no tier is `active`, and wherever `tiers` is `{}`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileCyberProgram(
            global::Anthropic.UserProfileProgramStatus status,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileCyberTier> tiers,
            global::Anthropic.UserProfileCyberRequirements? requirements)
        {
            this.Status = status;
            this.Tiers = tiers ?? throw new global::System.ArgumentNullException(nameof(tiers));
            this.Requirements = requirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileCyberProgram" /> class.
        /// </summary>
        public UserProfileCyberProgram()
        {
        }

    }
}