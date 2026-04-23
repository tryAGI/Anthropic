#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Create a Text Completion<br/>
        /// [Legacy] Create a Text Completion.<br/>
        /// The Text Completions API is a legacy API. We recommend using the [Messages API](https://docs.claude.com/en/api/messages) going forward.<br/>
        /// Future models and features will not be compatible with Text Completions. See our [migration guide](https://docs.claude.com/en/api/migrating-from-text-completions-to-messages) for guidance in migrating from Text Completions to Messages.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.CompletionResponse> CompletePostAsync(

            global::Anthropic.CompletionRequest request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text Completion<br/>
        /// [Legacy] Create a Text Completion.<br/>
        /// The Text Completions API is a legacy API. We recommend using the [Messages API](https://docs.claude.com/en/api/messages) going forward.<br/>
        /// Future models and features will not be compatible with Text Completions. See our [migration guide](https://docs.claude.com/en/api/migrating-from-text-completions-to-messages) for guidance in migrating from Text Completions to Messages.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="prompt">
        /// The prompt that you want Claude to complete.<br/>
        /// For proper response generation you will need to format your prompt using alternating `\n\nHuman:` and `\n\nAssistant:` conversational turns. For example:<br/>
        /// ```<br/>
        /// "\n\nHuman: {userQuestion}\n\nAssistant:"<br/>
        /// ```<br/>
        /// See [prompt validation](https://docs.claude.com/en/api/prompt-validation) and our guide to [prompt design](https://docs.claude.com/en/docs/intro-to-prompting) for more details.
        /// </param>
        /// <param name="maxTokensToSample">
        /// The maximum number of tokens to generate before stopping.<br/>
        /// Note that our models may stop _before_ reaching this maximum. This parameter only specifies the absolute maximum number of tokens to generate.
        /// </param>
        /// <param name="stopSequences">
        /// Sequences that will cause the model to stop generating.<br/>
        /// Our models stop on `"\n\nHuman:"`, and may include additional built-in stop sequences in the future. By providing the stop_sequences parameter, you may include additional strings that will cause the model to stop generating.
        /// </param>
        /// <param name="metadata">
        /// An object describing metadata about the request.
        /// </param>
        /// <param name="stream">
        /// Whether to incrementally stream the response using server-sent events.<br/>
        /// See [streaming](https://docs.claude.com/en/api/streaming) for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.CompletionResponse> CompletePostAsync(
#pragma warning disable CS0618 // Type or member is obsolete
            global::Anthropic.Model model,
#pragma warning disable CS0618 // Type or member is obsolete
            string prompt,
            int maxTokensToSample,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::Anthropic.Metadata? metadata = default,
            bool? stream = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}