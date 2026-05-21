
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType
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
        SessionUpdated,
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
        /// <summary>
        /// 
        /// </summary>
        UserToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsStreamSessionThreadEventsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentCustomToolUse => "agent.custom_tool_use",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentMcpToolResult => "agent.mcp_tool_result",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentMcpToolUse => "agent.mcp_tool_use",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentMessage => "agent.message",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThinking => "agent.thinking",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThreadContextCompacted => "agent.thread_context_compacted",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThreadMessageReceived => "agent.thread_message_received",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThreadMessageSent => "agent.thread_message_sent",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentToolResult => "agent.tool_result",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentToolUse => "agent.tool_use",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionDeleted => "session.deleted",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionError => "session.error",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusIdle => "session.status_idle",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusRescheduled => "session.status_rescheduled",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusRunning => "session.status_running",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusTerminated => "session.status_terminated",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadCreated => "session.thread_created",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusIdle => "session.thread_status_idle",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusRescheduled => "session.thread_status_rescheduled",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusRunning => "session.thread_status_running",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusTerminated => "session.thread_status_terminated",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionUpdated => "session.updated",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanModelRequestEnd => "span.model_request_end",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanModelRequestStart => "span.model_request_start",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanOutcomeEvaluationEnd => "span.outcome_evaluation_end",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanOutcomeEvaluationOngoing => "span.outcome_evaluation_ongoing",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanOutcomeEvaluationStart => "span.outcome_evaluation_start",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserDefineOutcome => "user.define_outcome",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserMessage => "user.message",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserToolConfirmation => "user.tool_confirmation",
                BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserToolResult => "user.tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent.custom_tool_use" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentCustomToolUse,
                "agent.mcp_tool_result" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentMcpToolResult,
                "agent.mcp_tool_use" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentMcpToolUse,
                "agent.message" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentMessage,
                "agent.thinking" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThinking,
                "agent.thread_context_compacted" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThreadContextCompacted,
                "agent.thread_message_received" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThreadMessageReceived,
                "agent.thread_message_sent" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentThreadMessageSent,
                "agent.tool_result" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentToolResult,
                "agent.tool_use" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.AgentToolUse,
                "session.deleted" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionDeleted,
                "session.error" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionError,
                "session.status_idle" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusIdle,
                "session.status_rescheduled" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusRescheduled,
                "session.status_running" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusRunning,
                "session.status_terminated" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionStatusTerminated,
                "session.thread_created" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadCreated,
                "session.thread_status_idle" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusIdle,
                "session.thread_status_rescheduled" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusRescheduled,
                "session.thread_status_running" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusRunning,
                "session.thread_status_terminated" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionThreadStatusTerminated,
                "session.updated" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SessionUpdated,
                "span.model_request_end" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanModelRequestEnd,
                "span.model_request_start" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanModelRequestStart,
                "span.outcome_evaluation_end" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanOutcomeEvaluationEnd,
                "span.outcome_evaluation_ongoing" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanOutcomeEvaluationOngoing,
                "span.outcome_evaluation_start" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.SpanOutcomeEvaluationStart,
                "user.custom_tool_result" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserCustomToolResult,
                "user.define_outcome" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserDefineOutcome,
                "user.interrupt" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserToolConfirmation,
                "user.tool_result" => BetaManagedAgentsStreamSessionThreadEventsDiscriminatorType.UserToolResult,
                _ => null,
            };
        }
    }
}