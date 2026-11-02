
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendLimitIncreaseRequestActorDiscriminatorType
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
    public static class SpendLimitIncreaseRequestActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitIncreaseRequestActorDiscriminatorType value)
        {
            return value switch
            {
                SpendLimitIncreaseRequestActorDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                SpendLimitIncreaseRequestActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitIncreaseRequestActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => SpendLimitIncreaseRequestActorDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => SpendLimitIncreaseRequestActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}