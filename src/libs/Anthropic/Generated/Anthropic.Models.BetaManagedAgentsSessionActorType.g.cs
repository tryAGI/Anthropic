
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionActorType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionActorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionActorType.SessionActor => "session_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionActorType? ToEnum(string value)
        {
            return value switch
            {
                "session_actor" => BetaManagedAgentsSessionActorType.SessionActor,
                _ => null,
            };
        }
    }
}