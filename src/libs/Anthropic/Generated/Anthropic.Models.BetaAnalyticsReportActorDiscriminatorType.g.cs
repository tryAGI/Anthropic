
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsReportActorDiscriminatorType
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
    public static class BetaAnalyticsReportActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsReportActorDiscriminatorType value)
        {
            return value switch
            {
                BetaAnalyticsReportActorDiscriminatorType.ApiActor => "api_actor",
                BetaAnalyticsReportActorDiscriminatorType.FederatedActor => "federated_actor",
                BetaAnalyticsReportActorDiscriminatorType.ServiceAccountActor => "service_account_actor",
                BetaAnalyticsReportActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsReportActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaAnalyticsReportActorDiscriminatorType.ApiActor,
                "federated_actor" => BetaAnalyticsReportActorDiscriminatorType.FederatedActor,
                "service_account_actor" => BetaAnalyticsReportActorDiscriminatorType.ServiceAccountActor,
                "user_actor" => BetaAnalyticsReportActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}