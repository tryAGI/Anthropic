
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `type` of a session event.
    /// </summary>
    public enum BetaManagedAgentsSessionEventType
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
        SessionUsage,
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
        /// <summary>
        ///
        /// </summary>
        WorkflowRunCreated,
        /// <summary>
        ///
        /// </summary>
        WorkflowRunError,
        /// <summary>
        ///
        /// </summary>
        WorkflowRunPhaseEnded,
        /// <summary>
        ///
        /// </summary>
        WorkflowRunPhaseStarted,
        /// <summary>
        ///
        /// </summary>
        WorkflowRunStatusEnded,
        /// <summary>
        ///
        /// </summary>
        WorkflowRunStatusIdle,
        /// <summary>
        ///
        /// </summary>
        WorkflowRunStatusRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionEventType.AgentCustomToolUse => "agent.custom_tool_use",
                BetaManagedAgentsSessionEventType.AgentMcpToolResult => "agent.mcp_tool_result",
                BetaManagedAgentsSessionEventType.AgentMcpToolUse => "agent.mcp_tool_use",
                BetaManagedAgentsSessionEventType.AgentMessage => "agent.message",
                BetaManagedAgentsSessionEventType.AgentThinking => "agent.thinking",
                BetaManagedAgentsSessionEventType.AgentThreadContextCompacted => "agent.thread_context_compacted",
                BetaManagedAgentsSessionEventType.AgentThreadMessageReceived => "agent.thread_message_received",
                BetaManagedAgentsSessionEventType.AgentThreadMessageSent => "agent.thread_message_sent",
                BetaManagedAgentsSessionEventType.AgentToolResult => "agent.tool_result",
                BetaManagedAgentsSessionEventType.AgentToolUse => "agent.tool_use",
                BetaManagedAgentsSessionEventType.SessionError => "session.error",
                BetaManagedAgentsSessionEventType.SessionStatusIdle => "session.status_idle",
                BetaManagedAgentsSessionEventType.SessionStatusRescheduled => "session.status_rescheduled",
                BetaManagedAgentsSessionEventType.SessionStatusRunning => "session.status_running",
                BetaManagedAgentsSessionEventType.SessionStatusTerminated => "session.status_terminated",
                BetaManagedAgentsSessionEventType.SessionThreadCreated => "session.thread_created",
                BetaManagedAgentsSessionEventType.SessionThreadStatusIdle => "session.thread_status_idle",
                BetaManagedAgentsSessionEventType.SessionThreadStatusRescheduled => "session.thread_status_rescheduled",
                BetaManagedAgentsSessionEventType.SessionThreadStatusRunning => "session.thread_status_running",
                BetaManagedAgentsSessionEventType.SessionThreadStatusTerminated => "session.thread_status_terminated",
                BetaManagedAgentsSessionEventType.SessionUpdated => "session.updated",
                BetaManagedAgentsSessionEventType.SessionUsage => "session.usage",
                BetaManagedAgentsSessionEventType.SpanModelRequestEnd => "span.model_request_end",
                BetaManagedAgentsSessionEventType.SpanModelRequestStart => "span.model_request_start",
                BetaManagedAgentsSessionEventType.SpanOutcomeEvaluationEnd => "span.outcome_evaluation_end",
                BetaManagedAgentsSessionEventType.SpanOutcomeEvaluationOngoing => "span.outcome_evaluation_ongoing",
                BetaManagedAgentsSessionEventType.SpanOutcomeEvaluationStart => "span.outcome_evaluation_start",
                BetaManagedAgentsSessionEventType.SystemMessage => "system.message",
                BetaManagedAgentsSessionEventType.UserCustomToolResult => "user.custom_tool_result",
                BetaManagedAgentsSessionEventType.UserDefineOutcome => "user.define_outcome",
                BetaManagedAgentsSessionEventType.UserInterrupt => "user.interrupt",
                BetaManagedAgentsSessionEventType.UserMessage => "user.message",
                BetaManagedAgentsSessionEventType.UserToolConfirmation => "user.tool_confirmation",
                BetaManagedAgentsSessionEventType.UserToolResult => "user.tool_result",
                BetaManagedAgentsSessionEventType.WorkflowRunCreated => "workflow_run.created",
                BetaManagedAgentsSessionEventType.WorkflowRunError => "workflow_run.error",
                BetaManagedAgentsSessionEventType.WorkflowRunPhaseEnded => "workflow_run.phase_ended",
                BetaManagedAgentsSessionEventType.WorkflowRunPhaseStarted => "workflow_run.phase_started",
                BetaManagedAgentsSessionEventType.WorkflowRunStatusEnded => "workflow_run.status_ended",
                BetaManagedAgentsSessionEventType.WorkflowRunStatusIdle => "workflow_run.status_idle",
                BetaManagedAgentsSessionEventType.WorkflowRunStatusRunning => "workflow_run.status_running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.custom_tool_use" => BetaManagedAgentsSessionEventType.AgentCustomToolUse,
                "agent.mcp_tool_result" => BetaManagedAgentsSessionEventType.AgentMcpToolResult,
                "agent.mcp_tool_use" => BetaManagedAgentsSessionEventType.AgentMcpToolUse,
                "agent.message" => BetaManagedAgentsSessionEventType.AgentMessage,
                "agent.thinking" => BetaManagedAgentsSessionEventType.AgentThinking,
                "agent.thread_context_compacted" => BetaManagedAgentsSessionEventType.AgentThreadContextCompacted,
                "agent.thread_message_received" => BetaManagedAgentsSessionEventType.AgentThreadMessageReceived,
                "agent.thread_message_sent" => BetaManagedAgentsSessionEventType.AgentThreadMessageSent,
                "agent.tool_result" => BetaManagedAgentsSessionEventType.AgentToolResult,
                "agent.tool_use" => BetaManagedAgentsSessionEventType.AgentToolUse,
                "session.error" => BetaManagedAgentsSessionEventType.SessionError,
                "session.status_idle" => BetaManagedAgentsSessionEventType.SessionStatusIdle,
                "session.status_rescheduled" => BetaManagedAgentsSessionEventType.SessionStatusRescheduled,
                "session.status_running" => BetaManagedAgentsSessionEventType.SessionStatusRunning,
                "session.status_terminated" => BetaManagedAgentsSessionEventType.SessionStatusTerminated,
                "session.thread_created" => BetaManagedAgentsSessionEventType.SessionThreadCreated,
                "session.thread_status_idle" => BetaManagedAgentsSessionEventType.SessionThreadStatusIdle,
                "session.thread_status_rescheduled" => BetaManagedAgentsSessionEventType.SessionThreadStatusRescheduled,
                "session.thread_status_running" => BetaManagedAgentsSessionEventType.SessionThreadStatusRunning,
                "session.thread_status_terminated" => BetaManagedAgentsSessionEventType.SessionThreadStatusTerminated,
                "session.updated" => BetaManagedAgentsSessionEventType.SessionUpdated,
                "session.usage" => BetaManagedAgentsSessionEventType.SessionUsage,
                "span.model_request_end" => BetaManagedAgentsSessionEventType.SpanModelRequestEnd,
                "span.model_request_start" => BetaManagedAgentsSessionEventType.SpanModelRequestStart,
                "span.outcome_evaluation_end" => BetaManagedAgentsSessionEventType.SpanOutcomeEvaluationEnd,
                "span.outcome_evaluation_ongoing" => BetaManagedAgentsSessionEventType.SpanOutcomeEvaluationOngoing,
                "span.outcome_evaluation_start" => BetaManagedAgentsSessionEventType.SpanOutcomeEvaluationStart,
                "system.message" => BetaManagedAgentsSessionEventType.SystemMessage,
                "user.custom_tool_result" => BetaManagedAgentsSessionEventType.UserCustomToolResult,
                "user.define_outcome" => BetaManagedAgentsSessionEventType.UserDefineOutcome,
                "user.interrupt" => BetaManagedAgentsSessionEventType.UserInterrupt,
                "user.message" => BetaManagedAgentsSessionEventType.UserMessage,
                "user.tool_confirmation" => BetaManagedAgentsSessionEventType.UserToolConfirmation,
                "user.tool_result" => BetaManagedAgentsSessionEventType.UserToolResult,
                "workflow_run.created" => BetaManagedAgentsSessionEventType.WorkflowRunCreated,
                "workflow_run.error" => BetaManagedAgentsSessionEventType.WorkflowRunError,
                "workflow_run.phase_ended" => BetaManagedAgentsSessionEventType.WorkflowRunPhaseEnded,
                "workflow_run.phase_started" => BetaManagedAgentsSessionEventType.WorkflowRunPhaseStarted,
                "workflow_run.status_ended" => BetaManagedAgentsSessionEventType.WorkflowRunStatusEnded,
                "workflow_run.status_idle" => BetaManagedAgentsSessionEventType.WorkflowRunStatusIdle,
                "workflow_run.status_running" => BetaManagedAgentsSessionEventType.WorkflowRunStatusRunning,
                _ => null,
            };
        }
    }
}