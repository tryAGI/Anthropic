
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType
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
    public static class BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType.ScopedApiKeyActor,
                "user_actor" => BetaApproveSpendLimitIncreaseRequestResponseResolvedByVariant1DiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}