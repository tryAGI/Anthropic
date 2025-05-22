
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The time-to-live for the cache control breakpoint.<br/>
    /// This may be one the following values:<br/>
    /// - `5m`: 5 minutes<br/>
    /// - `1h`: 1 hour<br/>
    /// Defaults to `5m`.
    /// </summary>
    public enum BetaCacheControlEphemeralTtl
    {
        /// <summary>
        /// 5 minutes
        /// </summary>
        x5m,
        /// <summary>
        /// 1 hour
        /// </summary>
        x1h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCacheControlEphemeralTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCacheControlEphemeralTtl value)
        {
            return value switch
            {
                BetaCacheControlEphemeralTtl.x5m => "5m",
                BetaCacheControlEphemeralTtl.x1h => "1h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCacheControlEphemeralTtl? ToEnum(string value)
        {
            return value switch
            {
                "5m" => BetaCacheControlEphemeralTtl.x5m,
                "1h" => BetaCacheControlEphemeralTtl.x1h,
                _ => null,
            };
        }
    }
}