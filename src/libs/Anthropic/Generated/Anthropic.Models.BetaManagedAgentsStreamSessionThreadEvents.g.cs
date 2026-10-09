#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Server-sent event in a single thread's stream.
    /// </summary>
    public readonly partial struct BetaManagedAgentsStreamSessionThreadEvents : global::System.IEquatable<BetaManagedAgentsStreamSessionThreadEvents>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? Type { get; }

        /// <summary>
        /// A user message event in the session conversation.<br/>
        /// Example: {"type":"user.message","id":"sevt_011CZkZGPp1iBcp4kaQSihUm","content":[{"type":"text","text":"Where is my order #1234?"}],"processed_at":"2026-03-15T10:00:00Z"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? UserMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? UserMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserMessageEvent? value)
        {
            value = UserMessage;
            return IsUserMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEvent PickUserMessage() => UserMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMessage' but the value was {ToString()}.");

        /// <summary>
        /// An interrupt event that pauses agent execution and returns control to the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? UserInterrupt { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? UserInterrupt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserInterrupt))]
#endif
        public bool IsUserInterrupt => UserInterrupt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserInterrupt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserInterruptEvent? value)
        {
            value = UserInterrupt;
            return IsUserInterrupt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent PickUserInterrupt() => UserInterrupt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserInterrupt' but the value was {ToString()}.");

        /// <summary>
        /// A tool confirmation event that approves or denies a pending tool execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? UserToolConfirmation { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? UserToolConfirmation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserToolConfirmation))]
#endif
        public bool IsUserToolConfirmation => UserToolConfirmation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserToolConfirmation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? value)
        {
            value = UserToolConfirmation;
            return IsUserToolConfirmation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent PickUserToolConfirmation() => UserToolConfirmation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserToolConfirmation' but the value was {ToString()}.");

        /// <summary>
        /// Event sent by the client providing the result of a custom tool execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? UserCustomToolResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? UserCustomToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserCustomToolResult))]
#endif
        public bool IsUserCustomToolResult => UserCustomToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserCustomToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? value)
        {
            value = UserCustomToolResult;
            return IsUserCustomToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent PickUserCustomToolResult() => UserCustomToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserCustomToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when the agent calls a custom tool. The session goes idle until the client sends a `user.custom_tool_result` event with the result.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? AgentCustomToolUse { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? AgentCustomToolUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentCustomToolUse))]
#endif
        public bool IsAgentCustomToolUse => AgentCustomToolUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentCustomToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? value)
        {
            value = AgentCustomToolUse;
            return IsAgentCustomToolUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent PickAgentCustomToolUse() => AgentCustomToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentCustomToolUse' but the value was {ToString()}.");

        /// <summary>
        /// An agent response event in the session conversation.<br/>
        /// Example: {"type":"agent.message","id":"sevt_011CZkZHPq1jCdq5mbRTjiVn","content":[{"type":"text","text":"Let me look up order #1234 for you."}],"processed_at":"2026-03-15T10:00:00Z"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent? AgentMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent? AgentMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessage))]
#endif
        public bool IsAgentMessage => AgentMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentMessageEvent? value)
        {
            value = AgentMessage;
            return IsAgentMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent PickAgentMessage() => AgentMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessage' but the value was {ToString()}.");

        /// <summary>
        /// Indicates the agent is making forward progress via extended thinking. A progress signal, not a content carrier.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent? AgentThinking { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent? AgentThinking { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinking))]
#endif
        public bool IsAgentThinking => AgentThinking != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentThinkingEvent? value)
        {
            value = AgentThinking;
            return IsAgentThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent PickAgentThinking() => AgentThinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentThinking' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when the agent invokes a tool provided by an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? AgentMcpToolUse { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? AgentMcpToolUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMcpToolUse))]
#endif
        public bool IsAgentMcpToolUse => AgentMcpToolUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentMcpToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? value)
        {
            value = AgentMcpToolUse;
            return IsAgentMcpToolUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent PickAgentMcpToolUse() => AgentMcpToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMcpToolUse' but the value was {ToString()}.");

        /// <summary>
        /// Event representing the result of an MCP tool execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? AgentMcpToolResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? AgentMcpToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMcpToolResult))]
#endif
        public bool IsAgentMcpToolResult => AgentMcpToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentMcpToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? value)
        {
            value = AgentMcpToolResult;
            return IsAgentMcpToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent PickAgentMcpToolResult() => AgentMcpToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMcpToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when the agent invokes a built-in agent tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent? AgentToolUse { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent? AgentToolUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentToolUse))]
