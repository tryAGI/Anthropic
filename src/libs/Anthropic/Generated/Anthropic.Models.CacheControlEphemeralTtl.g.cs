
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
    public enum CacheControlEphemeralTtl
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
    public static class CacheControlEphemeralTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CacheControlEphemeralTtl value)
        {
            return value switch
            {
                CacheControlEphemeralTtl.x5m => "5m",
                CacheControlEphemeralTtl.x1h => "1h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CacheControlEphemeralTtl? ToEnum(string value)
        {
            return value switch
            {
                "5m" => CacheControlEphemeralTtl.x5m,
                "1h" => CacheControlEphemeralTtl.x1h,
                _ => null,
            };
        }
    }
}