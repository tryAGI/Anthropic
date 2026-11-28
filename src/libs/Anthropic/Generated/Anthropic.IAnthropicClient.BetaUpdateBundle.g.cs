#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Update Bundle<br/>
        /// Change a Bundle's instructions. The update is partial: a field left out is unchanged, and `instructions` sent as null or as an empty string clears them. The later of two updates wins. Sessions that start after the change use the new instructions; sessions already running keep the ones they started with. Some Bundles are managed in claude.ai, and an update of one returns 400.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="bundleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeTagBundle> BetaUpdateBundleAsync(
            string bundleId,

            global::Anthropic.BetaClaudeTagUpdateBundleRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Bundle<br/>
        /// Change a Bundle's instructions. The update is partial: a field left out is unchanged, and `instructions` sent as null or as an empty string clears them. The later of two updates wins. Sessions that start after the change use the new instructions; sessions already running keep the ones they started with. Some Bundles are managed in claude.ai, and an update of one returns 400.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="bundleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaClaudeTagBundle>> BetaUpdateBundleAsResponseAsync(
            string bundleId,

            global::Anthropic.BetaClaudeTagUpdateBundleRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Bundle<br/>
        /// Change a Bundle's instructions. The update is partial: a field left out is unchanged, and `instructions` sent as null or as an empty string clears them. The later of two updates wins. Sessions that start after the change use the new instructions; sessions already running keep the ones they started with. Some Bundles are managed in claude.ai, and an update of one returns 400.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="bundleId"></param>
        /// <param name="instructions">
        /// Instructions for Claude, up to 10,000 bytes (UTF-8), added to the instructions of every session that can use the Bundle. Null or an empty string clears them.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeTagBundle> BetaUpdateBundleAsync(
            string bundleId,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? instructions = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}