
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteSkillVersionResponse
    {
        /// <summary>
        /// Version identifier for the skill.<br/>
        /// Each version is identified by a Unix epoch timestamp (e.g., "1759178010641129").<br/>
        /// Example: 1759178010641129
        /// </summary>
        /// <example>1759178010641129</example>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "skill_version_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSkillVersionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Version identifier for the skill.<br/>
        /// Each version is identified by a Unix epoch timestamp (e.g., "1759178010641129").<br/>
        /// Example: 1759178010641129
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Skill Versions, this is always `"skill_version_deleted"`.<br/>
        /// Default Value: skill_version_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSkillVersionResponse(
            string id,
            string type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSkillVersionResponse" /> class.
        /// </summary>
        public DeleteSkillVersionResponse()
        {
        }
    }
}