
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Filter skills by source.<br/>
    /// If provided, only skills from the specified source will be returned:<br/>
    /// * `"custom"`: only return user-created skills<br/>
    /// * `"anthropic"`: only return Anthropic-created skills
    /// </summary>
    public sealed partial class BetaListSkillsV1SkillsGetSource
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}