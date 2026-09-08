
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType
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
    public static class BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType.ScopedApiKeyActor,
                "user_actor" => BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}