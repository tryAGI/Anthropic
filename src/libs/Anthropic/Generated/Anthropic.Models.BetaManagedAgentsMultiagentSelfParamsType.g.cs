
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMultiagentSelfParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Self,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMultiagentSelfParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMultiagentSelfParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsMultiagentSelfParamsType.Self => "self",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMultiagentSelfParamsType? ToEnum(string value)
        {
            return value switch
            {
                "self" => BetaManagedAgentsMultiagentSelfParamsType.Self,
                _ => null,
            };
        }
    }
}