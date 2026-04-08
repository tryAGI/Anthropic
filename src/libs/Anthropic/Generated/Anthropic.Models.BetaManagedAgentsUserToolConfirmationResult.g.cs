
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// UserToolConfirmationResult enum
    /// </summary>
    public enum BetaManagedAgentsUserToolConfirmationResult
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUserToolConfirmationResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserToolConfirmationResult value)
        {
            return value switch
            {
                BetaManagedAgentsUserToolConfirmationResult.Allow => "allow",
                BetaManagedAgentsUserToolConfirmationResult.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserToolConfirmationResult? ToEnum(string value)
        {
            return value switch
            {
                "allow" => BetaManagedAgentsUserToolConfirmationResult.Allow,
                "deny" => BetaManagedAgentsUserToolConfirmationResult.Deny,
                _ => null,
            };
        }
    }
}