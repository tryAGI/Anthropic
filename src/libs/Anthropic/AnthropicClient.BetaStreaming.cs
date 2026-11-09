using System.Runtime.CompilerServices;

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
    public async IAsyncEnumerable<global::Anthropic.BetaMessageStreamEvent> CreateBetaMessageAsStreamAsync(
        global::Anthropic.BetaCreateMessageParams request,
        global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
        string? anthropicVersion = default,
        string? anthropicUserProfileId = default,
        string? anthropicWorkspaceId = default,
        [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
    {
        request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        request.Stream = true;

        var serializerContext = JsonSerializerContextProvider?.Value;
        var body = serializerContext is null
            ? request.ToJson()
            : request.ToJson(serializerContext);

        var events = SendServerSentEventsAsync(
            method: global::System.Net.Http.HttpMethod.Post,
            path: "/v1/messages",
            jsonBody: body,
            anthropicBeta: anthropicBeta,
            anthropicVersion: anthropicVersion,
            anthropicUserProfileId: anthropicUserProfileId,
            anthropicWorkspaceId: anthropicWorkspaceId,
            cancellationToken: cancellationToken);

        await foreach (var data in events.ConfigureAwait(false))
        {
            var block = serializerContext is null
                ? global::Anthropic.BetaMessageStreamEvent.FromJson(data)
                : global::Anthropic.BetaMessageStreamEvent.FromJson(data, serializerContext);
            if (block == null)
            {
                yield break;
            }

            yield return block.Value;
        }
    }

    /// <summary>
    /// Streams the event log of a Managed Agents session as it happens.
    /// </summary>
    /// <remarks>
    /// The generated <see cref="BetaStreamSessionEventsAsync"/> overload returns a single event
    /// because the specification describes the response as plain JSON; this overload consumes the
    /// endpoint as the server-sent event stream it actually is. Requires the
    /// <c>managed-agents-2026-04-01</c> beta flag, which is sent by default.
    /// </remarks>
    /// <param name="sessionId">The session to stream.</param>
    /// <param name="eventDeltas">Event types that should be delivered as incremental deltas.</param>
    /// <param name="anthropicBeta">Beta flags; defaults to <c>managed-agents-2026-04-01</c>.</param>
    /// <param name="anthropicVersion">The version of the Claude API you want to use.</param>
    /// <param name="anthropicWorkspaceId">The workspace to attribute this request to.</param>
    /// <param name="cancellationToken">The token to cancel the operation with</param>
    /// <exception cref="global::Anthropic.ApiException"></exception>
    public async IAsyncEnumerable<global::Anthropic.BetaManagedAgentsStreamSessionEvents> StreamSessionEventsAsStreamAsync(
        string sessionId,
        global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? eventDeltas = default,
        global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
        string? anthropicVersion = default,
        string? anthropicWorkspaceId = default,
        [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
    {
        var serializerContext = JsonSerializerContextProvider?.Value;
        var events = SendServerSentEventsAsync(
            method: global::System.Net.Http.HttpMethod.Get,
            path: BuildEventStreamPath($"/v1/sessions/{sessionId}/events/stream", eventDeltas),
            anthropicBeta: anthropicBeta ?? DefaultManagedAgentsBetas,
            anthropicVersion: anthropicVersion,
            anthropicWorkspaceId: anthropicWorkspaceId,
            cancellationToken: cancellationToken);

        await foreach (var data in events.ConfigureAwait(false))
        {
            var @event = serializerContext is null
                ? global::Anthropic.BetaManagedAgentsStreamSessionEvents.FromJson(data)
                : global::Anthropic.BetaManagedAgentsStreamSessionEvents.FromJson(data, serializerContext);
            if (@event == null)
            {
                yield break;
            }

            yield return @event.Value;
        }
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
    public async IAsyncEnumerable<global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents> StreamSessionThreadEventsAsStreamAsync(
        string sessionId,
        string threadId,
        global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? eventDeltas = default,
        global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
        string? anthropicVersion = default,
        string? anthropicWorkspaceId = default,
        [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
    {
        var serializerContext = JsonSerializerContextProvider?.Value;
        var events = SendServerSentEventsAsync(
            method: global::System.Net.Http.HttpMethod.Get,
            path: BuildEventStreamPath($"/v1/sessions/{sessionId}/threads/{threadId}/stream", eventDeltas),
            anthropicBeta: anthropicBeta ?? DefaultManagedAgentsBetas,
            anthropicVersion: anthropicVersion,
            anthropicWorkspaceId: anthropicWorkspaceId,
            cancellationToken: cancellationToken);

        await foreach (var data in events.ConfigureAwait(false))
        {
            var @event = serializerContext is null
                ? global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents.FromJson(data)
                : global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents.FromJson(data, serializerContext);
            if (@event == null)
            {
                yield break;
            }

            yield return @event.Value;
        }
    }

    private static global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> DefaultManagedAgentsBetas =>
        [new global::Anthropic.AnthropicBeta(global::Anthropic.AnthropicBetaEnum.ManagedAgents20260401)];

    private static string BuildEventStreamPath(
        string path,
        global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? eventDeltas)
    {
        if (eventDeltas is not { Count: > 0 })
        {
            return path;
        }

        var builder = new global::Anthropic.PathBuilder(path: path, baseUri: null);
        builder.AddOptionalParameter("event_deltas[]", eventDeltas, selector: static x => x.ToValueString(), delimiter: ",", explode: true);

        return builder.ToString();
    }
}
