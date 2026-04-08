
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeleteSessionResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionResourceDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeleteSessionResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeleteSessionResourceType value)
        {
            return value switch
            {
                BetaManagedAgentsDeleteSessionResourceType.SessionResourceDeleted => "session_resource_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeleteSessionResourceType? ToEnum(string value)
        {
            return value switch
            {
                "session_resource_deleted" => BetaManagedAgentsDeleteSessionResourceType.SessionResourceDeleted,
                _ => null,
            };
        }
    }
}