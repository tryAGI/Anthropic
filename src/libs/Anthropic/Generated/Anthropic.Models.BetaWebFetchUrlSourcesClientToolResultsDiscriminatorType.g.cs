
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType
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
    public static class BetaWebFetchUrlSourcesClientToolResultsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType value)
        {
            return value switch
            {
                BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.All => "all",
                BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.Except => "except",
                BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.None => "none",
                BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.All,
                "except" => BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.Except,
                "none" => BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.None,
                "only" => BetaWebFetchUrlSourcesClientToolResultsDiscriminatorType.Only,
                _ => null,
            };
        }
    }
}