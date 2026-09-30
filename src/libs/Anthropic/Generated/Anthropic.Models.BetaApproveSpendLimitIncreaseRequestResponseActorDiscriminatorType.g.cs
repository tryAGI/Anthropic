
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ScopedApiKeyActor,
        /// <summary>
        ///
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType value)
        {
            return value switch
            {
                BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}