
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeletedSkillVersion
    {
        /// <summary>
        /// Unique identifier for this Skill Version. The id addresses the version in<br/>
        /// paths and pins it in references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For Skill Versions, this is always `"skill_version_deleted"`.<br/>
        /// Default Value: skill_version_deleted
        /// </summary>
        /// <default>"skill_version_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "skill_version_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSkillVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this Skill Version. The id addresses the version in<br/>
        /// paths and pins it in references.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Skill Versions, this is always `"skill_version_deleted"`.<br/>
        /// Default Value: skill_version_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedSkillVersion(
            string id,
            string type = "skill_version_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSkillVersion" /> class.
        /// </summary>
        public DeletedSkillVersion()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DeletedSkillVersion"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DeletedSkillVersion FromId(string id)
        {
            return new DeletedSkillVersion
            {
                Id = id,
            };
        }

    }
}