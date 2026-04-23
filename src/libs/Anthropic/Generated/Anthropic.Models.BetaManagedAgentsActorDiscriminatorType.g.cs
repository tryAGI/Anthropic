
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsActorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiActor,
        /// <summary>
        /// 
        /// </summary>
        SessionActor,
        /// <summary>
        /// 
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsActorDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsActorDiscriminatorType.ApiActor => "api_actor",
                BetaManagedAgentsActorDiscriminatorType.SessionActor => "session_actor",
                BetaManagedAgentsActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaManagedAgentsActorDiscriminatorType.ApiActor,
                "session_actor" => BetaManagedAgentsActorDiscriminatorType.SessionActor,
                "user_actor" => BetaManagedAgentsActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}