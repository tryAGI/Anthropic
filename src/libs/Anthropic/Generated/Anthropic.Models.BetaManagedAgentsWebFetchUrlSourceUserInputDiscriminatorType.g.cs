
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType.All => "all",
                BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType.All,
                "none" => BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType.None,
                _ => null,
            };
        }
    }
}