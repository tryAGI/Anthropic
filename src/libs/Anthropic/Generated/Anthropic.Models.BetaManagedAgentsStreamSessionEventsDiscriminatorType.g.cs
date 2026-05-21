
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsStreamSessionEventsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentCustomToolUse,
        /// <summary>
        /// 
        /// </summary>
        AgentMcpToolResult,
        /// <summary>
        /// 
        /// </summary>
        AgentMcpToolUse,
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
        /// <summary>
        /// 
        /// </summary>
        AgentThinking,
        /// <summary>
        /// 
        /// </summary>
        AgentThreadContextCompacted,
        /// <summary>
        /// 
        /// </summary>
        AgentThreadMessageReceived,
        /// <summary>
        /// 
        /// </summary>
        AgentThreadMessageSent,
        /// <summary>
        /// 
        /// </summary>
        AgentToolResult,
        /// <summary>
        /// 
        /// </summary>
        AgentToolUse,
        /// <summary>
        /// 
        /// </summary>
        SessionDeleted,
        /// <summary>
        /// 
        /// </summary>
        SessionError,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusIdle,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusRescheduled,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusRunning,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusTerminated,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusIdle,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusRescheduled,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusRunning,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadStatusTerminated,
        /// <summary>
        /// 
        /// </summary>
        SpanModelRequestEnd,
        /// <summary>
        /// 
        /// </summary>
        SpanModelRequestStart,
        /// <summary>
        /// 
        /// </summary>
        SpanOutcomeEvaluationEnd,
        /// <summary>
        /// 
        /// </summary>
        SpanOutcomeEvaluationOngoing,
        /// <summary>
        /// 
        /// </summary>
        SpanOutcomeEvaluationStart,
        /// <summary>
        /// 
        /// </summary>
        UserCustomToolResult,
        /// <summary>
        /// 
        /// </summary>
        UserDefineOutcome,
        /// <summary>
        /// 
        /// </summary>
        UserInterrupt,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
        /// <summary>
        /// 
        /// </summary>
        UserToolConfirmation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsStreamSessionEventsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsStreamSessionEventsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentCustomToolUse => "agent.custom_tool_use",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMcpToolResult => "agent.mcp_tool_result",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMcpToolUse => "agent.mcp_tool_use",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMessage => "agent.message",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThinking => "agent.thinking",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThreadContextCompacted => "agent.thread_context_compacted",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThreadMessageReceived => "agent.thread_message_received",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThreadMessageSent => "agent.thread_message_sent",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolResult => "agent.tool_result",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolUse => "agent.tool_use",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionDeleted => "session.deleted",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionError => "session.error",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusIdle => "session.status_idle",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRescheduled => "session.status_rescheduled",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRunning => "session.status_running",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusTerminated => "session.status_terminated",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadCreated => "session.thread_created",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusIdle => "session.thread_status_idle",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusRescheduled => "session.thread_status_rescheduled",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusRunning => "session.thread_status_running",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusTerminated => "session.thread_status_terminated",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestEnd => "span.model_request_end",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestStart => "span.model_request_start",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanOutcomeEvaluationEnd => "span.outcome_evaluation_end",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanOutcomeEvaluationOngoing => "span.outcome_evaluation_ongoing",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanOutcomeEvaluationStart => "span.outcome_evaluation_start",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserDefineOutcome => "user.define_outcome",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserMessage => "user.message",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserToolConfirmation => "user.tool_confirmation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsStreamSessionEventsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent.custom_tool_use" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentCustomToolUse,
                "agent.mcp_tool_result" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMcpToolResult,
                "agent.mcp_tool_use" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMcpToolUse,
                "agent.message" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMessage,
                "agent.thinking" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThinking,
                "agent.thread_context_compacted" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThreadContextCompacted,
                "agent.thread_message_received" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThreadMessageReceived,
                "agent.thread_message_sent" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThreadMessageSent,
                "agent.tool_result" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolResult,
                "agent.tool_use" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolUse,
                "session.deleted" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionDeleted,
                "session.error" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionError,
                "session.status_idle" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusIdle,
                "session.status_rescheduled" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRescheduled,
                "session.status_running" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRunning,
                "session.status_terminated" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusTerminated,
                "session.thread_created" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadCreated,
                "session.thread_status_idle" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusIdle,
                "session.thread_status_rescheduled" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusRescheduled,
                "session.thread_status_running" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusRunning,
                "session.thread_status_terminated" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionThreadStatusTerminated,
                "span.model_request_end" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestEnd,
                "span.model_request_start" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestStart,
                "span.outcome_evaluation_end" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanOutcomeEvaluationEnd,
                "span.outcome_evaluation_ongoing" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanOutcomeEvaluationOngoing,
                "span.outcome_evaluation_start" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanOutcomeEvaluationStart,
                "user.custom_tool_result" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserCustomToolResult,
                "user.define_outcome" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserDefineOutcome,
                "user.interrupt" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserToolConfirmation,
                _ => null,
            };
        }
    }
}