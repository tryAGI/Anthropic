
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsStaticBearerAuthResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        StaticBearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsStaticBearerAuthResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsStaticBearerAuthResponseType value)
        {
            return value switch
            {
                BetaManagedAgentsStaticBearerAuthResponseType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsStaticBearerAuthResponseType? ToEnum(string value)
        {
            return value switch
            {
                "static_bearer" => BetaManagedAgentsStaticBearerAuthResponseType.StaticBearer,
                _ => null,
            };
        }
    }
}