
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionDeletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionDeletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionDeletedEventType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionDeletedEventType.SessionDeleted => "session.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionDeletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.deleted" => BetaManagedAgentsSessionDeletedEventType.SessionDeleted,
                _ => null,
            };
        }
    }
}