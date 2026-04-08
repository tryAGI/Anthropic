#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Server-sent event in the session stream.
    /// </summary>
    public readonly partial struct BetaManagedAgentsStreamSessionEvents : global::System.IEquatable<BetaManagedAgentsStreamSessionEvents>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType? Type { get; }

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
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserMessageEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsUserMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserMessageEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserMessageEvent? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserInterruptEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsUserInterruptEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserInterruptEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.UserInterrupt;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserInterruptEvent? value)
        {
            UserInterrupt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.UserToolConfirmation;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? value)
        {
            UserToolConfirmation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.UserCustomToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? value)
        {
            UserCustomToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentCustomToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? value)
        {
            AgentCustomToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentMessageEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentMessageEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentMessageEvent? value)
        {
            AgentMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentThinkingEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentThinkingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentThinkingEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentThinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentThinkingEvent? value)
        {
            AgentThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentMcpToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? value)
        {
            AgentMcpToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentMcpToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? value)
        {
            AgentMcpToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentToolUseEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentToolUseEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolUseEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentToolUseEvent? value)
        {
            AgentToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentToolResultEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentToolResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolResultEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentToolResultEvent? value)
        {
            AgentToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.AgentThreadContextCompacted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? value)
        {
            AgentThreadContextCompacted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionErrorEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSessionErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionErrorEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SessionError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionErrorEvent? value)
        {
            SessionError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SessionStatusRescheduled;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? value)
        {
            SessionStatusRescheduled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SessionStatusRunning;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? value)
        {
            SessionStatusRunning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SessionStatusIdle;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? value)
        {
            SessionStatusIdle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SessionStatusTerminated;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? value)
        {
            SessionStatusTerminated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SpanModelRequestStart;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? value)
        {
            SpanModelRequestStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SpanModelRequestEnd;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? value)
        {
            SpanModelRequestEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionDeletedEvent value) => new BetaManagedAgentsStreamSessionEvents((global::Anthropic.BetaManagedAgentsSessionDeletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionDeletedEvent?(BetaManagedAgentsStreamSessionEvents @this) => @this.SessionDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(global::Anthropic.BetaManagedAgentsSessionDeletedEvent? value)
        {
            SessionDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsStreamSessionEvents(
            global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType? type,
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
            global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? agentThreadContextCompacted,
            global::Anthropic.BetaManagedAgentsSessionErrorEvent? sessionError,
            global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? sessionStatusRescheduled,
            global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? sessionStatusRunning,
            global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? sessionStatusIdle,
            global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? sessionStatusTerminated,
            global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? spanModelRequestStart,
            global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? spanModelRequestEnd,
            global::Anthropic.BetaManagedAgentsSessionDeletedEvent? sessionDeleted
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
            AgentThreadContextCompacted = agentThreadContextCompacted;
            SessionError = sessionError;
            SessionStatusRescheduled = sessionStatusRescheduled;
            SessionStatusRunning = sessionStatusRunning;
            SessionStatusIdle = sessionStatusIdle;
            SessionStatusTerminated = sessionStatusTerminated;
            SpanModelRequestStart = spanModelRequestStart;
            SpanModelRequestEnd = spanModelRequestEnd;
            SessionDeleted = sessionDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SessionDeleted as object ??
            SpanModelRequestEnd as object ??
            SpanModelRequestStart as object ??
            SessionStatusTerminated as object ??
            SessionStatusIdle as object ??
            SessionStatusRunning as object ??
            SessionStatusRescheduled as object ??
            SessionError as object ??
            AgentThreadContextCompacted as object ??
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
            AgentThreadContextCompacted?.ToString() ??
            SessionError?.ToString() ??
            SessionStatusRescheduled?.ToString() ??
            SessionStatusRunning?.ToString() ??
            SessionStatusIdle?.ToString() ??
            SessionStatusTerminated?.ToString() ??
            SpanModelRequestStart?.ToString() ??
            SpanModelRequestEnd?.ToString() ??
            SessionDeleted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && IsSpanModelRequestStart && !IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && IsSpanModelRequestEnd && !IsSessionDeleted || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsAgentCustomToolUse && !IsAgentMessage && !IsAgentThinking && !IsAgentMcpToolUse && !IsAgentMcpToolResult && !IsAgentToolUse && !IsAgentToolResult && !IsAgentThreadContextCompacted && !IsSessionError && !IsSessionStatusRescheduled && !IsSessionStatusRunning && !IsSessionStatusIdle && !IsSessionStatusTerminated && !IsSpanModelRequestStart && !IsSpanModelRequestEnd && IsSessionDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUserMessageEvent?, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserInterruptEvent?, TResult>? userInterrupt = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?, TResult>? userToolConfirmation = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?, TResult>? userCustomToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?, TResult>? agentCustomToolUse = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentMessageEvent?, TResult>? agentMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentThinkingEvent?, TResult>? agentThinking = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?, TResult>? agentMcpToolUse = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?, TResult>? agentMcpToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolUseEvent?, TResult>? agentToolUse = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolResultEvent?, TResult>? agentToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?, TResult>? agentThreadContextCompacted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionErrorEvent?, TResult>? sessionError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?, TResult>? sessionStatusRescheduled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?, TResult>? sessionStatusRunning = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?, TResult>? sessionStatusIdle = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?, TResult>? sessionStatusTerminated = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?, TResult>? spanModelRequestStart = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?, TResult>? spanModelRequestEnd = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionDeletedEvent?, TResult>? sessionDeleted = null,
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
            else if (IsSpanModelRequestStart && spanModelRequestStart != null)
            {
                return spanModelRequestStart(SpanModelRequestStart!);
            }
            else if (IsSpanModelRequestEnd && spanModelRequestEnd != null)
            {
                return spanModelRequestEnd(SpanModelRequestEnd!);
            }
            else if (IsSessionDeleted && sessionDeleted != null)
            {
                return sessionDeleted(SessionDeleted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEvent?>? userMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEvent?>? userInterrupt = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?>? userToolConfirmation = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?>? userCustomToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?>? agentCustomToolUse = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMessageEvent?>? agentMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThinkingEvent?>? agentThinking = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?>? agentMcpToolUse = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?>? agentMcpToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolUseEvent?>? agentToolUse = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolResultEvent?>? agentToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?>? agentThreadContextCompacted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionErrorEvent?>? sessionError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?>? sessionStatusRescheduled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?>? sessionStatusRunning = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?>? sessionStatusIdle = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?>? sessionStatusTerminated = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?>? spanModelRequestStart = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?>? spanModelRequestEnd = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionDeletedEvent?>? sessionDeleted = null,
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
            else if (IsSpanModelRequestStart)
            {
                spanModelRequestStart?.Invoke(SpanModelRequestStart!);
            }
            else if (IsSpanModelRequestEnd)
            {
                spanModelRequestEnd?.Invoke(SpanModelRequestEnd!);
            }
            else if (IsSessionDeleted)
            {
                sessionDeleted?.Invoke(SessionDeleted!);
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
                SpanModelRequestStart,
                typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent),
                SpanModelRequestEnd,
                typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent),
                SessionDeleted,
                typeof(global::Anthropic.BetaManagedAgentsSessionDeletedEvent),
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
        public bool Equals(BetaManagedAgentsStreamSessionEvents other)
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?>.Default.Equals(AgentThreadContextCompacted, other.AgentThreadContextCompacted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionErrorEvent?>.Default.Equals(SessionError, other.SessionError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?>.Default.Equals(SessionStatusRescheduled, other.SessionStatusRescheduled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?>.Default.Equals(SessionStatusRunning, other.SessionStatusRunning) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?>.Default.Equals(SessionStatusIdle, other.SessionStatusIdle) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?>.Default.Equals(SessionStatusTerminated, other.SessionStatusTerminated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?>.Default.Equals(SpanModelRequestStart, other.SpanModelRequestStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?>.Default.Equals(SpanModelRequestEnd, other.SpanModelRequestEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionDeletedEvent?>.Default.Equals(SessionDeleted, other.SessionDeleted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsStreamSessionEvents obj1, BetaManagedAgentsStreamSessionEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsStreamSessionEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsStreamSessionEvents obj1, BetaManagedAgentsStreamSessionEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsStreamSessionEvents o && Equals(o);
        }
    }
}
