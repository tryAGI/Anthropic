
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsBillingErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        BillingError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsBillingErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsBillingErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsBillingErrorType.BillingError => "billing_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsBillingErrorType? ToEnum(string value)
        {
            return value switch
            {
                "billing_error" => BetaManagedAgentsBillingErrorType.BillingError,
                _ => null,
            };
        }
    }
}