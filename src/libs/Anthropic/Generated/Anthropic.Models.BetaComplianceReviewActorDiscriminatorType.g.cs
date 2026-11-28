
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewActorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ApiActor,
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
    public static class BetaComplianceReviewActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewActorDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceReviewActorDiscriminatorType.ApiActor => "api_actor",
                BetaComplianceReviewActorDiscriminatorType.ServiceAccountActor => "service_account_actor",
                BetaComplianceReviewActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaComplianceReviewActorDiscriminatorType.ApiActor,
                "service_account_actor" => BetaComplianceReviewActorDiscriminatorType.ServiceAccountActor,
                "user_actor" => BetaComplianceReviewActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}