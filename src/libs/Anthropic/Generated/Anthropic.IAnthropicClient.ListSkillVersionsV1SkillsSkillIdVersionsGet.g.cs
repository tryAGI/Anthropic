#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Skill Versions
        /// </summary>
        /// <param name="skillId">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.ListSkillVersionsResponse> ListSkillVersionsV1SkillsSkillIdVersionsGetAsync(
            string skillId,
            string? page = default,
            int? limit = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}