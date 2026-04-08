
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
        SpanModelRequestEnd,
        /// <summary>
        /// 
        /// </summary>
        SpanModelRequestStart,
        /// <summary>
        /// 
        /// </summary>
        UserCustomToolResult,
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
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolResult => "agent.tool_result",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolUse => "agent.tool_use",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionDeleted => "session.deleted",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionError => "session.error",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusIdle => "session.status_idle",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRescheduled => "session.status_rescheduled",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRunning => "session.status_running",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusTerminated => "session.status_terminated",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestEnd => "span.model_request_end",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestStart => "span.model_request_start",
                BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
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
                "agent.tool_result" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolResult,
                "agent.tool_use" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolUse,
                "session.deleted" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionDeleted,
                "session.error" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionError,
                "session.status_idle" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusIdle,
                "session.status_rescheduled" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRescheduled,
                "session.status_running" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRunning,
                "session.status_terminated" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusTerminated,
                "span.model_request_end" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestEnd,
                "span.model_request_start" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestStart,
                "user.custom_tool_result" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserCustomToolResult,
                "user.interrupt" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserToolConfirmation,
                _ => null,
            };
        }
    }
}