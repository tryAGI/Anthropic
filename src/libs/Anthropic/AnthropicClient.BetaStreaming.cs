// ReSharper disable RedundantNameQualifier

namespace Anthropic;

public partial class AnthropicClient
{
    /// <summary>
    /// Create a Message on the beta endpoint and stream the response.
    /// </summary>
    /// <remarks>
    /// Use this instead of <see cref="CreateMessageAsStreamAsync"/> whenever the request needs a
    /// beta-only capability: fast mode (<c>speed</c>), task budgets, compaction, context editing,
    /// cache diagnostics, message threads or server-side fallbacks. Pass the matching flags in
    /// <paramref name="anthropicBeta"/>.
    /// </remarks>
    /// <param name="request">The message request. <c>stream</c> is set automatically.</param>
    /// <param name="anthropicBeta">Beta flags to send in the `anthropic-beta` header.</param>
    /// <param name="anthropicVersion">The version of the Claude API you want to use.</param>
    /// <param name="anthropicUserProfileId">The user profile ID to attribute this request to.</param>
    /// <param name="anthropicWorkspaceId">The workspace to attribute this request to.</param>
    /// <param name="cancellationToken">The token to cancel the operation with</param>
    /// <exception cref="global::Anthropic.ApiException"></exception>
    public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaMessageStreamEvent> CreateBetaMessageAsStreamAsync(
        global::Anthropic.BetaCreateMessageParams request,
        global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
        string? anthropicVersion = default,
        string? anthropicUserProfileId = default,
        string? anthropicWorkspaceId = default,
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        return BetaMessagesPostAsStreamAsync(
            request: request,
            anthropicBeta: anthropicBeta,
            anthropicVersion: anthropicVersion,
            anthropicUserProfileId: anthropicUserProfileId,
            anthropicWorkspaceId: anthropicWorkspaceId,
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Streams the event log of a Managed Agents session as it happens.
    /// </summary>
    /// <remarks>
    /// The only thing this adds over the generated
    /// <c>BetaStreamSessionEventsAsStreamAsync</c> is the <c>managed-agents-2026-04-01</c>
    /// beta flag, which the endpoint requires and which the specification does not imply.
    /// </remarks>
    /// <param name="sessionId">The session to stream.</param>
    /// <param name="eventDeltas">Event types that should be delivered as incremental deltas.</param>
    /// <param name="anthropicBeta">Beta flags; defaults to <c>managed-agents-2026-04-01</c>.</param>
    /// <param name="anthropicVersion">The version of the Claude API you want to use.</param>
    /// <param name="anthropicWorkspaceId">The workspace to attribute this request to.</param>
    /// <param name="cancellationToken">The token to cancel the operation with</param>
    /// <exception cref="global::Anthropic.ApiException"></exception>
    public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaManagedAgentsStreamSessionEvents> StreamSessionEventsAsStreamAsync(
        string sessionId,
        global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? eventDeltas = default,
        global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
        string? anthropicVersion = default,
        string? anthropicWorkspaceId = default,
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        return BetaStreamSessionEventsAsStreamAsync(
            sessionId: sessionId,
            anthropicVersion: anthropicVersion,
            anthropicBeta: anthropicBeta ?? DefaultManagedAgentsBetas,
            eventDeltas: eventDeltas,
            anthropicWorkspaceId: anthropicWorkspaceId,
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Streams the event log of a single Managed Agents session thread as it happens.
    /// </summary>
    /// <param name="sessionId">The session that owns the thread.</param>
    /// <param name="threadId">The thread to stream.</param>
    /// <param name="eventDeltas">Event types that should be delivered as incremental deltas.</param>
    /// <param name="anthropicBeta">Beta flags; defaults to <c>managed-agents-2026-04-01</c>.</param>
    /// <param name="anthropicVersion">The version of the Claude API you want to use.</param>
    /// <param name="anthropicWorkspaceId">The workspace to attribute this request to.</param>
    /// <param name="cancellationToken">The token to cancel the operation with</param>
    /// <exception cref="global::Anthropic.ApiException"></exception>
    public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents> StreamSessionThreadEventsAsStreamAsync(
        string sessionId,
        string threadId,
        global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? eventDeltas = default,
        global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
        string? anthropicVersion = default,
        string? anthropicWorkspaceId = default,
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        return BetaStreamSessionThreadEventsAsStreamAsync(
            sessionId: sessionId,
            threadId: threadId,
            anthropicVersion: anthropicVersion,
            anthropicBeta: anthropicBeta ?? DefaultManagedAgentsBetas,
            eventDeltas: eventDeltas,
            anthropicWorkspaceId: anthropicWorkspaceId,
            cancellationToken: cancellationToken);
    }

    private static global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> DefaultManagedAgentsBetas =>
        [new global::Anthropic.AnthropicBeta(global::Anthropic.AnthropicBetaEnum.ManagedAgents20260401)];
}
