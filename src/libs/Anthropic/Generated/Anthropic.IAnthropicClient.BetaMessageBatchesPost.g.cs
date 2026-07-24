#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create a Message Batch<br/>
        /// Send a batch of Message creation requests.<br/>
        /// The Message Batches API can be used to process multiple Messages API requests at once. Once a Message Batch is created, it begins processing immediately. Batches can take up to 24 hours to complete.<br/>
        /// Learn more about the Message Batches API in our [user guide](https://platform.claude.com/docs/en/build-with-claude/batch-processing)
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicUserProfileId">
        /// The user profile ID to attribute the requests in this batch to. Use when acting on behalf of a party other than your organization. Requires the `user-profiles` beta header. Applies to every request in the batch; an individual request whose `user_profile_id` body field conflicts with this header is errored.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaMessageBatch> BetaMessageBatchesPostAsync(

            global::Anthropic.BetaCreateMessageBatchParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicUserProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Message Batch<br/>
        /// Send a batch of Message creation requests.<br/>
        /// The Message Batches API can be used to process multiple Messages API requests at once. Once a Message Batch is created, it begins processing immediately. Batches can take up to 24 hours to complete.<br/>
        /// Learn more about the Message Batches API in our [user guide](https://platform.claude.com/docs/en/build-with-claude/batch-processing)
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicUserProfileId">
        /// The user profile ID to attribute the requests in this batch to. Use when acting on behalf of a party other than your organization. Requires the `user-profiles` beta header. Applies to every request in the batch; an individual request whose `user_profile_id` body field conflicts with this header is errored.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaMessageBatch>> BetaMessageBatchesPostAsResponseAsync(

            global::Anthropic.BetaCreateMessageBatchParams request,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicUserProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Message Batch<br/>
        /// Send a batch of Message creation requests.<br/>
        /// The Message Batches API can be used to process multiple Messages API requests at once. Once a Message Batch is created, it begins processing immediately. Batches can take up to 24 hours to complete.<br/>
        /// Learn more about the Message Batches API in our [user guide](https://platform.claude.com/docs/en/build-with-claude/batch-processing)
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicUserProfileId">
        /// The user profile ID to attribute the requests in this batch to. Use when acting on behalf of a party other than your organization. Requires the `user-profiles` beta header. Applies to every request in the batch; an individual request whose `user_profile_id` body field conflicts with this header is errored.
        /// </param>
        /// <param name="requests">
        /// List of requests for prompt completion. Each is an individual request to create a Message.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaMessageBatch> BetaMessageBatchesPostAsync(
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessageBatchIndividualRequestParams> requests,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicUserProfileId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}