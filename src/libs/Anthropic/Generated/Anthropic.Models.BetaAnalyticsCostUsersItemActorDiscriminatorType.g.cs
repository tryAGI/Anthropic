
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsCostUsersItemActorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsCostUsersItemActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsCostUsersItemActorDiscriminatorType value)
        {
            return value switch
            {
                BetaAnalyticsCostUsersItemActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsCostUsersItemActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "user_actor" => BetaAnalyticsCostUsersItemActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}