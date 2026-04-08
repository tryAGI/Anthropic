
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsRetryStatusDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Exhausted,
        /// <summary>
        /// 
        /// </summary>
        Retrying,
        /// <summary>
        /// 
        /// </summary>
        Terminal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsRetryStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsRetryStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsRetryStatusDiscriminatorType.Exhausted => "exhausted",
                BetaManagedAgentsRetryStatusDiscriminatorType.Retrying => "retrying",
                BetaManagedAgentsRetryStatusDiscriminatorType.Terminal => "terminal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsRetryStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exhausted" => BetaManagedAgentsRetryStatusDiscriminatorType.Exhausted,
                "retrying" => BetaManagedAgentsRetryStatusDiscriminatorType.Retrying,
                "terminal" => BetaManagedAgentsRetryStatusDiscriminatorType.Terminal,
                _ => null,
            };
        }
    }
}