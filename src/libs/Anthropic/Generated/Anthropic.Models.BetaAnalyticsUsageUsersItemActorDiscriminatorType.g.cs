
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsUsageUsersItemActorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsUsageUsersItemActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageUsersItemActorDiscriminatorType value)
        {
            return value switch
            {
                BetaAnalyticsUsageUsersItemActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageUsersItemActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "user_actor" => BetaAnalyticsUsageUsersItemActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}