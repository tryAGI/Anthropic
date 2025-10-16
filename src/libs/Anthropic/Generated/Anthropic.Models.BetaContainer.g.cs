
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Information about the container used in the request (for the code execution tool)
    /// </summary>
    public sealed partial class BetaContainer
    {
        /// <summary>
        /// The time at which the container will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Identifier for the container used in this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Skills loaded in the container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainer" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// The time at which the container will expire.
        /// </param>
        /// <param name="id">
        /// Identifier for the container used in this request
        /// </param>
        /// <param name="skills">
        /// Skills loaded in the container
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContainer(
            global::System.DateTime expiresAt,
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSkill>? skills)
        {
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainer" /> class.
        /// </summary>
        public BetaContainer()
        {
        }
    }
}