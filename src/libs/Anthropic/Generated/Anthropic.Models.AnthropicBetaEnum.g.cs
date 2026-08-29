
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicBetaEnum
    {
        /// <summary>
        ///
        /// </summary>
        AdvisorTool20260301,
        /// <summary>
        ///
        /// </summary>
        AgentMemory20260722,
        /// <summary>
        ///
        /// </summary>
        CacheDiagnosis20260407,
        /// <summary>
        ///
        /// </summary>
        CeUserManagement20260713,
        /// <summary>
        ///
        /// </summary>
        CodeExecution20250522,
        /// <summary>
        ///
        /// </summary>
        Compact20260112,
        /// <summary>
        ///
        /// </summary>
        ComputerUse20241022,
        /// <summary>
        ///
        /// </summary>
        ComputerUse20250124,
        /// <summary>
        ///
        /// </summary>
        ComputerUse20251124,
        /// <summary>
        ///
        /// </summary>
        Context1m20250807,
        /// <summary>
        ///
        /// </summary>
        ContextManagement20250627,
        /// <summary>
        ///
        /// </summary>
        DevFullThinking20250514,
        /// <summary>
        ///
        /// </summary>
        Dreaming20260421,
        /// <summary>
        ///
        /// </summary>
        ExtendedCacheTtl20250411,
        /// <summary>
        ///
        /// </summary>
        FallbackCredit20260601,
        /// <summary>
        ///
        /// </summary>
        FallbackCredit20260701,
        /// <summary>
        ///
        /// </summary>
        FastMode20260201,
        /// <summary>
        ///
        /// </summary>
        FilesApi20250414,
        /// <summary>
        ///
        /// </summary>
        InterleavedThinking20250514,
        /// <summary>
        ///
        /// </summary>
        ManagedAgents20260401,
        /// <summary>
        ///
        /// </summary>
        McpClient20250404,
        /// <summary>
        ///
        /// </summary>
        McpClient20251120,
        /// <summary>
        ///
        /// </summary>
        McpTunnels20260622,
        /// <summary>
        ///
        /// </summary>
        MessageBatches20240924,
        /// <summary>
        ///
        /// </summary>
        MidConversationToolChanges20260701,
        /// <summary>
        ///
        /// </summary>
        ModelContextWindowExceeded20250826,
        /// <summary>
        ///
        /// </summary>
        Output128k20250219,
        /// <summary>
        ///
        /// </summary>
        Output300k20260324,
        /// <summary>
        ///
        /// </summary>
        Pdfs20240925,
        /// <summary>
        ///
        /// </summary>
        PromptCaching20240731,
        /// <summary>
        ///
        /// </summary>
        ServerSideFallback20260601,
        /// <summary>
        ///
        /// </summary>
        ServerSideFallback20260701,
        /// <summary>
        ///
        /// </summary>
        Skills20251002,
        /// <summary>
        ///
        /// </summary>
        StructuredOutputs20251113,
        /// <summary>
        ///
        /// </summary>
        TaskBudgets20260313,
        /// <summary>
        ///
        /// </summary>
        ThinkingDisplayUpdates20260818,
        /// <summary>
        ///
        /// </summary>
        ThinkingTokenCount20260513,
        /// <summary>
        ///
        /// </summary>
        TokenCounting20241101,
        /// <summary>
        ///
        /// </summary>
        TokenEfficientTools20250219,
        /// <summary>
        ///
        /// </summary>
        UserProfiles20260324,
        /// <summary>
        ///
        /// </summary>
        UserProfiles20260818,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBetaEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBetaEnum value)
        {
            return value switch
            {
                AnthropicBetaEnum.AdvisorTool20260301 => "advisor-tool-2026-03-01",
                AnthropicBetaEnum.AgentMemory20260722 => "agent-memory-2026-07-22",
                AnthropicBetaEnum.CacheDiagnosis20260407 => "cache-diagnosis-2026-04-07",
                AnthropicBetaEnum.CeUserManagement20260713 => "ce-user-management-2026-07-13",
                AnthropicBetaEnum.CodeExecution20250522 => "code-execution-2025-05-22",
                AnthropicBetaEnum.Compact20260112 => "compact-2026-01-12",
                AnthropicBetaEnum.ComputerUse20241022 => "computer-use-2024-10-22",
                AnthropicBetaEnum.ComputerUse20250124 => "computer-use-2025-01-24",
                AnthropicBetaEnum.ComputerUse20251124 => "computer-use-2025-11-24",
                AnthropicBetaEnum.Context1m20250807 => "context-1m-2025-08-07",
                AnthropicBetaEnum.ContextManagement20250627 => "context-management-2025-06-27",
                AnthropicBetaEnum.DevFullThinking20250514 => "dev-full-thinking-2025-05-14",
                AnthropicBetaEnum.Dreaming20260421 => "dreaming-2026-04-21",
                AnthropicBetaEnum.ExtendedCacheTtl20250411 => "extended-cache-ttl-2025-04-11",
                AnthropicBetaEnum.FallbackCredit20260601 => "fallback-credit-2026-06-01",
                AnthropicBetaEnum.FallbackCredit20260701 => "fallback-credit-2026-07-01",
                AnthropicBetaEnum.FastMode20260201 => "fast-mode-2026-02-01",
                AnthropicBetaEnum.FilesApi20250414 => "files-api-2025-04-14",
                AnthropicBetaEnum.InterleavedThinking20250514 => "interleaved-thinking-2025-05-14",
                AnthropicBetaEnum.ManagedAgents20260401 => "managed-agents-2026-04-01",
                AnthropicBetaEnum.McpClient20250404 => "mcp-client-2025-04-04",
                AnthropicBetaEnum.McpClient20251120 => "mcp-client-2025-11-20",
                AnthropicBetaEnum.McpTunnels20260622 => "mcp-tunnels-2026-06-22",
                AnthropicBetaEnum.MessageBatches20240924 => "message-batches-2024-09-24",
                AnthropicBetaEnum.MidConversationToolChanges20260701 => "mid-conversation-tool-changes-2026-07-01",
                AnthropicBetaEnum.ModelContextWindowExceeded20250826 => "model-context-window-exceeded-2025-08-26",
                AnthropicBetaEnum.Output128k20250219 => "output-128k-2025-02-19",
                AnthropicBetaEnum.Output300k20260324 => "output-300k-2026-03-24",
                AnthropicBetaEnum.Pdfs20240925 => "pdfs-2024-09-25",
                AnthropicBetaEnum.PromptCaching20240731 => "prompt-caching-2024-07-31",
                AnthropicBetaEnum.ServerSideFallback20260601 => "server-side-fallback-2026-06-01",
                AnthropicBetaEnum.ServerSideFallback20260701 => "server-side-fallback-2026-07-01",
                AnthropicBetaEnum.Skills20251002 => "skills-2025-10-02",
                AnthropicBetaEnum.StructuredOutputs20251113 => "structured-outputs-2025-11-13",
                AnthropicBetaEnum.TaskBudgets20260313 => "task-budgets-2026-03-13",
                AnthropicBetaEnum.ThinkingDisplayUpdates20260818 => "thinking-display-updates-2026-08-18",
                AnthropicBetaEnum.ThinkingTokenCount20260513 => "thinking-token-count-2026-05-13",
                AnthropicBetaEnum.TokenCounting20241101 => "token-counting-2024-11-01",
                AnthropicBetaEnum.TokenEfficientTools20250219 => "token-efficient-tools-2025-02-19",
                AnthropicBetaEnum.UserProfiles20260324 => "user-profiles-2026-03-24",
                AnthropicBetaEnum.UserProfiles20260818 => "user-profiles-2026-08-18",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBetaEnum? ToEnum(string value)
        {
            return value switch
            {
                "advisor-tool-2026-03-01" => AnthropicBetaEnum.AdvisorTool20260301,
                "agent-memory-2026-07-22" => AnthropicBetaEnum.AgentMemory20260722,
                "cache-diagnosis-2026-04-07" => AnthropicBetaEnum.CacheDiagnosis20260407,
                "ce-user-management-2026-07-13" => AnthropicBetaEnum.CeUserManagement20260713,
                "code-execution-2025-05-22" => AnthropicBetaEnum.CodeExecution20250522,
                "compact-2026-01-12" => AnthropicBetaEnum.Compact20260112,
                "computer-use-2024-10-22" => AnthropicBetaEnum.ComputerUse20241022,
                "computer-use-2025-01-24" => AnthropicBetaEnum.ComputerUse20250124,
                "computer-use-2025-11-24" => AnthropicBetaEnum.ComputerUse20251124,
                "context-1m-2025-08-07" => AnthropicBetaEnum.Context1m20250807,
                "context-management-2025-06-27" => AnthropicBetaEnum.ContextManagement20250627,
                "dev-full-thinking-2025-05-14" => AnthropicBetaEnum.DevFullThinking20250514,
                "dreaming-2026-04-21" => AnthropicBetaEnum.Dreaming20260421,
                "extended-cache-ttl-2025-04-11" => AnthropicBetaEnum.ExtendedCacheTtl20250411,
                "fallback-credit-2026-06-01" => AnthropicBetaEnum.FallbackCredit20260601,
                "fallback-credit-2026-07-01" => AnthropicBetaEnum.FallbackCredit20260701,
                "fast-mode-2026-02-01" => AnthropicBetaEnum.FastMode20260201,
                "files-api-2025-04-14" => AnthropicBetaEnum.FilesApi20250414,
                "interleaved-thinking-2025-05-14" => AnthropicBetaEnum.InterleavedThinking20250514,
                "managed-agents-2026-04-01" => AnthropicBetaEnum.ManagedAgents20260401,
                "mcp-client-2025-04-04" => AnthropicBetaEnum.McpClient20250404,
                "mcp-client-2025-11-20" => AnthropicBetaEnum.McpClient20251120,
                "mcp-tunnels-2026-06-22" => AnthropicBetaEnum.McpTunnels20260622,
                "message-batches-2024-09-24" => AnthropicBetaEnum.MessageBatches20240924,
                "mid-conversation-tool-changes-2026-07-01" => AnthropicBetaEnum.MidConversationToolChanges20260701,
                "model-context-window-exceeded-2025-08-26" => AnthropicBetaEnum.ModelContextWindowExceeded20250826,
                "output-128k-2025-02-19" => AnthropicBetaEnum.Output128k20250219,
                "output-300k-2026-03-24" => AnthropicBetaEnum.Output300k20260324,
                "pdfs-2024-09-25" => AnthropicBetaEnum.Pdfs20240925,
                "prompt-caching-2024-07-31" => AnthropicBetaEnum.PromptCaching20240731,
                "server-side-fallback-2026-06-01" => AnthropicBetaEnum.ServerSideFallback20260601,
                "server-side-fallback-2026-07-01" => AnthropicBetaEnum.ServerSideFallback20260701,
                "skills-2025-10-02" => AnthropicBetaEnum.Skills20251002,
                "structured-outputs-2025-11-13" => AnthropicBetaEnum.StructuredOutputs20251113,
                "task-budgets-2026-03-13" => AnthropicBetaEnum.TaskBudgets20260313,
                "thinking-display-updates-2026-08-18" => AnthropicBetaEnum.ThinkingDisplayUpdates20260818,
                "thinking-token-count-2026-05-13" => AnthropicBetaEnum.ThinkingTokenCount20260513,
                "token-counting-2024-11-01" => AnthropicBetaEnum.TokenCounting20241101,
                "token-efficient-tools-2025-02-19" => AnthropicBetaEnum.TokenEfficientTools20250219,
                "user-profiles-2026-03-24" => AnthropicBetaEnum.UserProfiles20260324,
                "user-profiles-2026-08-18" => AnthropicBetaEnum.UserProfiles20260818,
                _ => null,
            };
        }
    }
}