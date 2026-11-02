
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendLimitIncreaseRequestResolvedByDiscriminatorType
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
    public static class SpendLimitIncreaseRequestResolvedByDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitIncreaseRequestResolvedByDiscriminatorType value)
        {
            return value switch
            {
                SpendLimitIncreaseRequestResolvedByDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                SpendLimitIncreaseRequestResolvedByDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitIncreaseRequestResolvedByDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => SpendLimitIncreaseRequestResolvedByDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => SpendLimitIncreaseRequestResolvedByDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}