
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
        CodeExecution20250522,
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
        ExtendedCacheTtl20250411,
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
        McpClient20250404,
        /// <summary>
        /// 
        /// </summary>
        McpClient20251120,
        /// <summary>
        /// 
        /// </summary>
        MessageBatches20240924,
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
        Skills20251002,
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
                AnthropicBetaEnum.CodeExecution20250522 => "code-execution-2025-05-22",
                AnthropicBetaEnum.ComputerUse20241022 => "computer-use-2024-10-22",
                AnthropicBetaEnum.ComputerUse20250124 => "computer-use-2025-01-24",
                AnthropicBetaEnum.Context1m20250807 => "context-1m-2025-08-07",
                AnthropicBetaEnum.ContextManagement20250627 => "context-management-2025-06-27",
                AnthropicBetaEnum.DevFullThinking20250514 => "dev-full-thinking-2025-05-14",
                AnthropicBetaEnum.ExtendedCacheTtl20250411 => "extended-cache-ttl-2025-04-11",
                AnthropicBetaEnum.FastMode20260201 => "fast-mode-2026-02-01",
                AnthropicBetaEnum.FilesApi20250414 => "files-api-2025-04-14",
                AnthropicBetaEnum.InterleavedThinking20250514 => "interleaved-thinking-2025-05-14",
                AnthropicBetaEnum.McpClient20250404 => "mcp-client-2025-04-04",
                AnthropicBetaEnum.McpClient20251120 => "mcp-client-2025-11-20",
                AnthropicBetaEnum.MessageBatches20240924 => "message-batches-2024-09-24",
                AnthropicBetaEnum.ModelContextWindowExceeded20250826 => "model-context-window-exceeded-2025-08-26",
                AnthropicBetaEnum.Output128k20250219 => "output-128k-2025-02-19",
                AnthropicBetaEnum.Output300k20260324 => "output-300k-2026-03-24",
                AnthropicBetaEnum.Pdfs20240925 => "pdfs-2024-09-25",
                AnthropicBetaEnum.PromptCaching20240731 => "prompt-caching-2024-07-31",
                AnthropicBetaEnum.Skills20251002 => "skills-2025-10-02",
                AnthropicBetaEnum.TokenCounting20241101 => "token-counting-2024-11-01",
                AnthropicBetaEnum.TokenEfficientTools20250219 => "token-efficient-tools-2025-02-19",
                AnthropicBetaEnum.UserProfiles20260324 => "user-profiles-2026-03-24",
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
                "code-execution-2025-05-22" => AnthropicBetaEnum.CodeExecution20250522,
                "computer-use-2024-10-22" => AnthropicBetaEnum.ComputerUse20241022,
                "computer-use-2025-01-24" => AnthropicBetaEnum.ComputerUse20250124,
                "context-1m-2025-08-07" => AnthropicBetaEnum.Context1m20250807,
                "context-management-2025-06-27" => AnthropicBetaEnum.ContextManagement20250627,
                "dev-full-thinking-2025-05-14" => AnthropicBetaEnum.DevFullThinking20250514,
                "extended-cache-ttl-2025-04-11" => AnthropicBetaEnum.ExtendedCacheTtl20250411,
                "fast-mode-2026-02-01" => AnthropicBetaEnum.FastMode20260201,
                "files-api-2025-04-14" => AnthropicBetaEnum.FilesApi20250414,
                "interleaved-thinking-2025-05-14" => AnthropicBetaEnum.InterleavedThinking20250514,
                "mcp-client-2025-04-04" => AnthropicBetaEnum.McpClient20250404,
                "mcp-client-2025-11-20" => AnthropicBetaEnum.McpClient20251120,
                "message-batches-2024-09-24" => AnthropicBetaEnum.MessageBatches20240924,
                "model-context-window-exceeded-2025-08-26" => AnthropicBetaEnum.ModelContextWindowExceeded20250826,
                "output-128k-2025-02-19" => AnthropicBetaEnum.Output128k20250219,
                "output-300k-2026-03-24" => AnthropicBetaEnum.Output300k20260324,
                "pdfs-2024-09-25" => AnthropicBetaEnum.Pdfs20240925,
                "prompt-caching-2024-07-31" => AnthropicBetaEnum.PromptCaching20240731,
                "skills-2025-10-02" => AnthropicBetaEnum.Skills20251002,
                "token-counting-2024-11-01" => AnthropicBetaEnum.TokenCounting20241101,
                "token-efficient-tools-2025-02-19" => AnthropicBetaEnum.TokenEfficientTools20250219,
                "user-profiles-2026-03-24" => AnthropicBetaEnum.UserProfiles20260324,
                _ => null,
            };
        }
    }
}