
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitIncreaseRequestActorDiscriminatorType
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
    public static class BetaSpendLimitIncreaseRequestActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitIncreaseRequestActorDiscriminatorType value)
        {
            return value switch
            {
                BetaSpendLimitIncreaseRequestActorDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                BetaSpendLimitIncreaseRequestActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitIncreaseRequestActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => BetaSpendLimitIncreaseRequestActorDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => BetaSpendLimitIncreaseRequestActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}