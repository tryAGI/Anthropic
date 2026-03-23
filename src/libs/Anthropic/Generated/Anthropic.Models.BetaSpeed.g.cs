
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpeed value)
        {
            return value switch
            {
                BetaSpeed.Fast => "fast",
                BetaSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaSpeed.Fast,
                "standard" => BetaSpeed.Standard,
                _ => null,
            };
        }
    }
}