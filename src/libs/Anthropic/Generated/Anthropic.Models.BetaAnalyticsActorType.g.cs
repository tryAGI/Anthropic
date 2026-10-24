
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Kind of identity a row's usage is attributed to.
    /// </summary>
    public enum BetaAnalyticsActorType
    {
        /// <summary>
        ///
        /// </summary>
        ApiActor,
        /// <summary>
        ///
        /// </summary>
        FederatedActor,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountActor,
        /// <summary>
        ///
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsActorType value)
        {
            return value switch
            {
                BetaAnalyticsActorType.ApiActor => "api_actor",
                BetaAnalyticsActorType.FederatedActor => "federated_actor",
                BetaAnalyticsActorType.ServiceAccountActor => "service_account_actor",
                BetaAnalyticsActorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsActorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaAnalyticsActorType.ApiActor,
                "federated_actor" => BetaAnalyticsActorType.FederatedActor,
                "service_account_actor" => BetaAnalyticsActorType.ServiceAccountActor,
                "user_actor" => BetaAnalyticsActorType.UserActor,
                _ => null,
            };
        }
    }
}