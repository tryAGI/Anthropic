
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"status":"active"}
    /// </summary>
    public sealed partial class BetaUserProfileTrustGrant
    {
        /// <summary>
        /// Status of the trust grant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUserProfileTrustGrantStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUserProfileTrustGrantStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileTrustGrant" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the trust grant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfileTrustGrant(
            global::Anthropic.BetaUserProfileTrustGrantStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileTrustGrant" /> class.
        /// </summary>
        public BetaUserProfileTrustGrant()
        {
        }
    }
}