
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsFederatedActorProviderDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
        /// <summary>
        ///
        /// </summary>
        Azure,
        /// <summary>
        ///
        /// </summary>
        Gcp,
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsFederatedActorProviderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsFederatedActorProviderDiscriminatorType value)
        {
            return value switch
            {
                BetaAnalyticsFederatedActorProviderDiscriminatorType.Aws => "aws",
                BetaAnalyticsFederatedActorProviderDiscriminatorType.Azure => "azure",
                BetaAnalyticsFederatedActorProviderDiscriminatorType.Gcp => "gcp",
                BetaAnalyticsFederatedActorProviderDiscriminatorType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsFederatedActorProviderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => BetaAnalyticsFederatedActorProviderDiscriminatorType.Aws,
                "azure" => BetaAnalyticsFederatedActorProviderDiscriminatorType.Azure,
                "gcp" => BetaAnalyticsFederatedActorProviderDiscriminatorType.Gcp,
                "oidc" => BetaAnalyticsFederatedActorProviderDiscriminatorType.Oidc,
                _ => null,
            };
        }
    }
}