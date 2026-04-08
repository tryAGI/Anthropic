
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsBranchCheckoutType
    {
        /// <summary>
        /// 
        /// </summary>
        Branch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsBranchCheckoutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsBranchCheckoutType value)
        {
            return value switch
            {
                BetaManagedAgentsBranchCheckoutType.Branch => "branch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsBranchCheckoutType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => BetaManagedAgentsBranchCheckoutType.Branch,
                _ => null,
            };
        }
    }
}