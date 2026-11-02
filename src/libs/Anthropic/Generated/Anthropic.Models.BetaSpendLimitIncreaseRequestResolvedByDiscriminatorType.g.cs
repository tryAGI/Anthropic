
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType
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
    public static class BetaSpendLimitIncreaseRequestResolvedByDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType value)
        {
            return value switch
            {
                BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => BetaSpendLimitIncreaseRequestResolvedByDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}