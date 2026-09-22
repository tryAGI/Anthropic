#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create a Dream<br/>
        /// Start an asynchronous job that uses past sessions to produce a reorganized version of a memory store and get back the dream to poll for the result.<br/>
        /// By default the dream writes its result to a new memory store and doesn't change the input memory store. The response has `status` set to `pending` and an empty `outputs` array. Poll the dream until `status` is `completed`, `failed`, or `canceled`.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#create-a-dream) to learn more about creating dreams.
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaDream> BetaCreateDreamAsync(

            global::Anthropic.BetaCreateDreamRequest request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Dream<br/>
        /// Start an asynchronous job that uses past sessions to produce a reorganized version of a memory store and get back the dream to poll for the result.<br/>
        /// By default the dream writes its result to a new memory store and doesn't change the input memory store. The response has `status` set to `pending` and an empty `outputs` array. Poll the dream until `status` is `completed`, `failed`, or `canceled`.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#create-a-dream) to learn more about creating dreams.
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaDream>> BetaCreateDreamAsResponseAsync(

            global::Anthropic.BetaCreateDreamRequest request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Dream<br/>
        /// Start an asynchronous job that uses past sessions to produce a reorganized version of a memory store and get back the dream to poll for the result.<br/>
        /// By default the dream writes its result to a new memory store and doesn't change the input memory store. The response has `status` set to `pending` and an empty `outputs` array. Poll the dream until `status` is `completed`, `failed`, or `canceled`.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#create-a-dream) to learn more about creating dreams.
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="inputs">
        /// The memory store and sessions for the dream to read, as exactly one `memory_store` entry and exactly one `sessions` entry.
        /// </param>
        /// <param name="model">
        /// The model that runs a dream, given as a model ID or as an object with `id` and `speed`.<br/>
        /// In the object form, `speed` can only be `standard`.<br/>
        /// The [limits table in the Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#limits) lists the supported models.
        /// </param>
        /// <param name="instructions">
        /// Guidance that steers how the dream reads the sessions and organizes the output memory store, from 1 to 4,096 characters.<br/>
        /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#steer-with-instructions) for what kinds of instructions work well.
        /// </param>
        /// <param name="outputBehavior">
        /// Which memory store a dream writes its result to. Defaults to `create_new` when left out of a create request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaDream> BetaCreateDreamAsync(
            global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput> inputs,
            global::Anthropic.BetaDreamModelParams model,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicWorkspaceId = default,
            string? instructions = default,
            global::Anthropic.BetaOutputBehavior? outputBehavior = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}