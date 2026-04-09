#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Environment<br/>
        /// Update an existing environment's configuration.
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaEnvironment> BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostAsync(
            string environmentId,

            global::Anthropic.BetaPublicEnvironmentUpdateRequest request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Environment<br/>
        /// Update an existing environment's configuration.
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
        /// <param name="config">
        /// Updated environment configuration
        /// </param>
        /// <param name="description">
        /// Updated description of the environment
        /// </param>
        /// <param name="metadata">
        /// User-provided metadata key-value pairs. Set a value to null or empty string to delete the key.
        /// </param>
        /// <param name="name">
        /// Updated name for the environment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaEnvironment> BetaUpdateEnvironmentV1EnvironmentsEnvironmentIdPostAsync(
            string environmentId,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.ConfigVariant12? config = default,
            string? description = default,
            object? metadata = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}