#endif
        public bool IsAgentToolUse => AgentToolUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentToolUseEvent? value)
        {
            value = AgentToolUse;
            return IsAgentToolUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent PickAgentToolUse() => AgentToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentToolUse' but the value was {ToString()}.");

        /// <summary>
        /// Event representing the result of an agent tool execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent? AgentToolResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent? AgentToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentToolResult))]
#endif
        public bool IsAgentToolResult => AgentToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentToolResultEvent? value)
        {
            value = AgentToolResult;
            return IsAgentToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent PickAgentToolResult() => AgentToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Delivery event written to the target thread's input stream when an agent-to-agent message arrives.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? AgentThreadMessageReceived { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? AgentThreadMessageReceived { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThreadMessageReceived))]
#endif
        public bool IsAgentThreadMessageReceived => AgentThreadMessageReceived != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentThreadMessageReceived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? value)
        {
            value = AgentThreadMessageReceived;
            return IsAgentThreadMessageReceived;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent PickAgentThreadMessageReceived() => AgentThreadMessageReceived is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentThreadMessageReceived' but the value was {ToString()}.");

        /// <summary>
        /// Observability event emitted to the sender's output stream when an agent-to-agent message is sent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? AgentThreadMessageSent { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? AgentThreadMessageSent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThreadMessageSent))]
#endif
        public bool IsAgentThreadMessageSent => AgentThreadMessageSent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentThreadMessageSent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? value)
        {
            value = AgentThreadMessageSent;
            return IsAgentThreadMessageSent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent PickAgentThreadMessageSent() => AgentThreadMessageSent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentThreadMessageSent' but the value was {ToString()}.");

        /// <summary>
        /// Indicates that context compaction (summarization) occurred during the session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? AgentThreadContextCompacted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? AgentThreadContextCompacted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThreadContextCompacted))]
#endif
        public bool IsAgentThreadContextCompacted => AgentThreadContextCompacted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentThreadContextCompacted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? value)
        {
            value = AgentThreadContextCompacted;
            return IsAgentThreadContextCompacted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent PickAgentThreadContextCompacted() => AgentThreadContextCompacted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentThreadContextCompacted' but the value was {ToString()}.");

        /// <summary>
        /// An error event indicating a problem occurred during session execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent? SessionError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent? SessionError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionError))]
#endif
        public bool IsSessionError => SessionError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionErrorEvent? value)
        {
            value = SessionError;
            return IsSessionError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent PickSessionError() => SessionError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionError' but the value was {ToString()}.");

        /// <summary>
        /// Indicates the session is recovering from an error state and is rescheduled for execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? SessionStatusRescheduled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? SessionStatusRescheduled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusRescheduled))]
#endif
        public bool IsSessionStatusRescheduled => SessionStatusRescheduled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionStatusRescheduled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? value)
        {
            value = SessionStatusRescheduled;
            return IsSessionStatusRescheduled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent PickSessionStatusRescheduled() => SessionStatusRescheduled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusRescheduled' but the value was {ToString()}.");

        /// <summary>
        /// Indicates the session is actively running and the agent is working.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? SessionStatusRunning { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? SessionStatusRunning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusRunning))]
#endif
        public bool IsSessionStatusRunning => SessionStatusRunning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionStatusRunning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? value)
        {
            value = SessionStatusRunning;
            return IsSessionStatusRunning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent PickSessionStatusRunning() => SessionStatusRunning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusRunning' but the value was {ToString()}.");

        /// <summary>
        /// Indicates the agent has paused and is awaiting user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? SessionStatusIdle { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? SessionStatusIdle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusIdle))]
#endif
        public bool IsSessionStatusIdle => SessionStatusIdle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionStatusIdle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? value)
        {
            value = SessionStatusIdle;
            return IsSessionStatusIdle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent PickSessionStatusIdle() => SessionStatusIdle is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusIdle' but the value was {ToString()}.");

        /// <summary>
        /// Indicates the session has terminated, either due to an error or completion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? SessionStatusTerminated { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? SessionStatusTerminated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusTerminated))]
#endif
        public bool IsSessionStatusTerminated => SessionStatusTerminated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionStatusTerminated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? value)
        {
            value = SessionStatusTerminated;
            return IsSessionStatusTerminated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent PickSessionStatusTerminated() => SessionStatusTerminated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusTerminated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a child thread is created. Written to the parent thread's output stream so clients observing the session see child creation.<br/>
        /// Example: {"type":"session.thread_created","id":"sevt_011CZkZWXb7pJkx1shYaqoCu","session_thread_id":"sthr_011CZkZVWa6oJjw1rgXZpnBt","processed_at":"2026-03-15T10:00:00Z","agent_name":"Researcher","workflow_run_id":null}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? SessionThreadCreated { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? SessionThreadCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadCreated))]
#endif
        public bool IsSessionThreadCreated => SessionThreadCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionThreadCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? value)
        {
            value = SessionThreadCreated;
            return IsSessionThreadCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent PickSessionThreadCreated() => SessionThreadCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an outcome evaluation cycle begins.<br/>
        /// Example: {"type":"span.outcome_evaluation_start","id":"sevt_011CZkZTUy4mGhu8peVXnmzr","processed_at":"2026-03-15T10:02:14Z","iteration":0,"outcome_id":"outc_011CZkZRSw2kEfs6ncTVmjxP"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? SpanOutcomeEvaluationStart { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? SpanOutcomeEvaluationStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpanOutcomeEvaluationStart))]
#endif
        public bool IsSpanOutcomeEvaluationStart => SpanOutcomeEvaluationStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpanOutcomeEvaluationStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? value)
        {
            value = SpanOutcomeEvaluationStart;
            return IsSpanOutcomeEvaluationStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent PickSpanOutcomeEvaluationStart() => SpanOutcomeEvaluationStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanOutcomeEvaluationStart' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an outcome evaluation cycle completes. Carries the verdict and aggregate token usage. A verdict of `needs_revision` means another evaluation cycle follows; `satisfied`, `max_iterations_reached`, `failed`, or `interrupted` are terminal — no further evaluation cycles follow.<br/>
        /// Example: {"type":"span.outcome_evaluation_end","id":"sevt_011CZkZUVz5nHiv9qfWYomas","processed_at":"2026-03-15T10:02:31Z","outcome_evaluation_start_id":"sevt_011CZkZTUy4mGhu8peVXnmzr","iteration":0,"result":"satisfied","explanation":"All five sections present with inline citations.","usage":{"input_tokens":1842,"output_tokens":213,"cache_creation_input_tokens":0,"cache_read_input_tokens":1536},"outcome_id":"outc_011CZkZRSw2kEfs6ncTVmjxP"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? SpanOutcomeEvaluationEnd { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? SpanOutcomeEvaluationEnd { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpanOutcomeEvaluationEnd))]
#endif
        public bool IsSpanOutcomeEvaluationEnd => SpanOutcomeEvaluationEnd != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpanOutcomeEvaluationEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? value)
        {
            value = SpanOutcomeEvaluationEnd;
            return IsSpanOutcomeEvaluationEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent PickSpanOutcomeEvaluationEnd() => SpanOutcomeEvaluationEnd is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanOutcomeEvaluationEnd' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a model request is initiated by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? SpanModelRequestStart { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? SpanModelRequestStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpanModelRequestStart))]
#endif
        public bool IsSpanModelRequestStart => SpanModelRequestStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpanModelRequestStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? value)
        {
            value = SpanModelRequestStart;
            return IsSpanModelRequestStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent PickSpanModelRequestStart() => SpanModelRequestStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanModelRequestStart' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a model request completes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? SpanModelRequestEnd { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? SpanModelRequestEnd { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpanModelRequestEnd))]
#endif
        public bool IsSpanModelRequestEnd => SpanModelRequestEnd != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpanModelRequestEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? value)
        {
            value = SpanModelRequestEnd;
            return IsSpanModelRequestEnd;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent PickSpanModelRequestEnd() => SpanModelRequestEnd is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanModelRequestEnd' but the value was {ToString()}.");

        /// <summary>
        /// Periodic heartbeat emitted while an outcome evaluation cycle is in progress. Distinguishes 'evaluation is actively running' from 'evaluation is stuck' between the corresponding `span.outcome_evaluation_start` and `span.outcome_evaluation_end` events.<br/>
        /// Example: {"type":"span.outcome_evaluation_ongoing","id":"sevt_011CZkZbCG2uPpc6xmDfvTzh","processed_at":"2026-03-15T10:02:14Z","iteration":0,"outcome_id":"outc_011CZkZRSw2kEfs6ncTVmjxP"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? SpanOutcomeEvaluationOngoing { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? SpanOutcomeEvaluationOngoing { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpanOutcomeEvaluationOngoing))]
#endif
        public bool IsSpanOutcomeEvaluationOngoing => SpanOutcomeEvaluationOngoing != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpanOutcomeEvaluationOngoing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? value)
        {
            value = SpanOutcomeEvaluationOngoing;
            return IsSpanOutcomeEvaluationOngoing;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent PickSpanOutcomeEvaluationOngoing() => SpanOutcomeEvaluationOngoing is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanOutcomeEvaluationOngoing' but the value was {ToString()}.");

        /// <summary>
        /// Echo of a `user.define_outcome` input event. Carries the server-generated `outcome_id` that subsequent `span.outcome_evaluation_*` events reference.<br/>
        /// Example: {"type":"user.define_outcome","id":"sevt_011CZkZSTx3mFgt7odUWmkyq","processed_at":"2026-03-15T10:02:14Z","outcome_id":"outc_011CZkZRSw2kEfs6ncTVmjxP","description":"Produce a 2-page summary as summary.md","max_iterations":3,"rubric":{"type":"text","content":"Must cover all five sections; cite sources inline."}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? UserDefineOutcome { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? UserDefineOutcome { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserDefineOutcome))]
#endif
        public bool IsUserDefineOutcome => UserDefineOutcome != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserDefineOutcome(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? value)
        {
            value = UserDefineOutcome;
            return IsUserDefineOutcome;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent PickUserDefineOutcome() => UserDefineOutcome is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserDefineOutcome' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session has been deleted. Terminates any active event stream — no further events will be emitted for this session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent? SessionDeleted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent? SessionDeleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionDeleted))]
#endif
        public bool IsSessionDeleted => SessionDeleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionDeletedEvent? value)
        {
            value = SessionDeleted;
            return IsSessionDeleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent PickSessionDeleted() => SessionDeleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionDeleted' but the value was {ToString()}.");

        /// <summary>
        /// A session thread has begun executing. Emitted on the thread's own stream and cross-posted to the primary stream for child threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? SessionThreadStatusRunning { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? SessionThreadStatusRunning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadStatusRunning))]
#endif
        public bool IsSessionThreadStatusRunning => SessionThreadStatusRunning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionThreadStatusRunning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? value)
        {
            value = SessionThreadStatusRunning;
            return IsSessionThreadStatusRunning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent PickSessionThreadStatusRunning() => SessionThreadStatusRunning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadStatusRunning' but the value was {ToString()}.");

        /// <summary>
        /// A session thread has yielded and is awaiting input. Emitted on the thread's own stream and cross-posted to the primary stream for child threads.<br/>
        /// Example: {"type":"session.thread_status_idle","id":"sevt_011CZkZXYc8qKmy2tiZbrpDv","session_thread_id":"sthr_011CZkZVWa6oJjw1rgXZpnBt","processed_at":"2026-03-15T10:00:00Z","agent_name":"Researcher","stop_reason":{"type":"end_turn"},"stop_details":null}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? SessionThreadStatusIdle { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? SessionThreadStatusIdle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadStatusIdle))]
#endif
        public bool IsSessionThreadStatusIdle => SessionThreadStatusIdle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionThreadStatusIdle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? value)
        {
            value = SessionThreadStatusIdle;
            return IsSessionThreadStatusIdle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent PickSessionThreadStatusIdle() => SessionThreadStatusIdle is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadStatusIdle' but the value was {ToString()}.");

        /// <summary>
        /// A session thread has terminated and will accept no further input. Emitted on the thread's own stream and cross-posted to the primary stream for child threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? SessionThreadStatusTerminated { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? SessionThreadStatusTerminated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadStatusTerminated))]
#endif
        public bool IsSessionThreadStatusTerminated => SessionThreadStatusTerminated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionThreadStatusTerminated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? value)
        {
            value = SessionThreadStatusTerminated;
            return IsSessionThreadStatusTerminated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent PickSessionThreadStatusTerminated() => SessionThreadStatusTerminated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadStatusTerminated' but the value was {ToString()}.");

        /// <summary>
        /// Event sent by the client providing the result of an agent-toolset tool execution. Only valid on `self_hosted` environments, where sandbox-routed tools are executed by the client rather than the server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? UserToolResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? UserToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserToolResult))]
#endif
        public bool IsUserToolResult => UserToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserToolResultEvent? value)
        {
            value = UserToolResult;
            return IsUserToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent PickUserToolResult() => UserToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserToolResult' but the value was {ToString()}.");

        /// <summary>
        /// A session thread hit a transient error and is retrying automatically. Emitted on the thread's own stream and cross-posted to the primary stream for child threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? SessionThreadStatusRescheduled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? SessionThreadStatusRescheduled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadStatusRescheduled))]
#endif
        public bool IsSessionThreadStatusRescheduled => SessionThreadStatusRescheduled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionThreadStatusRescheduled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? value)
        {
            value = SessionThreadStatusRescheduled;
            return IsSessionThreadStatusRescheduled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent PickSessionThreadStatusRescheduled() => SessionThreadStatusRescheduled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadStatusRescheduled' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an UpdateSession request changed at least one field. Carries only the fields that changed; absent fields were not part of the update. The new configuration applies from the next turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? SessionUpdated { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? SessionUpdated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent PickSessionUpdated() => SessionUpdated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        /// Opens a preview of a buffered event. Carries the previewed event's type and id only. Followed by zero or more event_delta events with the same event id, normally concluded by the buffered event carrying that id. If the producing model request ends without that event (an error or interrupt mid-stream), its terminal span.model_request_end closes the preview. Only sent on stream connections that opt in via event_deltas; never appears in event history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEventStartEvent? EventStart { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEventStartEvent? EventStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EventStart))]
