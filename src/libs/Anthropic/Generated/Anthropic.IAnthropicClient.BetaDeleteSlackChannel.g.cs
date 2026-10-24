#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Remove Slack Channel<br/>
        /// Remove a Slack channel from Claude Tag. This deletes the channel's stored settings and its Bundle Targets at once, and then, in the background, the channel's sessions and their transcripts, its memory, its routines and the artifacts published from it. None of it can be restored. The channel in Slack and its messages are unchanged. The request is refused with 400 and `error.details.error_code` `slack_channel_enabled` while `enabled` resolves to `true` for the channel, as a read with `include_inherited=true` returns it: set `enabled` to `false` on the channel first. This guards against removing a channel in use by mistake; it is not a way to keep Claude out, because the removal deletes the channel's own `enabled: false` with its other settings, after which the channel inherits again and Claude's next use of it can set it up anew with a new identifier. The identifier returns 404 as soon as the request returns, so a repeated removal returns 404. A group direct message returns 400, and so does a channel that holds configuration this API does not manage.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaClaudeTagDeletedSlackChannel> BetaDeleteSlackChannelAsync(
            string id,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Slack Channel<br/>
        /// Remove a Slack channel from Claude Tag. This deletes the channel's stored settings and its Bundle Targets at once, and then, in the background, the channel's sessions and their transcripts, its memory, its routines and the artifacts published from it. None of it can be restored. The channel in Slack and its messages are unchanged. The request is refused with 400 and `error.details.error_code` `slack_channel_enabled` while `enabled` resolves to `true` for the channel, as a read with `include_inherited=true` returns it: set `enabled` to `false` on the channel first. This guards against removing a channel in use by mistake; it is not a way to keep Claude out, because the removal deletes the channel's own `enabled: false` with its other settings, after which the channel inherits again and Claude's next use of it can set it up anew with a new identifier. The identifier returns 404 as soon as the request returns, so a repeated removal returns 404. A group direct message returns 400, and so does a channel that holds configuration this API does not manage.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `experimental-claude-tag-2026-10-21` in this header.
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaClaudeTagDeletedSlackChannel>> BetaDeleteSlackChannelAsResponseAsync(
            string id,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}