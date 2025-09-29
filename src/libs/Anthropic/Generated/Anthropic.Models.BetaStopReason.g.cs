
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaStopReason
    {
        /// <summary>
        /// 
        /// </summary>
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
        /// <summary>
        /// 
        /// </summary>
        PauseTurn,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
        /// <summary>
        /// 
        /// </summary>
        ModelContextWindowExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaStopReason value)
        {
            return value switch
            {
                BetaStopReason.EndTurn => "end_turn",
                BetaStopReason.MaxTokens => "max_tokens",
                BetaStopReason.StopSequence => "stop_sequence",
                BetaStopReason.ToolUse => "tool_use",
                BetaStopReason.PauseTurn => "pause_turn",
                BetaStopReason.Refusal => "refusal",
                BetaStopReason.ModelContextWindowExceeded => "model_context_window_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaStopReason.EndTurn,
                "max_tokens" => BetaStopReason.MaxTokens,
                "stop_sequence" => BetaStopReason.StopSequence,
                "tool_use" => BetaStopReason.ToolUse,
                "pause_turn" => BetaStopReason.PauseTurn,
                "refusal" => BetaStopReason.Refusal,
                "model_context_window_exceeded" => BetaStopReason.ModelContextWindowExceeded,
                _ => null,
            };
        }
    }
}