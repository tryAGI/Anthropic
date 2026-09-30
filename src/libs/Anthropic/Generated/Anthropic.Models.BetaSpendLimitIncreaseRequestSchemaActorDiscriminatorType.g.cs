
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType
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
    public static class BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType value)
        {
            return value switch
            {
                BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => BetaSpendLimitIncreaseRequestSchemaActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}