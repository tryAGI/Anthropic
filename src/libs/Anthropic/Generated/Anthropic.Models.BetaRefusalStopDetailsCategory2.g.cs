
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRefusalStopDetailsCategory2
    {
        /// <summary>
        /// 
        /// </summary>
        Bio,
        /// <summary>
        /// 
        /// </summary>
        Cyber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRefusalStopDetailsCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRefusalStopDetailsCategory2 value)
        {
            return value switch
            {
                BetaRefusalStopDetailsCategory2.Bio => "bio",
                BetaRefusalStopDetailsCategory2.Cyber => "cyber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRefusalStopDetailsCategory2? ToEnum(string value)
        {
            return value switch
            {
                "bio" => BetaRefusalStopDetailsCategory2.Bio,
                "cyber" => BetaRefusalStopDetailsCategory2.Cyber,
                _ => null,
            };
        }
    }
}