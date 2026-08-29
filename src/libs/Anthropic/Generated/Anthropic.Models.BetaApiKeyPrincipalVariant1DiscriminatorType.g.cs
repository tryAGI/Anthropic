
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApiKeyPrincipalVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceAccountActor,
        /// <summary>
        ///
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApiKeyPrincipalVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApiKeyPrincipalVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaApiKeyPrincipalVariant1DiscriminatorType.ServiceAccountActor => "service_account_actor",
                BetaApiKeyPrincipalVariant1DiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApiKeyPrincipalVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "service_account_actor" => BetaApiKeyPrincipalVariant1DiscriminatorType.ServiceAccountActor,
                "user_actor" => BetaApiKeyPrincipalVariant1DiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}