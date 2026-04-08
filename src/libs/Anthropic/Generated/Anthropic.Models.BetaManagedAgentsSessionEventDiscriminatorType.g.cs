
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
                BetaManagedAgentsSessionEventDiscriminatorType.AgentToolResult => "agent.tool_result",
                BetaManagedAgentsSessionEventDiscriminatorType.AgentToolUse => "agent.tool_use",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionDeleted => "session.deleted",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionError => "session.error",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusIdle => "session.status_idle",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRescheduled => "session.status_rescheduled",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRunning => "session.status_running",
                BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusTerminated => "session.status_terminated",
                BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestEnd => "span.model_request_end",
                BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestStart => "span.model_request_start",
                BetaManagedAgentsSessionEventDiscriminatorType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsSessionEventDiscriminatorType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsSessionEventDiscriminatorType.UserMessage => "user.message",
                BetaManagedAgentsSessionEventDiscriminatorType.UserToolConfirmation => "user.tool_confirmation",
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
                "agent.tool_result" => BetaManagedAgentsSessionEventDiscriminatorType.AgentToolResult,
                "agent.tool_use" => BetaManagedAgentsSessionEventDiscriminatorType.AgentToolUse,
                "session.deleted" => BetaManagedAgentsSessionEventDiscriminatorType.SessionDeleted,
                "session.error" => BetaManagedAgentsSessionEventDiscriminatorType.SessionError,
                "session.status_idle" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusIdle,
                "session.status_rescheduled" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRescheduled,
                "session.status_running" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusRunning,
                "session.status_terminated" => BetaManagedAgentsSessionEventDiscriminatorType.SessionStatusTerminated,
                "span.model_request_end" => BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestEnd,
                "span.model_request_start" => BetaManagedAgentsSessionEventDiscriminatorType.SpanModelRequestStart,
                "user.custom_tool_result" => BetaManagedAgentsSessionEventDiscriminatorType.UserCustomToolResult,
                "user.interrupt" => BetaManagedAgentsSessionEventDiscriminatorType.UserInterrupt,
                "user.message" => BetaManagedAgentsSessionEventDiscriminatorType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsSessionEventDiscriminatorType.UserToolConfirmation,
                _ => null,
            };
        }
    }
}