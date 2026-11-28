
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum FederationRuleTargetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FederationRuleTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FederationRuleTargetDiscriminatorType value)
        {
            return value switch
            {
                FederationRuleTargetDiscriminatorType.ServiceAccount => "service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FederationRuleTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "service_account" => FederationRuleTargetDiscriminatorType.ServiceAccount,
                _ => null,
            };
        }
    }
}