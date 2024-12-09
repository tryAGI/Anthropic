
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The reason that we stopped.<br/>
    /// This may be one the following values:<br/>
    /// * `"end_turn"`: the model reached a natural stopping point<br/>
    /// * `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
    /// * `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
    /// * `"tool_use"`: the model invoked one or more tools<br/>
    /// In non-streaming mode this value is always non-null. In streaming mode, it is null in the `message_start` event and non-null otherwise.
    /// </summary>
    public enum MessageStopReason
    {
        /// <summary>
        /// the model reached a natural stopping point
        /// </summary>
        EndTurn,
        /// <summary>
        /// we exceeded the requested `max_tokens` or the model's maximum
        /// </summary>
        MaxTokens,
        /// <summary>
        /// one of your provided custom `stop_sequences` was generated
        /// </summary>
        StopSequence,
        /// <summary>
        /// the model invoked one or more tools
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStopReason value)
        {
            return value switch
            {
                MessageStopReason.EndTurn => "end_turn",
                MessageStopReason.MaxTokens => "max_tokens",
                MessageStopReason.StopSequence => "stop_sequence",
                MessageStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessageStopReason.EndTurn,
                "max_tokens" => MessageStopReason.MaxTokens,
                "stop_sequence" => MessageStopReason.StopSequence,
                "tool_use" => MessageStopReason.ToolUse,
                _ => null,
            };
        }
    }
}