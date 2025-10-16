#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create Skill Version
        /// </summary>
        /// <param name="skillId">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.CreateSkillVersionResponse> CreateSkillVersionV1SkillsSkillIdVersionsPostAsync(
            string skillId,
            global::Anthropic.BodyCreateSkillVersionV1SkillsSkillIdVersionsPost request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Skill Version
        /// </summary>
        /// <param name="skillId">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="files">
        /// Files to upload for the skill.<br/>
        /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.CreateSkillVersionResponse> CreateSkillVersionV1SkillsSkillIdVersionsPostAsync(
            string skillId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<byte[]>? files = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}