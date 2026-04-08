
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsRetryStatusRetryingType
    {
        /// <summary>
        /// 
        /// </summary>
        Retrying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsRetryStatusRetryingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsRetryStatusRetryingType value)
        {
            return value switch
            {
                BetaManagedAgentsRetryStatusRetryingType.Retrying => "retrying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsRetryStatusRetryingType? ToEnum(string value)
        {
            return value switch
            {
                "retrying" => BetaManagedAgentsRetryStatusRetryingType.Retrying,
                _ => null,
            };
        }
    }
}