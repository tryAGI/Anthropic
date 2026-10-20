
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One feature of Enterprise Frontier Safeguards.<br/>
    /// Example: {"status":"active"}
    /// </summary>
    public sealed partial class UserProfileEfsFeature
    {
        /// <summary>
        /// `active` when Anthropic has approved the entity the profile represents to use the feature, otherwise `inactive`. `active` does not mean that the feature is set up or switched on, which is a separate step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileEfsFeatureStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileEfsFeatureStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEfsFeature" /> class.
        /// </summary>
        /// <param name="status">
        /// `active` when Anthropic has approved the entity the profile represents to use the feature, otherwise `inactive`. `active` does not mean that the feature is set up or switched on, which is a separate step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileEfsFeature(
            global::Anthropic.UserProfileEfsFeatureStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEfsFeature" /> class.
        /// </summary>
        public UserProfileEfsFeature()
        {
        }

    }
}