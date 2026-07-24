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
        /// Example: {"type":"user.message","id":"sevt_011CZkZGOp0iBcp4kaQSihUmy","content":[{"type":"text","text":"Where is my order #1234?"}],"processed_at":"2026-03-15T10:00:00Z"}
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
        public global::Anthropic.BetaManagedAgentsUserMessageEvent PickUserMessage() => IsUserMessage
            ? UserMessage!
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
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent PickUserInterrupt() => IsUserInterrupt
            ? UserInterrupt!
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
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent PickUserToolConfirmation() => IsUserToolConfirmation
            ? UserToolConfirmation!
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
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent PickUserCustomToolResult() => IsUserCustomToolResult
            ? UserCustomToolResult!
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
        public global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent PickAgentCustomToolUse() => IsAgentCustomToolUse
            ? AgentCustomToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentCustomToolUse' but the value was {ToString()}.");

        /// <summary>
        /// An agent response event in the session conversation.<br/>
        /// Example: {"type":"agent.message","id":"sevt_011CZkZHPq1jCdq5lbRTjiVnz","content":[{"type":"text","text":"Let me look up order #1234 for you."}],"processed_at":"2026-03-15T10:00:00Z"}
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
        public global::Anthropic.BetaManagedAgentsAgentMessageEvent PickAgentMessage() => IsAgentMessage
            ? AgentMessage!
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
        public global::Anthropic.BetaManagedAgentsAgentThinkingEvent PickAgentThinking() => IsAgentThinking
            ? AgentThinking!
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
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent PickAgentMcpToolUse() => IsAgentMcpToolUse
            ? AgentMcpToolUse!
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
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent PickAgentMcpToolResult() => IsAgentMcpToolResult
            ? AgentMcpToolResult!
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
        public global::Anthropic.BetaManagedAgentsAgentToolUseEvent PickAgentToolUse() => IsAgentToolUse
            ? AgentToolUse!
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
        public global::Anthropic.BetaManagedAgentsAgentToolResultEvent PickAgentToolResult() => IsAgentToolResult
            ? AgentToolResult!
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
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageReceivedEvent PickAgentThreadMessageReceived() => IsAgentThreadMessageReceived
            ? AgentThreadMessageReceived!
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
        public global::Anthropic.BetaManagedAgentsAgentThreadMessageSentEvent PickAgentThreadMessageSent() => IsAgentThreadMessageSent
            ? AgentThreadMessageSent!
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
        public global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent PickAgentThreadContextCompacted() => IsAgentThreadContextCompacted
            ? AgentThreadContextCompacted!
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
        public global::Anthropic.BetaManagedAgentsSessionErrorEvent PickSessionError() => IsSessionError
            ? SessionError!
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
        public global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent PickSessionStatusRescheduled() => IsSessionStatusRescheduled
            ? SessionStatusRescheduled!
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
        public global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent PickSessionStatusRunning() => IsSessionStatusRunning
            ? SessionStatusRunning!
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
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent PickSessionStatusIdle() => IsSessionStatusIdle
            ? SessionStatusIdle!
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
        public global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent PickSessionStatusTerminated() => IsSessionStatusTerminated
            ? SessionStatusTerminated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusTerminated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a subagent is spawned as a new thread. Written to the parent thread's output stream so clients observing the session see child creation.<br/>
        /// Example: {"type":"session.thread_created","id":"sevt_011CZkZWXb7pJkx1shYaqoCu","session_thread_id":"sthr_011CZkZVWa6oIjw0rgXZpnBt","processed_at":"2026-03-15T10:00:00Z","agent_name":"Researcher"}
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
        public global::Anthropic.BetaManagedAgentsSessionThreadCreatedEvent PickSessionThreadCreated() => IsSessionThreadCreated
            ? SessionThreadCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an outcome evaluation cycle begins.<br/>
        /// Example: {"type":"span.outcome_evaluation_start","id":"sevt_011CZkZTUy4mGhu8peVXnlzr","processed_at":"2026-03-15T10:02:14Z","iteration":0,"outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP"}
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
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEvent PickSpanOutcomeEvaluationStart() => IsSpanOutcomeEvaluationStart
            ? SpanOutcomeEvaluationStart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanOutcomeEvaluationStart' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an outcome evaluation cycle completes. Carries the verdict and aggregate token usage. A verdict of `needs_revision` means another evaluation cycle follows; `satisfied`, `max_iterations_reached`, `failed`, or `interrupted` are terminal — no further evaluation cycles follow.<br/>
        /// Example: {"type":"span.outcome_evaluation_end","id":"sevt_011CZkZUVz5nHiv9qfWYomas","processed_at":"2026-03-15T10:02:31Z","outcome_evaluation_start_id":"sevt_011CZkZTUy4mGhu8peVXnlzr","iteration":0,"result":"satisfied","explanation":"All five sections present with inline citations.","usage":{"input_tokens":1842,"output_tokens":213,"cache_creation_input_tokens":0,"cache_read_input_tokens":1536},"outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP"}
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
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEvent PickSpanOutcomeEvaluationEnd() => IsSpanOutcomeEvaluationEnd
            ? SpanOutcomeEvaluationEnd!
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
        public global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent PickSpanModelRequestStart() => IsSpanModelRequestStart
            ? SpanModelRequestStart!
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
        public global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent PickSpanModelRequestEnd() => IsSpanModelRequestEnd
            ? SpanModelRequestEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanModelRequestEnd' but the value was {ToString()}.");

        /// <summary>
        /// Periodic heartbeat emitted while an outcome evaluation cycle is in progress. Distinguishes 'evaluation is actively running' from 'evaluation is stuck' between the corresponding `span.outcome_evaluation_start` and `span.outcome_evaluation_end` events.<br/>
        /// Example: {"type":"span.outcome_evaluation_ongoing","id":"sevt_011CZkZbCG2uOpc6xmDfvTzh","processed_at":"2026-03-15T10:02:14Z","iteration":0,"outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP"}
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
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent PickSpanOutcomeEvaluationOngoing() => IsSpanOutcomeEvaluationOngoing
            ? SpanOutcomeEvaluationOngoing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpanOutcomeEvaluationOngoing' but the value was {ToString()}.");

        /// <summary>
        /// Echo of a `user.define_outcome` input event. Carries the server-generated `outcome_id` that subsequent `span.outcome_evaluation_*` events reference.<br/>
        /// Example: {"type":"user.define_outcome","id":"sevt_011CZkZSTx3lFgt7odUWmkyq","processed_at":"2026-03-15T10:02:14Z","outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP","description":"Produce a 2-page summary as summary.md","max_iterations":3,"rubric":{"type":"text","content":"Must cover all five sections; cite sources inline."}}
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
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent PickUserDefineOutcome() => IsUserDefineOutcome
            ? UserDefineOutcome!
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
        public global::Anthropic.BetaManagedAgentsSessionDeletedEvent PickSessionDeleted() => IsSessionDeleted
            ? SessionDeleted!
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
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRunningEvent PickSessionThreadStatusRunning() => IsSessionThreadStatusRunning
            ? SessionThreadStatusRunning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadStatusRunning' but the value was {ToString()}.");

        /// <summary>
        /// A session thread has yielded and is awaiting input. Emitted on the thread's own stream and cross-posted to the primary stream for child threads.<br/>
        /// Example: {"type":"session.thread_status_idle","id":"sevt_011CZkZXYc8qKly2tiZbrpDv","session_thread_id":"sthr_011CZkZVWa6oIjw0rgXZpnBt","processed_at":"2026-03-15T10:00:00Z","agent_name":"Researcher","stop_reason":{"type":"end_turn"}}
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
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEvent PickSessionThreadStatusIdle() => IsSessionThreadStatusIdle
            ? SessionThreadStatusIdle!
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
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusTerminatedEvent PickSessionThreadStatusTerminated() => IsSessionThreadStatusTerminated
            ? SessionThreadStatusTerminated!
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
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent PickUserToolResult() => IsUserToolResult
            ? UserToolResult!
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
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusRescheduledEvent PickSessionThreadStatusRescheduled() => IsSessionThreadStatusRescheduled
            ? SessionThreadStatusRescheduled!
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
        public global::Anthropic.BetaManagedAgentsSessionUpdatedEvent PickSessionUpdated() => IsSessionUpdated
            ? SessionUpdated!
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
        public global::Anthropic.BetaManagedAgentsEventStartEvent PickEventStart() => IsEventStart
            ? EventStart!
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
        public global::Anthropic.BetaManagedAgentsEventDeltaEvent PickEventDelta() => IsEventDelta
            ? EventDelta!
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
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent PickSystemMessage() => IsSystemMessage
            ? SystemMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemMessage' but the value was {ToString()}.");
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
            global::Anthropic.BetaManagedAgentsSystemMessageEvent? systemMessage
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            SystemMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && IsSessionUpdated && !IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && IsEventStart && !IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && IsEventDelta && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadMessageReceived && !IsAgentThreadMessageSent && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSpanOutcomeEvaluationStart && !IsSpanOutcomeEvaluationEnd && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSpanOutcomeEvaluationOngoing && !IsUserDefineOutcome && !IsSessionDeleted && !IsSessionThreadStatusRunning && !IsSessionThreadStatusIdle && !IsSessionThreadStatusTerminated && !IsUserToolResult && !IsSessionThreadStatusRescheduled && !IsSessionUpdated && !IsEventStart && !IsEventDelta && IsSystemMessage;
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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsUserInterrupt && userInterrupt != null)
            {
                return userInterrupt(UserInterrupt!);
            }
            else if (IsUserToolConfirmation && userToolConfirmation != null)
            {
                return userToolConfirmation(UserToolConfirmation!);
            }
            else if (IsUserCustomToolResult && userCustomToolResult != null)
            {
                return userCustomToolResult(UserCustomToolResult!);
            }
            else if (IsAgentCustomToolUse && agentCustomToolUse != null)
            {
                return agentCustomToolUse(AgentCustomToolUse!);
            }
            else if (IsAgentMessage && agentMessage != null)
            {
                return agentMessage(AgentMessage!);
            }
            else if (IsAgentThinking && agentThinking != null)
            {
                return agentThinking(AgentThinking!);
            }
            else if (IsAgentMcpToolUse && agentMcpToolUse != null)
            {
                return agentMcpToolUse(AgentMcpToolUse!);
            }
            else if (IsAgentMcpToolResult && agentMcpToolResult != null)
            {
                return agentMcpToolResult(AgentMcpToolResult!);
            }
            else if (IsAgentToolUse && agentToolUse != null)
            {
                return agentToolUse(AgentToolUse!);
            }
            else if (IsAgentToolResult && agentToolResult != null)
            {
                return agentToolResult(AgentToolResult!);
            }
            else if (IsAgentThreadMessageReceived && agentThreadMessageReceived != null)
            {
                return agentThreadMessageReceived(AgentThreadMessageReceived!);
            }
            else if (IsAgentThreadMessageSent && agentThreadMessageSent != null)
            {
                return agentThreadMessageSent(AgentThreadMessageSent!);
            }
            else if (IsAgentThreadContextCompacted && agentThreadContextCompacted != null)
            {
                return agentThreadContextCompacted(AgentThreadContextCompacted!);
            }
            else if (IsSessionError && sessionError != null)
            {
                return sessionError(SessionError!);
            }
            else if (IsSessionStatusRescheduled && sessionStatusRescheduled != null)
            {
                return sessionStatusRescheduled(SessionStatusRescheduled!);
            }
            else if (IsSessionStatusRunning && sessionStatusRunning != null)
            {
                return sessionStatusRunning(SessionStatusRunning!);
            }
            else if (IsSessionStatusIdle && sessionStatusIdle != null)
            {
                return sessionStatusIdle(SessionStatusIdle!);
            }
            else if (IsSessionStatusTerminated && sessionStatusTerminated != null)
            {
                return sessionStatusTerminated(SessionStatusTerminated!);
            }
            else if (IsSessionThreadCreated && sessionThreadCreated != null)
            {
                return sessionThreadCreated(SessionThreadCreated!);
            }
            else if (IsSpanOutcomeEvaluationStart && spanOutcomeEvaluationStart != null)
            {
                return spanOutcomeEvaluationStart(SpanOutcomeEvaluationStart!);
            }
            else if (IsSpanOutcomeEvaluationEnd && spanOutcomeEvaluationEnd != null)
            {
                return spanOutcomeEvaluationEnd(SpanOutcomeEvaluationEnd!);
            }
            else if (IsSpanModelRequestStart && spanModelRequestStart != null)
            {
                return spanModelRequestStart(SpanModelRequestStart!);
            }
            else if (IsSpanModelRequestEnd && spanModelRequestEnd != null)
            {
                return spanModelRequestEnd(SpanModelRequestEnd!);
            }
            else if (IsSpanOutcomeEvaluationOngoing && spanOutcomeEvaluationOngoing != null)
            {
                return spanOutcomeEvaluationOngoing(SpanOutcomeEvaluationOngoing!);
            }
            else if (IsUserDefineOutcome && userDefineOutcome != null)
            {
                return userDefineOutcome(UserDefineOutcome!);
            }
            else if (IsSessionDeleted && sessionDeleted != null)
            {
                return sessionDeleted(SessionDeleted!);
            }
            else if (IsSessionThreadStatusRunning && sessionThreadStatusRunning != null)
            {
                return sessionThreadStatusRunning(SessionThreadStatusRunning!);
            }
            else if (IsSessionThreadStatusIdle && sessionThreadStatusIdle != null)
            {
                return sessionThreadStatusIdle(SessionThreadStatusIdle!);
            }
            else if (IsSessionThreadStatusTerminated && sessionThreadStatusTerminated != null)
            {
                return sessionThreadStatusTerminated(SessionThreadStatusTerminated!);
            }
            else if (IsUserToolResult && userToolResult != null)
            {
                return userToolResult(UserToolResult!);
            }
            else if (IsSessionThreadStatusRescheduled && sessionThreadStatusRescheduled != null)
            {
                return sessionThreadStatusRescheduled(SessionThreadStatusRescheduled!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsEventStart && eventStart != null)
            {
                return eventStart(EventStart!);
            }
            else if (IsEventDelta && eventDelta != null)
            {
                return eventDelta(EventDelta!);
            }
            else if (IsSystemMessage && systemMessage != null)
            {
                return systemMessage(SystemMessage!);
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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsUserInterrupt)
            {
                userInterrupt?.Invoke(UserInterrupt!);
            }
            else if (IsUserToolConfirmation)
            {
                userToolConfirmation?.Invoke(UserToolConfirmation!);
            }
            else if (IsUserCustomToolResult)
            {
                userCustomToolResult?.Invoke(UserCustomToolResult!);
            }
            else if (IsAgentCustomToolUse)
            {
                agentCustomToolUse?.Invoke(AgentCustomToolUse!);
            }
            else if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsAgentThinking)
            {
                agentThinking?.Invoke(AgentThinking!);
            }
            else if (IsAgentMcpToolUse)
            {
                agentMcpToolUse?.Invoke(AgentMcpToolUse!);
            }
            else if (IsAgentMcpToolResult)
            {
                agentMcpToolResult?.Invoke(AgentMcpToolResult!);
            }
            else if (IsAgentToolUse)
            {
                agentToolUse?.Invoke(AgentToolUse!);
            }
            else if (IsAgentToolResult)
            {
                agentToolResult?.Invoke(AgentToolResult!);
            }
            else if (IsAgentThreadMessageReceived)
            {
                agentThreadMessageReceived?.Invoke(AgentThreadMessageReceived!);
            }
            else if (IsAgentThreadMessageSent)
            {
                agentThreadMessageSent?.Invoke(AgentThreadMessageSent!);
            }
            else if (IsAgentThreadContextCompacted)
            {
                agentThreadContextCompacted?.Invoke(AgentThreadContextCompacted!);
            }
            else if (IsSessionError)
            {
                sessionError?.Invoke(SessionError!);
            }
            else if (IsSessionStatusRescheduled)
            {
                sessionStatusRescheduled?.Invoke(SessionStatusRescheduled!);
            }
            else if (IsSessionStatusRunning)
            {
                sessionStatusRunning?.Invoke(SessionStatusRunning!);
            }
            else if (IsSessionStatusIdle)
            {
                sessionStatusIdle?.Invoke(SessionStatusIdle!);
            }
            else if (IsSessionStatusTerminated)
            {
                sessionStatusTerminated?.Invoke(SessionStatusTerminated!);
            }
            else if (IsSessionThreadCreated)
            {
                sessionThreadCreated?.Invoke(SessionThreadCreated!);
            }
            else if (IsSpanOutcomeEvaluationStart)
            {
                spanOutcomeEvaluationStart?.Invoke(SpanOutcomeEvaluationStart!);
            }
            else if (IsSpanOutcomeEvaluationEnd)
            {
                spanOutcomeEvaluationEnd?.Invoke(SpanOutcomeEvaluationEnd!);
            }
            else if (IsSpanModelRequestStart)
            {
                spanModelRequestStart?.Invoke(SpanModelRequestStart!);
            }
            else if (IsSpanModelRequestEnd)
            {
                spanModelRequestEnd?.Invoke(SpanModelRequestEnd!);
            }
            else if (IsSpanOutcomeEvaluationOngoing)
            {
                spanOutcomeEvaluationOngoing?.Invoke(SpanOutcomeEvaluationOngoing!);
            }
            else if (IsUserDefineOutcome)
            {
                userDefineOutcome?.Invoke(UserDefineOutcome!);
            }
            else if (IsSessionDeleted)
            {
                sessionDeleted?.Invoke(SessionDeleted!);
            }
            else if (IsSessionThreadStatusRunning)
            {
                sessionThreadStatusRunning?.Invoke(SessionThreadStatusRunning!);
            }
            else if (IsSessionThreadStatusIdle)
            {
                sessionThreadStatusIdle?.Invoke(SessionThreadStatusIdle!);
            }
            else if (IsSessionThreadStatusTerminated)
            {
                sessionThreadStatusTerminated?.Invoke(SessionThreadStatusTerminated!);
            }
            else if (IsUserToolResult)
            {
                userToolResult?.Invoke(UserToolResult!);
            }
            else if (IsSessionThreadStatusRescheduled)
            {
                sessionThreadStatusRescheduled?.Invoke(SessionThreadStatusRescheduled!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsEventStart)
            {
                eventStart?.Invoke(EventStart!);
            }
            else if (IsEventDelta)
            {
                eventDelta?.Invoke(EventDelta!);
            }
            else if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsUserInterrupt)
            {
                userInterrupt?.Invoke(UserInterrupt!);
            }
            else if (IsUserToolConfirmation)
            {
                userToolConfirmation?.Invoke(UserToolConfirmation!);
            }
            else if (IsUserCustomToolResult)
            {
                userCustomToolResult?.Invoke(UserCustomToolResult!);
            }
            else if (IsAgentCustomToolUse)
            {
                agentCustomToolUse?.Invoke(AgentCustomToolUse!);
            }
            else if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsAgentThinking)
            {
                agentThinking?.Invoke(AgentThinking!);
            }
            else if (IsAgentMcpToolUse)
            {
                agentMcpToolUse?.Invoke(AgentMcpToolUse!);
            }
            else if (IsAgentMcpToolResult)
            {
                agentMcpToolResult?.Invoke(AgentMcpToolResult!);
            }
            else if (IsAgentToolUse)
            {
                agentToolUse?.Invoke(AgentToolUse!);
            }
            else if (IsAgentToolResult)
            {
                agentToolResult?.Invoke(AgentToolResult!);
            }
            else if (IsAgentThreadMessageReceived)
            {
                agentThreadMessageReceived?.Invoke(AgentThreadMessageReceived!);
            }
            else if (IsAgentThreadMessageSent)
            {
                agentThreadMessageSent?.Invoke(AgentThreadMessageSent!);
            }
            else if (IsAgentThreadContextCompacted)
            {
                agentThreadContextCompacted?.Invoke(AgentThreadContextCompacted!);
            }
            else if (IsSessionError)
            {
                sessionError?.Invoke(SessionError!);
            }
            else if (IsSessionStatusRescheduled)
            {
                sessionStatusRescheduled?.Invoke(SessionStatusRescheduled!);
            }
            else if (IsSessionStatusRunning)
            {
                sessionStatusRunning?.Invoke(SessionStatusRunning!);
            }
            else if (IsSessionStatusIdle)
            {
                sessionStatusIdle?.Invoke(SessionStatusIdle!);
            }
            else if (IsSessionStatusTerminated)
            {
                sessionStatusTerminated?.Invoke(SessionStatusTerminated!);
            }
            else if (IsSessionThreadCreated)
            {
                sessionThreadCreated?.Invoke(SessionThreadCreated!);
            }
            else if (IsSpanOutcomeEvaluationStart)
            {
                spanOutcomeEvaluationStart?.Invoke(SpanOutcomeEvaluationStart!);
            }
            else if (IsSpanOutcomeEvaluationEnd)
            {
                spanOutcomeEvaluationEnd?.Invoke(SpanOutcomeEvaluationEnd!);
            }
            else if (IsSpanModelRequestStart)
            {
                spanModelRequestStart?.Invoke(SpanModelRequestStart!);
            }
            else if (IsSpanModelRequestEnd)
            {
                spanModelRequestEnd?.Invoke(SpanModelRequestEnd!);
            }
            else if (IsSpanOutcomeEvaluationOngoing)
            {
                spanOutcomeEvaluationOngoing?.Invoke(SpanOutcomeEvaluationOngoing!);
            }
            else if (IsUserDefineOutcome)
            {
                userDefineOutcome?.Invoke(UserDefineOutcome!);
            }
            else if (IsSessionDeleted)
            {
                sessionDeleted?.Invoke(SessionDeleted!);
            }
            else if (IsSessionThreadStatusRunning)
            {
                sessionThreadStatusRunning?.Invoke(SessionThreadStatusRunning!);
            }
            else if (IsSessionThreadStatusIdle)
            {
                sessionThreadStatusIdle?.Invoke(SessionThreadStatusIdle!);
            }
            else if (IsSessionThreadStatusTerminated)
            {
                sessionThreadStatusTerminated?.Invoke(SessionThreadStatusTerminated!);
            }
            else if (IsUserToolResult)
            {
                userToolResult?.Invoke(UserToolResult!);
            }
            else if (IsSessionThreadStatusRescheduled)
            {
                sessionThreadStatusRescheduled?.Invoke(SessionThreadStatusRescheduled!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsEventStart)
            {
                eventStart?.Invoke(EventStart!);
            }
            else if (IsEventDelta)
            {
                eventDelta?.Invoke(EventDelta!);
            }
            else if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSystemMessageEvent?>.Default.Equals(SystemMessage, other.SystemMessage) 
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
