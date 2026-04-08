
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsStaticBearerUpdateParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        StaticBearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsStaticBearerUpdateParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsStaticBearerUpdateParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsStaticBearerUpdateParamsType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsStaticBearerUpdateParamsType? ToEnum(string value)
        {
            return value switch
            {
                "static_bearer" => BetaManagedAgentsStaticBearerUpdateParamsType.StaticBearer,
                _ => null,
            };
        }
    }
}