
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BetaManagedAgentsAgentUnionParamsVariant2DiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}