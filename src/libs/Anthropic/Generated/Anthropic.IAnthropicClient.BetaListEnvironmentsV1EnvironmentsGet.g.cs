#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Environments<br/>
        /// List environments with pagination support.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of environments to return<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from previous response for pagination. Pass the `next_page` value from the previous response.
        /// </param>
        /// <param name="includeArchived">
        /// Include archived environments in the response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaEnvironmentListResponse> BetaListEnvironmentsV1EnvironmentsGetAsync(
            int? limit = default,
            string? page = default,
            bool? includeArchived = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}