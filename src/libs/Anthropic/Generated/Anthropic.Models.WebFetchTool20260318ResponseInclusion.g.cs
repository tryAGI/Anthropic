
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How this tool's result blocks appear in the API response when the result was consumed by a completed code_execution call in the same turn. 'full' returns the complete content (default). 'excluded' drops the nested server_tool_use and result block pair entirely. Results from direct calls, or from code_execution calls that paused before completing, are always returned in full so they can be sent back on the next turn.
    /// </summary>
    public enum WebFetchTool20260318ResponseInclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Excluded,
        /// <summary>
        /// 
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchTool20260318ResponseInclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchTool20260318ResponseInclusion value)
        {
            return value switch
            {
                WebFetchTool20260318ResponseInclusion.Excluded => "excluded",
                WebFetchTool20260318ResponseInclusion.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchTool20260318ResponseInclusion? ToEnum(string value)
        {
            return value switch
            {
                "excluded" => WebFetchTool20260318ResponseInclusion.Excluded,
                "full" => WebFetchTool20260318ResponseInclusion.Full,
                _ => null,
            };
        }
    }
}