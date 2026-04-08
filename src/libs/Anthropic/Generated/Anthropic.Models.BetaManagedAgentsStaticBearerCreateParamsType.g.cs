
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsStaticBearerCreateParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        StaticBearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsStaticBearerCreateParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsStaticBearerCreateParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsStaticBearerCreateParamsType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsStaticBearerCreateParamsType? ToEnum(string value)
        {
            return value switch
            {
                "static_bearer" => BetaManagedAgentsStaticBearerCreateParamsType.StaticBearer,
                _ => null,
            };
        }
    }
}