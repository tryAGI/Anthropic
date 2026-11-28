
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFederationRuleTargetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFederationRuleTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFederationRuleTargetDiscriminatorType value)
        {
            return value switch
            {
                BetaFederationRuleTargetDiscriminatorType.ServiceAccount => "service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFederationRuleTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "service_account" => BetaFederationRuleTargetDiscriminatorType.ServiceAccount,
                _ => null,
            };
        }
    }
}