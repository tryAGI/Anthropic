
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaExternalStorageCreateParams
    {
        /// <summary>
        /// Human-friendly display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ProviderConfig6JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ProviderConfig6 ProviderConfig { get; set; }

        /// <summary>
        /// The user profile to bind the storage to. It can't be changed later. The storage can be attached only to Workspaces with this profile, and the bucket's setup must name the same ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageCreateParams" /> class.
        /// </summary>
        /// <param name="providerConfig"></param>
        /// <param name="displayName">
        /// Human-friendly display name.
        /// </param>
        /// <param name="userProfileId">
        /// The user profile to bind the storage to. It can't be changed later. The storage can be attached only to Workspaces with this profile, and the bucket's setup must name the same ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorageCreateParams(
            global::Anthropic.ProviderConfig6 providerConfig,
            string? displayName,
            string? userProfileId)
        {
            this.DisplayName = displayName;
            this.ProviderConfig = providerConfig;
            this.UserProfileId = userProfileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageCreateParams" /> class.
        /// </summary>
        public BetaExternalStorageCreateParams()
        {
        }

    }
}