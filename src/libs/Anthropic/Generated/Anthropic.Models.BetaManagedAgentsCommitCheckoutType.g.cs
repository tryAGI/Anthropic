
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCommitCheckoutType
    {
        /// <summary>
        /// 
        /// </summary>
        Commit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCommitCheckoutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCommitCheckoutType value)
        {
            return value switch
            {
                BetaManagedAgentsCommitCheckoutType.Commit => "commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCommitCheckoutType? ToEnum(string value)
        {
            return value switch
            {
                "commit" => BetaManagedAgentsCommitCheckoutType.Commit,
                _ => null,
            };
        }
    }
}