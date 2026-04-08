#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Delete Environment<br/>
        /// Delete an environment by ID. Returns a confirmation of the deletion.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="sessionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaEnvironmentDeleteResponse> BetaDeleteEnvironmentV1EnvironmentsEnvironmentIdDeleteAsync(
            string environmentId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? sessionKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}