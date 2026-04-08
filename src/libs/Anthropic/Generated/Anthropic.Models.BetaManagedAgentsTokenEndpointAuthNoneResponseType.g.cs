
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsTokenEndpointAuthNoneResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsTokenEndpointAuthNoneResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTokenEndpointAuthNoneResponseType value)
        {
            return value switch
            {
                BetaManagedAgentsTokenEndpointAuthNoneResponseType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTokenEndpointAuthNoneResponseType? ToEnum(string value)
        {
            return value switch
            {
                "none" => BetaManagedAgentsTokenEndpointAuthNoneResponseType.None,
                _ => null,
            };
        }
    }
}