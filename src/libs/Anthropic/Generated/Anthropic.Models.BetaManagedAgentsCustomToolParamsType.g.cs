
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCustomToolParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCustomToolParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCustomToolParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsCustomToolParamsType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCustomToolParamsType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaManagedAgentsCustomToolParamsType.Custom,
                _ => null,
            };
        }
    }
}