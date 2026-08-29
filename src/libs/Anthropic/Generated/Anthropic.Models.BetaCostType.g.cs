
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCostType
    {
        /// <summary>
        ///
        /// </summary>
        CodeExecution,
        /// <summary>
        ///
        /// </summary>
        SessionUsage,
        /// <summary>
        ///
        /// </summary>
        Tokens,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCostType value)
        {
            return value switch
            {
                BetaCostType.CodeExecution => "code_execution",
                BetaCostType.SessionUsage => "session_usage",
                BetaCostType.Tokens => "tokens",
                BetaCostType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCostType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution" => BetaCostType.CodeExecution,
                "session_usage" => BetaCostType.SessionUsage,
                "tokens" => BetaCostType.Tokens,
                "web_search" => BetaCostType.WebSearch,
                _ => null,
            };
        }
    }
}