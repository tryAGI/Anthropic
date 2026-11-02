
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendSummaryActorDiscriminatorType
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
    public static class SpendSummaryActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendSummaryActorDiscriminatorType value)
        {
            return value switch
            {
                SpendSummaryActorDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                SpendSummaryActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendSummaryActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => SpendSummaryActorDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => SpendSummaryActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}