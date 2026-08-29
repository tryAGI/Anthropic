
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCustomerType
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCustomerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCustomerType value)
        {
            return value switch
            {
                BetaCustomerType.Api => "api",
                BetaCustomerType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCustomerType? ToEnum(string value)
        {
            return value switch
            {
                "api" => BetaCustomerType.Api,
                "subscription" => BetaCustomerType.Subscription,
                _ => null,
            };
        }
    }
}