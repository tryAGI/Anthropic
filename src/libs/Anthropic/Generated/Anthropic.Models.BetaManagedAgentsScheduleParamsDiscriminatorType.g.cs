
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsScheduleParamsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Cron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsScheduleParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsScheduleParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsScheduleParamsDiscriminatorType.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsScheduleParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => BetaManagedAgentsScheduleParamsDiscriminatorType.Cron,
                _ => null,
            };
        }
    }
}