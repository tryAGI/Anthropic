
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopReason
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopReason value)
        {
            return value switch
            {
                StopReason.EndTurn => "end_turn",
                StopReason.MaxTokens => "max_tokens",
                StopReason.StopSequence => "stop_sequence",
                StopReason.ToolUse => "tool_use",
                StopReason.PauseTurn => "pause_turn",
                StopReason.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => StopReason.EndTurn,
                "max_tokens" => StopReason.MaxTokens,
                "stop_sequence" => StopReason.StopSequence,
                "tool_use" => StopReason.ToolUse,
                "pause_turn" => StopReason.PauseTurn,
                "refusal" => StopReason.Refusal,
                _ => null,
            };
        }
    }
}