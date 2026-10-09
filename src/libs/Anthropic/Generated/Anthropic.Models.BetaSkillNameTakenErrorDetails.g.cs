
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One of the Plugin's skills has the name of an organization skill. `skill_name` is that name.
    /// </summary>
    public sealed partial class BetaSkillNameTakenErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"skill_name_taken"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "skill_name_taken";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillNameTakenErrorDetails" /> class.
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSkillNameTakenErrorDetails(
            string skillName,
            string errorCode = "skill_name_taken")
        {
            this.ErrorCode = errorCode;
            this.SkillName = skillName ?? throw new global::System.ArgumentNullException(nameof(skillName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillNameTakenErrorDetails" /> class.
        /// </summary>
        public BetaSkillNameTakenErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaSkillNameTakenErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaSkillNameTakenErrorDetails FromSkillName(string skillName)
        {
            return new BetaSkillNameTakenErrorDetails
            {
                SkillName = skillName,
            };
        }

    }
}