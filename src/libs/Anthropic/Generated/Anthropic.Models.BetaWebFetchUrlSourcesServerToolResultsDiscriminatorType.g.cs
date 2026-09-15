
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType
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
    public static class BetaWebFetchUrlSourcesServerToolResultsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType value)
        {
            return value switch
            {
                BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.All => "all",
                BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.Except => "except",
                BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.None => "none",
                BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.All,
                "except" => BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.Except,
                "none" => BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.None,
                "only" => BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType.Only,
                _ => null,
            };
        }
    }
}