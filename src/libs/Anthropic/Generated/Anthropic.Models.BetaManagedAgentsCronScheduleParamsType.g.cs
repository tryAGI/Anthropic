
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCronScheduleParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Cron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCronScheduleParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCronScheduleParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsCronScheduleParamsType.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCronScheduleParamsType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => BetaManagedAgentsCronScheduleParamsType.Cron,
                _ => null,
            };
        }
    }
}