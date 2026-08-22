
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeletedSkill
    {
        /// <summary>
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For Skills, this is always `"skill_deleted"`.<br/>
        /// Default Value: skill_deleted
        /// </summary>
        /// <default>"skill_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "skill_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSkill" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Skills, this is always `"skill_deleted"`.<br/>
        /// Default Value: skill_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedSkill(
            string id,
            string type = "skill_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedSkill" /> class.
        /// </summary>
        public DeletedSkill()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DeletedSkill"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DeletedSkill FromId(string id)
        {
            return new DeletedSkill
            {
                Id = id,
            };
        }

    }
}