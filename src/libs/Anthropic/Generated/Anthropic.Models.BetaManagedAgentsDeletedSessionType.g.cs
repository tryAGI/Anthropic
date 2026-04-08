
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeletedSessionType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeletedSessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeletedSessionType value)
        {
            return value switch
            {
                BetaManagedAgentsDeletedSessionType.SessionDeleted => "session_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeletedSessionType? ToEnum(string value)
        {
            return value switch
            {
                "session_deleted" => BetaManagedAgentsDeletedSessionType.SessionDeleted,
                _ => null,
            };
        }
    }
}