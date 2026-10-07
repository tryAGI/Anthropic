
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Except,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Only,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.All => "all",
                BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.Except => "except",
                BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.None => "none",
                BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.All,
                "except" => BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.Except,
                "none" => BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.None,
                "only" => BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType.Only,
                _ => null,
            };
        }
    }
}