
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsScheduleDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Cron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsScheduleDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsScheduleDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsScheduleDiscriminatorType.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsScheduleDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => BetaManagedAgentsScheduleDiscriminatorType.Cron,
                _ => null,
            };
        }
    }
}