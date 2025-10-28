
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaClearThinking20251015Keep
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClearThinking20251015KeepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClearThinking20251015Keep value)
        {
            return value switch
            {
                BetaClearThinking20251015Keep.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClearThinking20251015Keep? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaClearThinking20251015Keep.All,
                _ => null,
            };
        }
    }
}