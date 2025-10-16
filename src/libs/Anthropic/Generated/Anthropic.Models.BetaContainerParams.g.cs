
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Container parameters with skills to be loaded.
    /// </summary>
    public sealed partial class BetaContainerParams
    {
        /// <summary>
        /// Container id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// List of skills to load in the container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainerParams" /> class.
        /// </summary>
        /// <param name="id">
        /// Container id
        /// </param>
        /// <param name="skills">
        /// List of skills to load in the container
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContainerParams(
            string? id,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSkillParams>? skills)
        {
            this.Id = id;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainerParams" /> class.
        /// </summary>
        public BetaContainerParams()
        {
        }
    }
}