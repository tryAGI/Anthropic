
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWebFetchUrlSourcesUserInputDiscriminatorType
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
    public static class BetaWebFetchUrlSourcesUserInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchUrlSourcesUserInputDiscriminatorType value)
        {
            return value switch
            {
                BetaWebFetchUrlSourcesUserInputDiscriminatorType.All => "all",
                BetaWebFetchUrlSourcesUserInputDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchUrlSourcesUserInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaWebFetchUrlSourcesUserInputDiscriminatorType.All,
                "none" => BetaWebFetchUrlSourcesUserInputDiscriminatorType.None,
                _ => null,
            };
        }
    }
}