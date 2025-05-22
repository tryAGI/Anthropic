
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
        MessageBatches20240924,
        /// <summary>
        /// 
        /// </summary>
        PromptCaching20240731,
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
        Pdfs20240925,
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
        Output128k20250219,
        /// <summary>
        /// 
        /// </summary>
        FilesApi20250414,
        /// <summary>
        /// 
        /// </summary>
        McpClient20250404,
        /// <summary>
        /// 
        /// </summary>
        DevFullThinking20250514,
        /// <summary>
        /// 
        /// </summary>
        InterleavedThinking20250514,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution20250522,
        /// <summary>
        /// 
        /// </summary>
        ExtendedCacheTtl20250411,
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
                AnthropicBetaEnum.MessageBatches20240924 => "message-batches-2024-09-24",
                AnthropicBetaEnum.PromptCaching20240731 => "prompt-caching-2024-07-31",
                AnthropicBetaEnum.ComputerUse20241022 => "computer-use-2024-10-22",
                AnthropicBetaEnum.ComputerUse20250124 => "computer-use-2025-01-24",
                AnthropicBetaEnum.Pdfs20240925 => "pdfs-2024-09-25",
                AnthropicBetaEnum.TokenCounting20241101 => "token-counting-2024-11-01",
                AnthropicBetaEnum.TokenEfficientTools20250219 => "token-efficient-tools-2025-02-19",
                AnthropicBetaEnum.Output128k20250219 => "output-128k-2025-02-19",
                AnthropicBetaEnum.FilesApi20250414 => "files-api-2025-04-14",
                AnthropicBetaEnum.McpClient20250404 => "mcp-client-2025-04-04",
                AnthropicBetaEnum.DevFullThinking20250514 => "dev-full-thinking-2025-05-14",
                AnthropicBetaEnum.InterleavedThinking20250514 => "interleaved-thinking-2025-05-14",
                AnthropicBetaEnum.CodeExecution20250522 => "code-execution-2025-05-22",
                AnthropicBetaEnum.ExtendedCacheTtl20250411 => "extended-cache-ttl-2025-04-11",
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
                "message-batches-2024-09-24" => AnthropicBetaEnum.MessageBatches20240924,
                "prompt-caching-2024-07-31" => AnthropicBetaEnum.PromptCaching20240731,
                "computer-use-2024-10-22" => AnthropicBetaEnum.ComputerUse20241022,
                "computer-use-2025-01-24" => AnthropicBetaEnum.ComputerUse20250124,
                "pdfs-2024-09-25" => AnthropicBetaEnum.Pdfs20240925,
                "token-counting-2024-11-01" => AnthropicBetaEnum.TokenCounting20241101,
                "token-efficient-tools-2025-02-19" => AnthropicBetaEnum.TokenEfficientTools20250219,
                "output-128k-2025-02-19" => AnthropicBetaEnum.Output128k20250219,
                "files-api-2025-04-14" => AnthropicBetaEnum.FilesApi20250414,
                "mcp-client-2025-04-04" => AnthropicBetaEnum.McpClient20250404,
                "dev-full-thinking-2025-05-14" => AnthropicBetaEnum.DevFullThinking20250514,
                "interleaved-thinking-2025-05-14" => AnthropicBetaEnum.InterleavedThinking20250514,
                "code-execution-2025-05-22" => AnthropicBetaEnum.CodeExecution20250522,
                "extended-cache-ttl-2025-04-11" => AnthropicBetaEnum.ExtendedCacheTtl20250411,
                _ => null,
            };
        }
    }
}