
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMultiagentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Coordinator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMultiagentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentDiscriminatorType.Coordinator => "coordinator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "coordinator" => BetaManagedAgentsMultiagentDiscriminatorType.Coordinator,
                _ => null,
            };
        }
    }
}