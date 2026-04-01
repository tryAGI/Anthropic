
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RefusalStopDetailsCategory2
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
    public static class RefusalStopDetailsCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefusalStopDetailsCategory2 value)
        {
            return value switch
            {
                RefusalStopDetailsCategory2.Bio => "bio",
                RefusalStopDetailsCategory2.Cyber => "cyber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefusalStopDetailsCategory2? ToEnum(string value)
        {
            return value switch
            {
                "bio" => RefusalStopDetailsCategory2.Bio,
                "cyber" => RefusalStopDetailsCategory2.Cyber,
                _ => null,
            };
        }
    }
}