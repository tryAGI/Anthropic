
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUpdateUserParams
    {
        /// <summary>
        /// New role for the User.<br/>
        /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUpdateUserParamsRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUpdateUserParamsRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserParams" /> class.
        /// </summary>
        /// <param name="role">
        /// New role for the User.<br/>
        /// The accepted values depend on the organization type. Console and API organizations accept `user`, `developer`, `billing`, and `claude_code_user`; `admin` cannot be assigned through the API. Claude Enterprise organizations accept `user` and `managed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateUserParams(
            global::Anthropic.BetaUpdateUserParamsRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserParams" /> class.
        /// </summary>
        public BetaUpdateUserParams()
        {
        }

    }
}