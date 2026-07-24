
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFallbackCreditUsageStatusDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        NotApplied,
        /// <summary>
        /// 
        /// </summary>
        Redeemed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFallbackCreditUsageStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFallbackCreditUsageStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaFallbackCreditUsageStatusDiscriminatorType.NotApplied => "not_applied",
                BetaFallbackCreditUsageStatusDiscriminatorType.Redeemed => "redeemed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFallbackCreditUsageStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "not_applied" => BetaFallbackCreditUsageStatusDiscriminatorType.NotApplied,
                "redeemed" => BetaFallbackCreditUsageStatusDiscriminatorType.Redeemed,
                _ => null,
            };
        }
    }
}