#endif
        public bool IsEventStart => EventStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEventStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEventStartEvent? value)
        {
            value = EventStart;
            return IsEventStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEvent PickEventStart() => EventStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EventStart' but the value was {ToString()}.");

        /// <summary>
        /// An incremental update to an event that is still being streamed. Deltas are best-effort and may stop early; when the buffered event with id == event_id is produced it carries the complete content. A model request that ends early (an error or interrupt) produces no buffered event — its terminal span.model_request_end closes the preview. Only sent on stream connections that opt in via event_deltas; never appears in event history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent? EventDelta { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent? EventDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EventDelta))]
#endif
        public bool IsEventDelta => EventDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEventDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEventDeltaEvent? value)
        {
            value = EventDelta;
            return IsEventDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent PickEventDelta() => EventDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EventDelta' but the value was {ToString()}.");

        /// <summary>
        /// A mid-conversation system message event. Carries system-role content that is appended to the session as a `role: "system"` turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? SystemMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? SystemMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSystemMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSystemMessageEvent? value)
        {
            value = SystemMessage;
            return IsSystemMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent PickSystemMessage() => SystemMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemMessage' but the value was {ToString()}.");

        /// <summary>
        /// Periodic snapshot of the session's cumulative usage and tracked list cost.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent? SessionUsage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent? SessionUsage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUsage))]
#endif
        public bool IsSessionUsage => SessionUsage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionUsage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionUsageEvent? value)
        {
            value = SessionUsage;
            return IsSessionUsage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionUsageEvent PickSessionUsage() => SessionUsage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUsage' but the value was {ToString()}.");

        /// <summary>
        /// A workflow run was created. A workflow run is background work that the session's agent starts. Emitted once per run, before the run's other `workflow_run.*` events.<br/>
        /// Example: {"type":"workflow_run.created","id":"sevt_01JQ8Z6X8K2N4V7T9B3C5D1E","processed_at":"2026-10-01T18:02:11.412Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd","name":"Compare the vendors","description":"Reads each vendor\u0027s pricing page and tabulates the plans.","phases":[{"id":"wrph_011CZm4Kq7RtY2Wn8Vx3LbHd","name":"Collect the sources","description":null}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? WorkflowRunCreated { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? WorkflowRunCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRunCreated))]
#endif
        public bool IsWorkflowRunCreated => WorkflowRunCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRunCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? value)
        {
            value = WorkflowRunCreated;
            return IsWorkflowRunCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent PickWorkflowRunCreated() => WorkflowRunCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRunCreated' but the value was {ToString()}.");

        /// <summary>
        /// A workflow run ended. Emitted once per run, as the last of the run's `workflow_run.*` events.<br/>
        /// Example: {"type":"workflow_run.status_ended","id":"sevt_01JQ8ZC1V5B7N9M1K3J5H7GA","processed_at":"2026-10-01T18:05:02.337Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd","result":{"type":"completed"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? WorkflowRunStatusEnded { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? WorkflowRunStatusEnded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRunStatusEnded))]
#endif
        public bool IsWorkflowRunStatusEnded => WorkflowRunStatusEnded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRunStatusEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? value)
        {
            value = WorkflowRunStatusEnded;
            return IsWorkflowRunStatusEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent PickWorkflowRunStatusEnded() => WorkflowRunStatusEnded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRunStatusEnded' but the value was {ToString()}.");

        /// <summary>
        /// A workflow run's plan entered a phase.<br/>
        /// Example: {"type":"workflow_run.phase_started","id":"sevt_01JQ8Z7M3P5R7T9V1X3Z5B7D","processed_at":"2026-10-01T18:02:14.020Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd","workflow_run_phase_id":"wrph_011CZm4Kq7RtY2Wn8Vx3LbHd"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? WorkflowRunPhaseStarted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? WorkflowRunPhaseStarted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRunPhaseStarted))]
#endif
        public bool IsWorkflowRunPhaseStarted => WorkflowRunPhaseStarted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRunPhaseStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? value)
        {
            value = WorkflowRunPhaseStarted;
            return IsWorkflowRunPhaseStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent PickWorkflowRunPhaseStarted() => WorkflowRunPhaseStarted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRunPhaseStarted' but the value was {ToString()}.");

        /// <summary>
        /// A workflow run's plan left a phase, or the run's end closed it. Emitted once for every `workflow_run.phase_started` event, before the run's `workflow_run.status_ended` event. The event does not say whether the plan finished the phase's work, or why it left.<br/>
        /// Example: {"type":"workflow_run.phase_ended","id":"sevt_01JQ8ZB9W2Y4A6C8E1G2J4L6","processed_at":"2026-10-01T18:04:47.905Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd","workflow_run_phase_id":"wrph_011CZm4Kq7RtY2Wn8Vx3LbHd","phase_started_id":"sevt_01JQ8Z7M3P5R7T9V1X3Z5B7D"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? WorkflowRunPhaseEnded { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? WorkflowRunPhaseEnded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRunPhaseEnded))]
#endif
        public bool IsWorkflowRunPhaseEnded => WorkflowRunPhaseEnded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRunPhaseEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? value)
        {
            value = WorkflowRunPhaseEnded;
            return IsWorkflowRunPhaseEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent PickWorkflowRunPhaseEnded() => WorkflowRunPhaseEnded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRunPhaseEnded' but the value was {ToString()}.");

        /// <summary>
        /// A workflow run is running. Emitted when the run starts to execute, and each time it resumes after being idle. A run that starts idle emits `workflow_run.status_idle` first.<br/>
        /// Example: {"type":"workflow_run.status_running","id":"sevt_01JQ8Z6Y1M3P5R7T9V1X3Z5B","processed_at":"2026-10-01T18:02:11.430Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? WorkflowRunStatusRunning { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? WorkflowRunStatusRunning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRunStatusRunning))]
#endif
        public bool IsWorkflowRunStatusRunning => WorkflowRunStatusRunning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRunStatusRunning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? value)
        {
            value = WorkflowRunStatusRunning;
            return IsWorkflowRunStatusRunning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent PickWorkflowRunStatusRunning() => WorkflowRunStatusRunning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRunStatusRunning' but the value was {ToString()}.");

        /// <summary>
        /// A workflow run is idle. Emitted each time the run goes idle, whatever the cause. If the run ends while idle, no `workflow_run.status_running` comes between this event and its `workflow_run.status_ended`.<br/>
        /// Example: {"type":"workflow_run.status_idle","id":"sevt_01JQ8Z9A4C6E8G1J2L4N6Q8S","processed_at":"2026-10-01T18:03:20.118Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? WorkflowRunStatusIdle { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? WorkflowRunStatusIdle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRunStatusIdle))]
#endif
        public bool IsWorkflowRunStatusIdle => WorkflowRunStatusIdle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRunStatusIdle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? value)
        {
            value = WorkflowRunStatusIdle;
            return IsWorkflowRunStatusIdle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent PickWorkflowRunStatusIdle() => WorkflowRunStatusIdle is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRunStatusIdle' but the value was {ToString()}.");

        /// <summary>
        /// A workflow run met an error, or an error kept a run from being created. A run that ends with a `result.type` of `error` emits this event before its `workflow_run.status_ended`, with the same `error`.<br/>
        /// Example: {"type":"workflow_run.error","id":"sevt_01JQ8ZB7T3X5Z7C9E1G3J5L7","processed_at":"2026-10-01T18:05:02.301Z","workflow_run_id":"wrun_011CZm5tR2nHw6Jc9Ys4PdKf","error":{"type":"program_error","message":"The workflow run\u0027s plan failed."}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? WorkflowRunError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? WorkflowRunError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRunError))]
#endif
        public bool IsWorkflowRunError => WorkflowRunError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRunError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? value)
        {
            value = WorkflowRunError;
            return IsWorkflowRunError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent PickWorkflowRunError() => WorkflowRunError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRunError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserMessageEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsUserMessageEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserMessageEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.UserMessage;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserMessageEvent? value)
        {
            UserMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromUserMessage(global::Anthropic.BetaManagedAgentsUserMessageEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserInterruptEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsUserInterruptEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserInterruptEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.UserInterrupt;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserInterruptEvent? value)
        {
            UserInterrupt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromUserInterrupt(global::Anthropic.BetaManagedAgentsUserInterruptEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.UserToolConfirmation;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? value)
        {
            UserToolConfirmation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromUserToolConfirmation(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.UserCustomToolResult;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? value)
        {
            UserCustomToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromUserCustomToolResult(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentCustomToolUse;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? value)
        {
            AgentCustomToolUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentCustomToolUse(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentMessageEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentMessageEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentMessageEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentMessage;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentMessageEvent? value)
        {
            AgentMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentMessage(global::Anthropic.BetaManagedAgentsAgentMessageEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThinkingEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentThinkingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentThinkingEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentThinking;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThinkingEvent? value)
        {
            AgentThinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentThinking(global::Anthropic.BetaManagedAgentsAgentThinkingEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentMcpToolUse;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? value)
        {
            AgentMcpToolUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentMcpToolUse(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentMcpToolResult;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? value)
        {
            AgentMcpToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentMcpToolResult(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentToolUseEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentToolUseEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolUseEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentToolUse;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentToolUseEvent? value)
        {
            AgentToolUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentToolUse(global::Anthropic.BetaManagedAgentsAgentToolUseEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentToolResultEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentToolResultEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolResultEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentToolResult;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentToolResultEvent? value)
        {
            AgentToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentToolResult(global::Anthropic.BetaManagedAgentsAgentToolResultEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentThreadMessageReceived;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? value)
        {
            AgentThreadMessageReceived = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentThreadMessageReceived(global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentThreadMessageSent;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? value)
        {
            AgentThreadMessageSent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentThreadMessageSent(global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.AgentThreadContextCompacted;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? value)
        {
            AgentThreadContextCompacted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromAgentThreadContextCompacted(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionErrorEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionErrorEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionErrorEvent? value)
        {
            SessionError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionError(global::Anthropic.BetaManagedAgentsSessionErrorEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionStatusRescheduled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? value)
        {
            SessionStatusRescheduled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionStatusRescheduled(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionStatusRunning;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? value)
        {
            SessionStatusRunning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionStatusRunning(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionStatusIdle;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? value)
        {
            SessionStatusIdle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionStatusIdle(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionStatusTerminated;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? value)
        {
            SessionStatusTerminated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionStatusTerminated(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionThreadCreated;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? value)
        {
            SessionThreadCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionThreadCreated(global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SpanOutcomeEvaluationStart;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? value)
        {
            SpanOutcomeEvaluationStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSpanOutcomeEvaluationStart(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SpanOutcomeEvaluationEnd;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? value)
        {
            SpanOutcomeEvaluationEnd = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSpanOutcomeEvaluationEnd(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SpanModelRequestStart;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? value)
        {
            SpanModelRequestStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSpanModelRequestStart(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SpanModelRequestEnd;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? value)
        {
            SpanModelRequestEnd = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSpanModelRequestEnd(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SpanOutcomeEvaluationOngoing;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? value)
        {
            SpanOutcomeEvaluationOngoing = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSpanOutcomeEvaluationOngoing(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.UserDefineOutcome;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? value)
        {
            UserDefineOutcome = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromUserDefineOutcome(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionDeletedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionDeletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionDeletedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionDeleted;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionDeletedEvent? value)
        {
            SessionDeleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionDeleted(global::Anthropic.BetaManagedAgentsSessionDeletedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionThreadStatusRunning;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? value)
        {
            SessionThreadStatusRunning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionThreadStatusRunning(global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionThreadStatusIdle;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? value)
        {
            SessionThreadStatusIdle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionThreadStatusIdle(global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionThreadStatusTerminated;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? value)
        {
            SessionThreadStatusTerminated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionThreadStatusTerminated(global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserToolResultEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsUserToolResultEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserToolResultEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.UserToolResult;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsUserToolResultEvent? value)
        {
            UserToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromUserToolResult(global::Anthropic.BetaManagedAgentsUserToolResultEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionThreadStatusRescheduled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? value)
        {
            SessionThreadStatusRescheduled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionThreadStatusRescheduled(global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionUpdatedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionUpdatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionUpdatedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionUpdated;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionUpdated(global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsEventStartEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsEventStartEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEventStartEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.EventStart;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsEventStartEvent? value)
        {
            EventStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromEventStart(global::Anthropic.BetaManagedAgentsEventStartEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsEventDeltaEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsEventDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEventDeltaEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.EventDelta;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsEventDeltaEvent? value)
        {
            EventDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromEventDelta(global::Anthropic.BetaManagedAgentsEventDeltaEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSystemMessageEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSystemMessageEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSystemMessageEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SystemMessage;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSystemMessageEvent? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSystemMessage(global::Anthropic.BetaManagedAgentsSystemMessageEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionUsageEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsSessionUsageEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionUsageEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.SessionUsage;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsSessionUsageEvent? value)
        {
            SessionUsage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromSessionUsage(global::Anthropic.BetaManagedAgentsSessionUsageEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.WorkflowRunCreated;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? value)
        {
            WorkflowRunCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromWorkflowRunCreated(global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.WorkflowRunStatusEnded;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? value)
        {
            WorkflowRunStatusEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromWorkflowRunStatusEnded(global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.WorkflowRunPhaseStarted;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? value)
        {
            WorkflowRunPhaseStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromWorkflowRunPhaseStarted(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.WorkflowRunPhaseEnded;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? value)
        {
            WorkflowRunPhaseEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromWorkflowRunPhaseEnded(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.WorkflowRunStatusRunning;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? value)
        {
            WorkflowRunStatusRunning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromWorkflowRunStatusRunning(global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.WorkflowRunStatusIdle;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? value)
        {
            WorkflowRunStatusIdle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromWorkflowRunStatusIdle(global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent value) => new BetaManagedAgentsStreamSessionThreadEvents((global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent?(BetaManagedAgentsStreamSessionThreadEvents @this) => @this.WorkflowRunError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? value)
        {
            WorkflowRunError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEvents FromWorkflowRunError(global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? value) => new BetaManagedAgentsStreamSessionThreadEvents(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsStreamSessionThreadEvents(
            global::Anthropic.BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUserMessageEvent? userMessage,
            global::Anthropic.BetaManagedAgentsUserInterruptEvent? userInterrupt,
            global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? userToolConfirmation,
            global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? userCustomToolResult,
            global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? agentCustomToolUse,
            global::Anthropic.BetaManagedAgentsAgentMessageEvent? agentMessage,
            global::Anthropic.BetaManagedAgentsAgentThinkingEvent? agentThinking,
            global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? agentMcpToolUse,
            global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? agentMcpToolResult,
            global::Anthropic.BetaManagedAgentsAgentToolUseEvent? agentToolUse,
            global::Anthropic.BetaManagedAgentsAgentToolResultEvent? agentToolResult,
            global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent? agentThreadMessageReceived,
            global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent? agentThreadMessageSent,
            global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? agentThreadContextCompacted,
            global::Anthropic.BetaManagedAgentsSessionErrorEvent? sessionError,
            global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? sessionStatusRescheduled,
            global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? sessionStatusRunning,
            global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? sessionStatusIdle,
            global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? sessionStatusTerminated,
            global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent? sessionThreadCreated,
            global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent? spanOutcomeEvaluationStart,
            global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent? spanOutcomeEvaluationEnd,
            global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? spanModelRequestStart,
            global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? spanModelRequestEnd,
            global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent? spanOutcomeEvaluationOngoing,
            global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? userDefineOutcome,
            global::Anthropic.BetaManagedAgentsSessionDeletedEvent? sessionDeleted,
            global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent? sessionThreadStatusRunning,
            global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent? sessionThreadStatusIdle,
            global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent? sessionThreadStatusTerminated,
            global::Anthropic.BetaManagedAgentsUserToolResultEvent? userToolResult,
            global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent? sessionThreadStatusRescheduled,
            global::Anthropic.BetaManagedAgentsSessionUpdatedEvent? sessionUpdated,
            global::Anthropic.BetaManagedAgentsEventStartEvent? eventStart,
            global::Anthropic.BetaManagedAgentsEventDeltaEvent? eventDelta,
            global::Anthropic.BetaManagedAgentsSystemMessageEvent? systemMessage,
            global::Anthropic.BetaManagedAgentsSessionUsageEvent? sessionUsage,
            global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent? workflowRunCreated,
            global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent? workflowRunStatusEnded,
            global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent? workflowRunPhaseStarted,
            global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent? workflowRunPhaseEnded,
            global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent? workflowRunStatusRunning,
            global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent? workflowRunStatusIdle,
            global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent? workflowRunError
            )
        {
            Type = type;

            UserMessage = userMessage;
            UserInterrupt = userInterrupt;
            UserToolConfirmation = userToolConfirmation;
            UserCustomToolResult = userCustomToolResult;
            AgentCustomToolUse = agentCustomToolUse;
            AgentMessage = agentMessage;
            AgentThinking = agentThinking;
            AgentMcpToolUse = agentMcpToolUse;
            AgentMcpToolResult = agentMcpToolResult;
            AgentToolUse = agentToolUse;
            AgentToolResult = agentToolResult;
            AgentThreadMessageReceived = agentThreadMessageReceived;
            AgentThreadMessageSent = agentThreadMessageSent;
            AgentThreadContextCompacted = agentThreadContextCompacted;
            SessionError = sessionError;
            SessionStatusRescheduled = sessionStatusRescheduled;
            SessionStatusRunning = sessionStatusRunning;
            SessionStatusIdle = sessionStatusIdle;
            SessionStatusTerminated = sessionStatusTerminated;
            SessionThreadCreated = sessionThreadCreated;
            SpanOutcomeEvaluationStart = spanOutcomeEvaluationStart;
            SpanOutcomeEvaluationEnd = spanOutcomeEvaluationEnd;
            SpanModelRequestStart = spanModelRequestStart;
            SpanModelRequestEnd = spanModelRequestEnd;
            SpanOutcomeEvaluationOngoing = spanOutcomeEvaluationOngoing;
            UserDefineOutcome = userDefineOutcome;
            SessionDeleted = sessionDeleted;
            SessionThreadStatusRunning = sessionThreadStatusRunning;
            SessionThreadStatusIdle = sessionThreadStatusIdle;
            SessionThreadStatusTerminated = sessionThreadStatusTerminated;
            UserToolResult = userToolResult;
            SessionThreadStatusRescheduled = sessionThreadStatusRescheduled;
            SessionUpdated = sessionUpdated;
            EventStart = eventStart;
            EventDelta = eventDelta;
            SystemMessage = systemMessage;
            SessionUsage = sessionUsage;
            WorkflowRunCreated = workflowRunCreated;
            WorkflowRunStatusEnded = workflowRunStatusEnded;
            WorkflowRunPhaseStarted = workflowRunPhaseStarted;
            WorkflowRunPhaseEnded = workflowRunPhaseEnded;
            WorkflowRunStatusRunning = workflowRunStatusRunning;
            WorkflowRunStatusIdle = workflowRunStatusIdle;
            WorkflowRunError = workflowRunError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WorkflowRunError as object ??
            WorkflowRunStatusIdle as object ??
            WorkflowRunStatusRunning as object ??
            WorkflowRunPhaseEnded as object ??
            WorkflowRunPhaseStarted as object ??
            WorkflowRunStatusEnded as object ??
            WorkflowRunCreated as object ??
            SessionUsage as object ??
            SystemMessage as object ??
            EventDelta as object ??
            EventStart as object ??
            SessionUpdated as object ??
            SessionThreadStatusRescheduled as object ??
            UserToolResult as object ??
            SessionThreadStatusTerminated as object ??
            SessionThreadStatusIdle as object ??
            SessionThreadStatusRunning as object ??
            SessionDeleted as object ??
            UserDefineOutcome as object ??
            SpanOutcomeEvaluationOngoing as object ??
            SpanModelRequestEnd as object ??
            SpanModelRequestStart as object ??
            SpanOutcomeEvaluationEnd as object ??
            SpanOutcomeEvaluationStart as object ??
            SessionThreadCreated as object ??
            SessionStatusTerminated as object ??
            SessionStatusIdle as object ??
            SessionStatusRunning as object ??
            SessionStatusRescheduled as object ??
            SessionError as object ??
            AgentThreadContextCompacted as object ??
            AgentThreadMessageSent as object ??
            AgentThreadMessageReceived as object ??
            AgentToolResult as object ??
            AgentToolUse as object ??
            AgentMcpToolResult as object ??
            AgentMcpToolUse as object ??
            AgentThinking as object ??
            AgentMessage as object ??
            AgentCustomToolUse as object ??
            UserCustomToolResult as object ??
            UserToolConfirmation as object ??
            UserInterrupt as object ??
            UserMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserMessage?.ToString() ??
            UserInterrupt?.ToString() ??
            UserToolConfirmation?.ToString() ??
            UserCustomToolResult?.ToString() ??
            AgentCustomToolUse?.ToString() ??
            AgentMessage?.ToString() ??
            AgentThinking?.ToString() ??
            AgentMcpToolUse?.ToString() ??
            AgentMcpToolResult?.ToString() ??
            AgentToolUse?.ToString() ??
            AgentToolResult?.ToString() ??
            AgentThreadMessageReceived?.ToString() ??
            AgentThreadMessageSent?.ToString() ??
            AgentThreadContextCompacted?.ToString() ??
            SessionError?.ToString() ??
            SessionStatusRescheduled?.ToString() ??
            SessionStatusRunning?.ToString() ??
            SessionStatusIdle?.ToString() ??
            SessionStatusTerminated?.ToString() ??
            SessionThreadCreated?.ToString() ??
            SpanOutcomeEvaluationStart?.ToString() ??
            SpanOutcomeEvaluationEnd?.ToString() ??
            SpanModelRequestStart?.ToString() ??
            SpanModelRequestEnd?.ToString() ??
            SpanOutcomeEvaluationOngoing?.ToString() ??
            UserDefineOutcome?.ToString() ??
            SessionDeleted?.ToString() ??
            SessionThreadStatusRunning?.ToString() ??
            SessionThreadStatusIdle?.ToString() ??
            SessionThreadStatusTerminated?.ToString() ??
            UserToolResult?.ToString() ??
            SessionThreadStatusRescheduled?.ToString() ??
            SessionUpdated?.ToString() ??
            EventStart?.ToString() ??
            EventDelta?.ToString() ??
            SystemMessage?.ToString() ??
            SessionUsage?.ToString() ??
            WorkflowRunCreated?.ToString() ??
            WorkflowRunStatusEnded?.ToString() ??
            WorkflowRunPhaseStarted?.ToString() ??
            WorkflowRunPhaseEnded?.ToString() ??
            WorkflowRunStatusRunning?.ToString() ??
            WorkflowRunStatusIdle?.ToString() ??
            WorkflowRunError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && IsWorkflowRunStatusIdle && !IsWorkflowRunError || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage && !IsSessionUsage && !IsWorkflowRunCreated && !IsWorkflowRunStatusEnded && !IsWorkflowRunPhaseStarted && !IsWorkflowRunPhaseEnded && !IsWorkflowRunStatusRunning && !IsWorkflowRunStatusIdle && IsWorkflowRunError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUserMessageEvent, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserInterruptEvent, TResult>? userInterrupt = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent, TResult>? userToolConfirmation = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent, TResult>? userCustomToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent, TResult>? agentCustomToolUse = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentMessageEvent, TResult>? agentMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentThinkingEvent, TResult>? agentThinking = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent, TResult>? agentMcpToolUse = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent, TResult>? agentMcpToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolUseEvent, TResult>? agentToolUse = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolResultEvent, TResult>? agentToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent, TResult>? agentThreadMessageReceived = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent, TResult>? agentThreadMessageSent = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent, TResult>? agentThreadContextCompacted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionErrorEvent, TResult>? sessionError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent, TResult>? sessionStatusRescheduled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent, TResult>? sessionStatusRunning = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent, TResult>? sessionStatusIdle = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent, TResult>? sessionStatusTerminated = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent, TResult>? sessionThreadCreated = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent, TResult>? spanOutcomeEvaluationStart = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent, TResult>? spanOutcomeEvaluationEnd = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent, TResult>? spanModelRequestStart = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent, TResult>? spanModelRequestEnd = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent, TResult>? spanOutcomeEvaluationOngoing = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent, TResult>? userDefineOutcome = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionDeletedEvent, TResult>? sessionDeleted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent, TResult>? sessionThreadStatusRunning = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent, TResult>? sessionThreadStatusIdle = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent, TResult>? sessionThreadStatusTerminated = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserToolResultEvent, TResult>? userToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent, TResult>? sessionThreadStatusRescheduled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionUpdatedEvent, TResult>? sessionUpdated = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEventStartEvent, TResult>? eventStart = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEventDeltaEvent, TResult>? eventDelta = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSystemMessageEvent, TResult>? systemMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionUsageEvent, TResult>? sessionUsage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent, TResult>? workflowRunCreated = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent, TResult>? workflowRunStatusEnded = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent, TResult>? workflowRunPhaseStarted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent, TResult>? workflowRunPhaseEnded = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent, TResult>? workflowRunStatusRunning = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent, TResult>? workflowRunStatusIdle = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent, TResult>? workflowRunError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserMessage is { } __value0 && userMessage != null)
            {
                return userMessage(__value0);
            }
            else if (UserInterrupt is { } __value1 && userInterrupt != null)
            {
                return userInterrupt(__value1);
            }
            else if (UserToolConfirmation is { } __value2 && userToolConfirmation != null)
            {
                return userToolConfirmation(__value2);
            }
            else if (UserCustomToolResult is { } __value3 && userCustomToolResult != null)
            {
                return userCustomToolResult(__value3);
            }
            else if (AgentCustomToolUse is { } __value4 && agentCustomToolUse != null)
            {
                return agentCustomToolUse(__value4);
            }
            else if (AgentMessage is { } __value5 && agentMessage != null)
            {
                return agentMessage(__value5);
            }
            else if (AgentThinking is { } __value6 && agentThinking != null)
            {
                return agentThinking(__value6);
            }
            else if (AgentMcpToolUse is { } __value7 && agentMcpToolUse != null)
            {
                return agentMcpToolUse(__value7);
            }
            else if (AgentMcpToolResult is { } __value8 && agentMcpToolResult != null)
            {
                return agentMcpToolResult(__value8);
            }
            else if (AgentToolUse is { } __value9 && agentToolUse != null)
            {
                return agentToolUse(__value9);
            }
            else if (AgentToolResult is { } __value10 && agentToolResult != null)
            {
                return agentToolResult(__value10);
            }
            else if (AgentThreadMessageReceived is { } __value11 && agentThreadMessageReceived != null)
            {
                return agentThreadMessageReceived(__value11);
            }
            else if (AgentThreadMessageSent is { } __value12 && agentThreadMessageSent != null)
            {
                return agentThreadMessageSent(__value12);
            }
            else if (AgentThreadContextCompacted is { } __value13 && agentThreadContextCompacted != null)
            {
                return agentThreadContextCompacted(__value13);
            }
            else if (SessionError is { } __value14 && sessionError != null)
            {
                return sessionError(__value14);
            }
            else if (SessionStatusRescheduled is { } __value15 && sessionStatusRescheduled != null)
            {
                return sessionStatusRescheduled(__value15);
            }
            else if (SessionStatusRunning is { } __value16 && sessionStatusRunning != null)
            {
                return sessionStatusRunning(__value16);
            }
            else if (SessionStatusIdle is { } __value17 && sessionStatusIdle != null)
            {
                return sessionStatusIdle(__value17);
            }
            else if (SessionStatusTerminated is { } __value18 && sessionStatusTerminated != null)
            {
                return sessionStatusTerminated(__value18);
            }
            else if (SessionThreadCreated is { } __value19 && sessionThreadCreated != null)
            {
                return sessionThreadCreated(__value19);
            }
            else if (SpanOutcomeEvaluationStart is { } __value20 && spanOutcomeEvaluationStart != null)
            {
                return spanOutcomeEvaluationStart(__value20);
            }
            else if (SpanOutcomeEvaluationEnd is { } __value21 && spanOutcomeEvaluationEnd != null)
            {
                return spanOutcomeEvaluationEnd(__value21);
            }
            else if (SpanModelRequestStart is { } __value22 && spanModelRequestStart != null)
            {
                return spanModelRequestStart(__value22);
            }
            else if (SpanModelRequestEnd is { } __value23 && spanModelRequestEnd != null)
            {
                return spanModelRequestEnd(__value23);
            }
            else if (SpanOutcomeEvaluationOngoing is { } __value24 && spanOutcomeEvaluationOngoing != null)
            {
                return spanOutcomeEvaluationOngoing(__value24);
            }
            else if (UserDefineOutcome is { } __value25 && userDefineOutcome != null)
            {
                return userDefineOutcome(__value25);
            }
            else if (SessionDeleted is { } __value26 && sessionDeleted != null)
            {
                return sessionDeleted(__value26);
            }
            else if (SessionThreadStatusRunning is { } __value27 && sessionThreadStatusRunning != null)
            {
                return sessionThreadStatusRunning(__value27);
            }
            else if (SessionThreadStatusIdle is { } __value28 && sessionThreadStatusIdle != null)
            {
                return sessionThreadStatusIdle(__value28);
            }
            else if (SessionThreadStatusTerminated is { } __value29 && sessionThreadStatusTerminated != null)
            {
                return sessionThreadStatusTerminated(__value29);
            }
            else if (UserToolResult is { } __value30 && userToolResult != null)
            {
                return userToolResult(__value30);
            }
            else if (SessionThreadStatusRescheduled is { } __value31 && sessionThreadStatusRescheduled != null)
            {
                return sessionThreadStatusRescheduled(__value31);
            }
            else if (SessionUpdated is { } __value32 && sessionUpdated != null)
            {
                return sessionUpdated(__value32);
            }
            else if (EventStart is { } __value33 && eventStart != null)
            {
                return eventStart(__value33);
            }
            else if (EventDelta is { } __value34 && eventDelta != null)
            {
                return eventDelta(__value34);
            }
            else if (SystemMessage is { } __value35 && systemMessage != null)
            {
                return systemMessage(__value35);
            }
            else if (SessionUsage is { } __value36 && sessionUsage != null)
            {
                return sessionUsage(__value36);
            }
            else if (WorkflowRunCreated is { } __value37 && workflowRunCreated != null)
            {
                return workflowRunCreated(__value37);
            }
            else if (WorkflowRunStatusEnded is { } __value38 && workflowRunStatusEnded != null)
            {
                return workflowRunStatusEnded(__value38);
            }
            else if (WorkflowRunPhaseStarted is { } __value39 && workflowRunPhaseStarted != null)
            {
                return workflowRunPhaseStarted(__value39);
            }
            else if (WorkflowRunPhaseEnded is { } __value40 && workflowRunPhaseEnded != null)
            {
                return workflowRunPhaseEnded(__value40);
            }
            else if (WorkflowRunStatusRunning is { } __value41 && workflowRunStatusRunning != null)
            {
                return workflowRunStatusRunning(__value41);
            }
            else if (WorkflowRunStatusIdle is { } __value42 && workflowRunStatusIdle != null)
            {
                return workflowRunStatusIdle(__value42);
            }
            else if (WorkflowRunError is { } __value43 && workflowRunError != null)
            {
                return workflowRunError(__value43);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEvent>? userMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEvent>? userInterrupt = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent>? userToolConfirmation = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent>? userCustomToolResult = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent>? agentCustomToolUse = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMessageEvent>? agentMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThinkingEvent>? agentThinking = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent>? agentMcpToolUse = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent>? agentMcpToolResult = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolUseEvent>? agentToolUse = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolResultEvent>? agentToolResult = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent>? agentThreadMessageReceived = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent>? agentThreadMessageSent = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent>? agentThreadContextCompacted = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionErrorEvent>? sessionError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent>? sessionStatusRescheduled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent>? sessionStatusRunning = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent>? sessionStatusIdle = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent>? sessionStatusTerminated = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent>? sessionThreadCreated = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent>? spanOutcomeEvaluationStart = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent>? spanOutcomeEvaluationEnd = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent>? spanModelRequestStart = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent>? spanModelRequestEnd = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent>? spanOutcomeEvaluationOngoing = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent>? userDefineOutcome = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionDeletedEvent>? sessionDeleted = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent>? sessionThreadStatusRunning = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent>? sessionThreadStatusIdle = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent>? sessionThreadStatusTerminated = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolResultEvent>? userToolResult = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent>? sessionThreadStatusRescheduled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionUpdatedEvent>? sessionUpdated = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEventStartEvent>? eventStart = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEventDeltaEvent>? eventDelta = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSystemMessageEvent>? systemMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionUsageEvent>? sessionUsage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent>? workflowRunCreated = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent>? workflowRunStatusEnded = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent>? workflowRunPhaseStarted = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent>? workflowRunPhaseEnded = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent>? workflowRunStatusRunning = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent>? workflowRunStatusIdle = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent>? workflowRunError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserMessage is { } __value0)
            {
                userMessage?.Invoke(__value0);
            }
            else if (UserInterrupt is { } __value1)
            {
                userInterrupt?.Invoke(__value1);
            }
            else if (UserToolConfirmation is { } __value2)
            {
                userToolConfirmation?.Invoke(__value2);
            }
            else if (UserCustomToolResult is { } __value3)
            {
                userCustomToolResult?.Invoke(__value3);
            }
            else if (AgentCustomToolUse is { } __value4)
            {
                agentCustomToolUse?.Invoke(__value4);
            }
            else if (AgentMessage is { } __value5)
            {
                agentMessage?.Invoke(__value5);
            }
            else if (AgentThinking is { } __value6)
            {
                agentThinking?.Invoke(__value6);
            }
            else if (AgentMcpToolUse is { } __value7)
            {
                agentMcpToolUse?.Invoke(__value7);
            }
            else if (AgentMcpToolResult is { } __value8)
            {
                agentMcpToolResult?.Invoke(__value8);
            }
            else if (AgentToolUse is { } __value9)
            {
                agentToolUse?.Invoke(__value9);
            }
            else if (AgentToolResult is { } __value10)
            {
                agentToolResult?.Invoke(__value10);
            }
            else if (AgentThreadMessageReceived is { } __value11)
            {
                agentThreadMessageReceived?.Invoke(__value11);
            }
            else if (AgentThreadMessageSent is { } __value12)
            {
                agentThreadMessageSent?.Invoke(__value12);
            }
            else if (AgentThreadContextCompacted is { } __value13)
            {
                agentThreadContextCompacted?.Invoke(__value13);
            }
            else if (SessionError is { } __value14)
            {
                sessionError?.Invoke(__value14);
            }
            else if (SessionStatusRescheduled is { } __value15)
            {
                sessionStatusRescheduled?.Invoke(__value15);
            }
            else if (SessionStatusRunning is { } __value16)
            {
                sessionStatusRunning?.Invoke(__value16);
            }
            else if (SessionStatusIdle is { } __value17)
            {
                sessionStatusIdle?.Invoke(__value17);
            }
            else if (SessionStatusTerminated is { } __value18)
            {
                sessionStatusTerminated?.Invoke(__value18);
            }
            else if (SessionThreadCreated is { } __value19)
            {
                sessionThreadCreated?.Invoke(__value19);
            }
            else if (SpanOutcomeEvaluationStart is { } __value20)
            {
                spanOutcomeEvaluationStart?.Invoke(__value20);
            }
            else if (SpanOutcomeEvaluationEnd is { } __value21)
            {
                spanOutcomeEvaluationEnd?.Invoke(__value21);
            }
            else if (SpanModelRequestStart is { } __value22)
            {
                spanModelRequestStart?.Invoke(__value22);
            }
            else if (SpanModelRequestEnd is { } __value23)
            {
                spanModelRequestEnd?.Invoke(__value23);
            }
            else if (SpanOutcomeEvaluationOngoing is { } __value24)
            {
                spanOutcomeEvaluationOngoing?.Invoke(__value24);
            }
            else if (UserDefineOutcome is { } __value25)
            {
                userDefineOutcome?.Invoke(__value25);
            }
            else if (SessionDeleted is { } __value26)
            {
                sessionDeleted?.Invoke(__value26);
            }
            else if (SessionThreadStatusRunning is { } __value27)
            {
                sessionThreadStatusRunning?.Invoke(__value27);
            }
            else if (SessionThreadStatusIdle is { } __value28)
            {
                sessionThreadStatusIdle?.Invoke(__value28);
            }
            else if (SessionThreadStatusTerminated is { } __value29)
            {
                sessionThreadStatusTerminated?.Invoke(__value29);
            }
            else if (UserToolResult is { } __value30)
            {
                userToolResult?.Invoke(__value30);
            }
            else if (SessionThreadStatusRescheduled is { } __value31)
            {
                sessionThreadStatusRescheduled?.Invoke(__value31);
            }
            else if (SessionUpdated is { } __value32)
            {
                sessionUpdated?.Invoke(__value32);
            }
            else if (EventStart is { } __value33)
            {
                eventStart?.Invoke(__value33);
            }
            else if (EventDelta is { } __value34)
            {
                eventDelta?.Invoke(__value34);
            }
            else if (SystemMessage is { } __value35)
            {
                systemMessage?.Invoke(__value35);
            }
            else if (SessionUsage is { } __value36)
            {
                sessionUsage?.Invoke(__value36);
            }
            else if (WorkflowRunCreated is { } __value37)
            {
                workflowRunCreated?.Invoke(__value37);
            }
            else if (WorkflowRunStatusEnded is { } __value38)
            {
                workflowRunStatusEnded?.Invoke(__value38);
            }
            else if (WorkflowRunPhaseStarted is { } __value39)
            {
                workflowRunPhaseStarted?.Invoke(__value39);
            }
            else if (WorkflowRunPhaseEnded is { } __value40)
            {
                workflowRunPhaseEnded?.Invoke(__value40);
            }
            else if (WorkflowRunStatusRunning is { } __value41)
            {
                workflowRunStatusRunning?.Invoke(__value41);
            }
            else if (WorkflowRunStatusIdle is { } __value42)
            {
                workflowRunStatusIdle?.Invoke(__value42);
            }
            else if (WorkflowRunError is { } __value43)
            {
                workflowRunError?.Invoke(__value43);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEvent>? userMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEvent>? userInterrupt = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent>? userToolConfirmation = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent>? userCustomToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent>? agentCustomToolUse = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMessageEvent>? agentMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThinkingEvent>? agentThinking = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent>? agentMcpToolUse = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent>? agentMcpToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolUseEvent>? agentToolUse = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolResultEvent>? agentToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent>? agentThreadMessageReceived = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent>? agentThreadMessageSent = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent>? agentThreadContextCompacted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionErrorEvent>? sessionError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent>? sessionStatusRescheduled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent>? sessionStatusRunning = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent>? sessionStatusIdle = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent>? sessionStatusTerminated = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent>? sessionThreadCreated = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent>? spanOutcomeEvaluationStart = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent>? spanOutcomeEvaluationEnd = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent>? spanModelRequestStart = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent>? spanModelRequestEnd = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent>? spanOutcomeEvaluationOngoing = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent>? userDefineOutcome = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionDeletedEvent>? sessionDeleted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent>? sessionThreadStatusRunning = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent>? sessionThreadStatusIdle = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent>? sessionThreadStatusTerminated = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolResultEvent>? userToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent>? sessionThreadStatusRescheduled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionUpdatedEvent>? sessionUpdated = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEventStartEvent>? eventStart = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEventDeltaEvent>? eventDelta = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSystemMessageEvent>? systemMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionUsageEvent>? sessionUsage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent>? workflowRunCreated = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent>? workflowRunStatusEnded = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent>? workflowRunPhaseStarted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent>? workflowRunPhaseEnded = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent>? workflowRunStatusRunning = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent>? workflowRunStatusIdle = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent>? workflowRunError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserMessage is { } __value0)
            {
                userMessage?.Invoke(__value0);
            }
            else if (UserInterrupt is { } __value1)
            {
                userInterrupt?.Invoke(__value1);
            }
            else if (UserToolConfirmation is { } __value2)
            {
                userToolConfirmation?.Invoke(__value2);
            }
            else if (UserCustomToolResult is { } __value3)
            {
                userCustomToolResult?.Invoke(__value3);
            }
            else if (AgentCustomToolUse is { } __value4)
            {
                agentCustomToolUse?.Invoke(__value4);
            }
            else if (AgentMessage is { } __value5)
            {
                agentMessage?.Invoke(__value5);
            }
            else if (AgentThinking is { } __value6)
            {
                agentThinking?.Invoke(__value6);
            }
            else if (AgentMcpToolUse is { } __value7)
            {
                agentMcpToolUse?.Invoke(__value7);
            }
            else if (AgentMcpToolResult is { } __value8)
            {
                agentMcpToolResult?.Invoke(__value8);
            }
            else if (AgentToolUse is { } __value9)
            {
                agentToolUse?.Invoke(__value9);
            }
            else if (AgentToolResult is { } __value10)
            {
                agentToolResult?.Invoke(__value10);
            }
            else if (AgentThreadMessageReceived is { } __value11)
            {
                agentThreadMessageReceived?.Invoke(__value11);
            }
            else if (AgentThreadMessageSent is { } __value12)
            {
                agentThreadMessageSent?.Invoke(__value12);
            }
            else if (AgentThreadContextCompacted is { } __value13)
            {
                agentThreadContextCompacted?.Invoke(__value13);
            }
            else if (SessionError is { } __value14)
            {
                sessionError?.Invoke(__value14);
            }
            else if (SessionStatusRescheduled is { } __value15)
            {
                sessionStatusRescheduled?.Invoke(__value15);
            }
            else if (SessionStatusRunning is { } __value16)
            {
                sessionStatusRunning?.Invoke(__value16);
            }
            else if (SessionStatusIdle is { } __value17)
            {
                sessionStatusIdle?.Invoke(__value17);
            }
            else if (SessionStatusTerminated is { } __value18)
            {
                sessionStatusTerminated?.Invoke(__value18);
            }
            else if (SessionThreadCreated is { } __value19)
            {
                sessionThreadCreated?.Invoke(__value19);
            }
            else if (SpanOutcomeEvaluationStart is { } __value20)
            {
                spanOutcomeEvaluationStart?.Invoke(__value20);
            }
            else if (SpanOutcomeEvaluationEnd is { } __value21)
            {
                spanOutcomeEvaluationEnd?.Invoke(__value21);
            }
            else if (SpanModelRequestStart is { } __value22)
            {
                spanModelRequestStart?.Invoke(__value22);
            }
            else if (SpanModelRequestEnd is { } __value23)
            {
                spanModelRequestEnd?.Invoke(__value23);
            }
            else if (SpanOutcomeEvaluationOngoing is { } __value24)
            {
                spanOutcomeEvaluationOngoing?.Invoke(__value24);
            }
            else if (UserDefineOutcome is { } __value25)
            {
                userDefineOutcome?.Invoke(__value25);
            }
            else if (SessionDeleted is { } __value26)
            {
                sessionDeleted?.Invoke(__value26);
            }
            else if (SessionThreadStatusRunning is { } __value27)
            {
                sessionThreadStatusRunning?.Invoke(__value27);
            }
            else if (SessionThreadStatusIdle is { } __value28)
            {
                sessionThreadStatusIdle?.Invoke(__value28);
            }
            else if (SessionThreadStatusTerminated is { } __value29)
            {
                sessionThreadStatusTerminated?.Invoke(__value29);
            }
            else if (UserToolResult is { } __value30)
            {
                userToolResult?.Invoke(__value30);
            }
            else if (SessionThreadStatusRescheduled is { } __value31)
            {
                sessionThreadStatusRescheduled?.Invoke(__value31);
            }
            else if (SessionUpdated is { } __value32)
            {
                sessionUpdated?.Invoke(__value32);
            }
            else if (EventStart is { } __value33)
            {
                eventStart?.Invoke(__value33);
            }
            else if (EventDelta is { } __value34)
            {
                eventDelta?.Invoke(__value34);
            }
            else if (SystemMessage is { } __value35)
            {
                systemMessage?.Invoke(__value35);
            }
            else if (SessionUsage is { } __value36)
            {
                sessionUsage?.Invoke(__value36);
            }
            else if (WorkflowRunCreated is { } __value37)
            {
                workflowRunCreated?.Invoke(__value37);
            }
            else if (WorkflowRunStatusEnded is { } __value38)
            {
                workflowRunStatusEnded?.Invoke(__value38);
            }
            else if (WorkflowRunPhaseStarted is { } __value39)
            {
                workflowRunPhaseStarted?.Invoke(__value39);
            }
            else if (WorkflowRunPhaseEnded is { } __value40)
            {
                workflowRunPhaseEnded?.Invoke(__value40);
            }
            else if (WorkflowRunStatusRunning is { } __value41)
            {
                workflowRunStatusRunning?.Invoke(__value41);
            }
            else if (WorkflowRunStatusIdle is { } __value42)
            {
                workflowRunStatusIdle?.Invoke(__value42);
            }
            else if (WorkflowRunError is { } __value43)
            {
                workflowRunError?.Invoke(__value43);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserMessage,
                typeof(global::Anthropic.BetaManagedAgentsUserMessageEvent),
                UserInterrupt,
                typeof(global::Anthropic.BetaManagedAgentsUserInterruptEvent),
                UserToolConfirmation,
                typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent),
                UserCustomToolResult,
                typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent),
                AgentCustomToolUse,
                typeof(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent),
                AgentMessage,
                typeof(global::Anthropic.BetaManagedAgentsAgentMessageEvent),
                AgentThinking,
                typeof(global::Anthropic.BetaManagedAgentsAgentThinkingEvent),
                AgentMcpToolUse,
                typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent),
                AgentMcpToolResult,
                typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent),
                AgentToolUse,
                typeof(global::Anthropic.BetaManagedAgentsAgentToolUseEvent),
                AgentToolResult,
                typeof(global::Anthropic.BetaManagedAgentsAgentToolResultEvent),
                AgentThreadMessageReceived,
                typeof(global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent),
                AgentThreadMessageSent,
                typeof(global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent),
                AgentThreadContextCompacted,
                typeof(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent),
                SessionError,
                typeof(global::Anthropic.BetaManagedAgentsSessionErrorEvent),
                SessionStatusRescheduled,
                typeof(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent),
                SessionStatusRunning,
                typeof(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent),
                SessionStatusIdle,
                typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent),
                SessionStatusTerminated,
                typeof(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent),
                SessionThreadCreated,
                typeof(global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent),
                SpanOutcomeEvaluationStart,
                typeof(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent),
                SpanOutcomeEvaluationEnd,
                typeof(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent),
                SpanModelRequestStart,
                typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent),
                SpanModelRequestEnd,
                typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent),
                SpanOutcomeEvaluationOngoing,
                typeof(global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent),
                UserDefineOutcome,
                typeof(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent),
                SessionDeleted,
                typeof(global::Anthropic.BetaManagedAgentsSessionDeletedEvent),
                SessionThreadStatusRunning,
                typeof(global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent),
                SessionThreadStatusIdle,
                typeof(global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent),
                SessionThreadStatusTerminated,
                typeof(global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent),
                UserToolResult,
                typeof(global::Anthropic.BetaManagedAgentsUserToolResultEvent),
                SessionThreadStatusRescheduled,
                typeof(global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent),
                SessionUpdated,
                typeof(global::Anthropic.BetaManagedAgentsSessionUpdatedEvent),
                EventStart,
                typeof(global::Anthropic.BetaManagedAgentsEventStartEvent),
                EventDelta,
                typeof(global::Anthropic.BetaManagedAgentsEventDeltaEvent),
                SystemMessage,
                typeof(global::Anthropic.BetaManagedAgentsSystemMessageEvent),
                SessionUsage,
                typeof(global::Anthropic.BetaManagedAgentsSessionUsageEvent),
                WorkflowRunCreated,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent),
                WorkflowRunStatusEnded,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent),
                WorkflowRunPhaseStarted,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent),
                WorkflowRunPhaseEnded,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent),
                WorkflowRunStatusRunning,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent),
                WorkflowRunStatusIdle,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent),
                WorkflowRunError,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BetaManagedAgentsStreamSessionThreadEvents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserMessageEvent?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserInterruptEvent?>.Default.Equals(UserInterrupt, other.UserInterrupt) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?>.Default.Equals(UserToolConfirmation, other.UserToolConfirmation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?>.Default.Equals(UserCustomToolResult, other.UserCustomToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?>.Default.Equals(AgentCustomToolUse, other.AgentCustomToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentMessageEvent?>.Default.Equals(AgentMessage, other.AgentMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentThinkingEvent?>.Default.Equals(AgentThinking, other.AgentThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?>.Default.Equals(AgentMcpToolUse, other.AgentMcpToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?>.Default.Equals(AgentMcpToolResult, other.AgentMcpToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentToolUseEvent?>.Default.Equals(AgentToolUse, other.AgentToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentToolResultEvent?>.Default.Equals(AgentToolResult, other.AgentToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent?>.Default.Equals(AgentThreadMessageReceived, other.AgentThreadMessageReceived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent?>.Default.Equals(AgentThreadMessageSent, other.AgentThreadMessageSent) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?>.Default.Equals(AgentThreadContextCompacted, other.AgentThreadContextCompacted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionErrorEvent?>.Default.Equals(SessionError, other.SessionError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?>.Default.Equals(SessionStatusRescheduled, other.SessionStatusRescheduled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?>.Default.Equals(SessionStatusRunning, other.SessionStatusRunning) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?>.Default.Equals(SessionStatusIdle, other.SessionStatusIdle) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?>.Default.Equals(SessionStatusTerminated, other.SessionStatusTerminated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent?>.Default.Equals(SessionThreadCreated, other.SessionThreadCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent?>.Default.Equals(SpanOutcomeEvaluationStart, other.SpanOutcomeEvaluationStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent?>.Default.Equals(SpanOutcomeEvaluationEnd, other.SpanOutcomeEvaluationEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?>.Default.Equals(SpanModelRequestStart, other.SpanModelRequestStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?>.Default.Equals(SpanModelRequestEnd, other.SpanModelRequestEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent?>.Default.Equals(SpanOutcomeEvaluationOngoing, other.SpanOutcomeEvaluationOngoing) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent?>.Default.Equals(UserDefineOutcome, other.UserDefineOutcome) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionDeletedEvent?>.Default.Equals(SessionDeleted, other.SessionDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent?>.Default.Equals(SessionThreadStatusRunning, other.SessionThreadStatusRunning) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent?>.Default.Equals(SessionThreadStatusIdle, other.SessionThreadStatusIdle) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent?>.Default.Equals(SessionThreadStatusTerminated, other.SessionThreadStatusTerminated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserToolResultEvent?>.Default.Equals(UserToolResult, other.UserToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent?>.Default.Equals(SessionThreadStatusRescheduled, other.SessionThreadStatusRescheduled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionUpdatedEvent?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEventStartEvent?>.Default.Equals(EventStart, other.EventStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEventDeltaEvent?>.Default.Equals(EventDelta, other.EventDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSystemMessageEvent?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionUsageEvent?>.Default.Equals(SessionUsage, other.SessionUsage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunCreatedEvent?>.Default.Equals(WorkflowRunCreated, other.WorkflowRunCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunStatusEndedEvent?>.Default.Equals(WorkflowRunStatusEnded, other.WorkflowRunStatusEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseStartedEvent?>.Default.Equals(WorkflowRunPhaseStarted, other.WorkflowRunPhaseStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunPhaseEndedEvent?>.Default.Equals(WorkflowRunPhaseEnded, other.WorkflowRunPhaseEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunStatusRunningEvent?>.Default.Equals(WorkflowRunStatusRunning, other.WorkflowRunStatusRunning) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunStatusIdleEvent?>.Default.Equals(WorkflowRunStatusIdle, other.WorkflowRunStatusIdle) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunErrorEvent?>.Default.Equals(WorkflowRunError, other.WorkflowRunError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsStreamSessionThreadEvents obj1, BetaManagedAgentsStreamSessionThreadEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsStreamSessionThreadEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsStreamSessionThreadEvents obj1, BetaManagedAgentsStreamSessionThreadEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsStreamSessionThreadEvents o && Equals(o);
        }
    }
}
