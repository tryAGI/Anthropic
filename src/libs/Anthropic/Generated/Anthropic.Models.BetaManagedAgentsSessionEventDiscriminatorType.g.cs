
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionEventDiscriminatorType
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
        SystemMessage,
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
    public static class BetaManagedAgentsSessionEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionEventDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionEventDiscriminatorType.AgentCustomToolUse => "agent.custom_tool_use",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentMcpToolResult => "agent.mcp_tool_result",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentMcpToolUse => "agent.mcp_tool_use",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentMessage => "agent.message",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentThinking => "agent.thinking",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentThreadContextCompacted => "agent.thread_context_compacted",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentThreadMessageReceived => "agent.thread_message_received",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentThreadMessageSent => "agent.thread_message_sent",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentToolResult => "agent.tool_result",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentToolUse => "agent.tool_use",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionDeleted => "session.deleted",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionError => "session.error",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusIdle => "session.status_idle",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRescheduled => "session.status_rescheduled",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRunning => "session.status_running",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusTerminated => "session.status_terminated",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadCreated => "session.thread_created",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusIdle => "session.thread_status_idle",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusRescheduled => "session.thread_status_rescheduled",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusRunning => "session.thread_status_running",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusTerminated => "session.thread_status_terminated",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionUpdated => "session.updated",
                BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestEnd => "span.model_request_end",
                BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestStart => "span.model_request_start",
                BetaManagedAgentsSessionEventDiscriminatorType.SpanOutcomeEvaluationEnd => "span.outcome_evaluation_end",
                BetaManagedAgentsSessionEventDiscriminatorType.SpanOutcomeEvaluationOngoing => "span.outcome_evaluation_ongoing",
                BetaManagedAgentsSessionEventDiscriminatorType.SpanOutcomeEvaluationStart => "span.outcome_evaluation_start",
                BetaManagedAgentsSessionEventDiscriminatorType.SystemMessage => "system.message",
                BetaManagedAgentsSessionEventDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsSessionEventDiscriminatorType.UserDefineOutcome => "user.define_outcome",
                BetaManagedAgentsSessionEventDiscriminatorType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsSessionEventDiscriminatorType.UserMessage => "user.message",
                BetaManagedAgentsSessionEventDiscriminatorType.UserToolConfirmation => "user.tool_confirmation",
                BetaManagedAgentsSessionEventDiscriminatorType.UserToolResult => "user.tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent.custom_tool_use" => BetaManagedAgentsSessionEventDiscriminatorType.AgentCustomToolUse,
                "agent.mcp_tool_result" => BetaManagedAgentsSessionEventDiscriminatorType.AgentMcpToolResult,
                "agent.mcp_tool_use" => BetaManagedAgentsSessionEventDiscriminatorType.AgentMcpToolUse,
                "agent.message" => BetaManagedAgentsSessionEventDiscriminatorType.AgentMessage,
                "agent.thinking" => BetaManagedAgentsSessionEventDiscriminatorType.AgentThinking,
                "agent.thread_context_compacted" => BetaManagedAgentsSessionEventDiscriminatorType.AgentThreadContextCompacted,
                "agent.thread_message_received" => BetaManagedAgentsSessionEventDiscriminatorType.AgentThreadMessageReceived,
                "agent.thread_message_sent" => BetaManagedAgentsSessionEventDiscriminatorType.AgentThreadMessageSent,
                "agent.tool_result" => BetaManagedAgentsSessionEventDiscriminatorType.AgentToolResult,
                "agent.tool_use" => BetaManagedAgentsSessionEventDiscriminatorType.AgentToolUse,
                "session.deleted" => BetaManagedAgentsSessionEventDiscriminatorType.SessionDeleted,
                "session.error" => BetaManagedAgentsSessionEventDiscriminatorType.SessionError,
                "session.status_idle" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusIdle,
                "session.status_rescheduled" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRescheduled,
                "session.status_running" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRunning,
                "session.status_terminated" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusTerminated,
                "session.thread_created" => BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadCreated,
                "session.thread_status_idle" => BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusIdle,
                "session.thread_status_rescheduled" => BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusRescheduled,
                "session.thread_status_running" => BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusRunning,
                "session.thread_status_terminated" => BetaManagedAgentsSessionEventDiscriminatorType.SessionThreadStatusTerminated,
                "session.updated" => BetaManagedAgentsSessionEventDiscriminatorType.SessionUpdated,
                "span.model_request_end" => BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestEnd,
                "span.model_request_start" => BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestStart,
                "span.outcome_evaluation_end" => BetaManagedAgentsSessionEventDiscriminatorType.SpanOutcomeEvaluationEnd,
                "span.outcome_evaluation_ongoing" => BetaManagedAgentsSessionEventDiscriminatorType.SpanOutcomeEvaluationOngoing,
                "span.outcome_evaluation_start" => BetaManagedAgentsSessionEventDiscriminatorType.SpanOutcomeEvaluationStart,
                "system.message" => BetaManagedAgentsSessionEventDiscriminatorType.SystemMessage,
                "user.custom_tool_result" => BetaManagedAgentsSessionEventDiscriminatorType.UserCustomToolResult,
                "user.define_outcome" => BetaManagedAgentsSessionEventDiscriminatorType.UserDefineOutcome,
                "user.interrupt" => BetaManagedAgentsSessionEventDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsSessionEventDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsSessionEventDiscriminatorType.UserToolConfirmation,
                "user.tool_result" => BetaManagedAgentsSessionEventDiscriminatorType.UserToolResult,
                _ => null,
            };
        }
    }
}