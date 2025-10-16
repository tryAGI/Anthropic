#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get a Model<br/>
        /// Get a specific model.<br/>
        /// The Models API response can be used to determine information about a specific model or resolve a model alias to a model ID.
        /// </summary>
        /// <param name="modelId">
        /// Model identifier or alias.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaModelInfo> BetaModelsGetAsync(
            string modelId,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? anthropicBeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}