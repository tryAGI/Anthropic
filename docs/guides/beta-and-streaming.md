# Beta capabilities, streaming and webhooks

The generated client covers every operation in the Claude API specification, including the beta
surface: Managed Agents (agents, environments, sessions, threads, deployments, vaults, memory
stores), Skills, Files, Message Batches, the Admin API, analytics, RBAC, spend limits, tunnels and
webhook endpoints. This guide covers the parts that need more than a generated method call.

## Beta flags

Every beta capability is gated on the `anthropic-beta` header. Pass the flags you need to any
`Beta*` method; the values are a typed enum, so the wire value cannot drift:

```csharp
using var client = new AnthropicClient(apiKey);

var message = await client.BetaMessagesPostAsync(
    new BetaCreateMessageParams
    {
        Model = "claude-opus-5-5",
        MaxTokens = 4096,
        Messages = ["Plan the migration"],
        Speed = Speed.Fast,
    },
    anthropicBeta: [new AnthropicBeta(AnthropicBetaEnum.FastMode20260201)]);
```

`AnthropicBetaEnum` carries the full published set — fast mode, task budgets, compaction, context
management, cache diagnosis, message threads, server-side fallbacks, thinking display updates,
mid-conversation output config, Managed Agents, webhooks and the rest. Several flags can be sent at
once; they are joined with commas.

## Streaming

| Method | Endpoint | Use for |
|--------|----------|---------|
| `CreateMessageAsStreamAsync` | `POST /v1/messages` | Ordinary streaming |
| `CreateBetaMessageAsStreamAsync` | `POST /v1/messages` (beta) | Streaming plus any beta flag |
| `StreamSessionEventsAsStreamAsync` | `GET /v1/sessions/{id}/events/stream` | A Managed Agents session's event log |
| `StreamSessionThreadEventsAsStreamAsync` | `GET /v1/sessions/{id}/threads/{id}/stream` | One session thread |

The specification describes these responses as plain JSON, so the generated methods cannot expose
them as streams — these four hand-written overloads consume them as the server-sent event streams
they are.

```csharp
await foreach (var @event in client.CreateBetaMessageAsStreamAsync(
    new BetaCreateMessageParams
    {
        Model = "claude-sonnet-5-5",
        MaxTokens = 64_000,
        Messages = ["Write the release notes"],
        OutputConfig = new BetaOutputConfig { Effort = BetaEffortLevel.Low },
    }))
{
    Console.Write(@event.ContentBlockDelta?.Delta.TextDelta?.Text);
}
```

Managed Agents sessions stream their whole lifecycle — agent messages and thinking, tool use and
tool results, span and workflow events, session status changes:

```csharp
await foreach (var @event in client.StreamSessionEventsAsStreamAsync(sessionId))
{
    if (@event.AgentMessage is { } agentMessage)
    {
        foreach (var block in agentMessage.Content)
        {
            Console.Write(block.Text?.Text);
        }
    }
    else if (@event.SessionStatusIdle is not null)
    {
        break;
    }
}
```

The `managed-agents-2026-04-01` flag is sent by default on both session stream methods.

## Webhooks

Deliveries carry `webhook-id`, `webhook-timestamp` and `webhook-signature`; the signed content is
`{id}.{timestamp}.{body}`, HMAC-SHA256 under the endpoint's `whsec_` signing secret, and anything
older than five minutes is rejected.

```csharp
var @event = AnthropicWebhooks.Unwrap(headers, rawBody);   // secret from ANTHROPIC_WEBHOOK_SIGNING_KEY

switch (@event.Data)
{
    case { SessionStatusIdled: { } idled }:
        await HandleIdleAsync(idled.Id);
        break;
    case { DeploymentRunFailed: { } failed }:
        await AlertAsync(failed.Id);
        break;
}
```

Verify the body exactly as it arrived — re-serializing the JSON changes the bytes and invalidates
the signature. Payloads are thin on purpose: they carry the event type and resource ids, so fetch
the resource to read its current state. `AnthropicWebhooks.CreateVerifier` returns the verifier on
its own when you want to verify without parsing.
