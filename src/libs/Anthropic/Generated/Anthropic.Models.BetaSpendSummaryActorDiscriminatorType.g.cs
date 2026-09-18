
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSpendSummaryActorDiscriminatorType
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
    public static class BetaSpendSummaryActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSpendSummaryActorDiscriminatorType value)
        {
            return value switch
            {
                BetaSpendSummaryActorDiscriminatorType.ScopedApiKeyActor => "scoped_api_key_actor",
                BetaSpendSummaryActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSpendSummaryActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "scoped_api_key_actor" => BetaSpendSummaryActorDiscriminatorType.ScopedApiKeyActor,
                "user_actor" => BetaSpendSummaryActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}