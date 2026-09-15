
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WebFetchUrlSourcesServerToolResultsDiscriminatorType
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
    public static class WebFetchUrlSourcesServerToolResultsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchUrlSourcesServerToolResultsDiscriminatorType value)
        {
            return value switch
            {
                WebFetchUrlSourcesServerToolResultsDiscriminatorType.All => "all",
                WebFetchUrlSourcesServerToolResultsDiscriminatorType.Except => "except",
                WebFetchUrlSourcesServerToolResultsDiscriminatorType.None => "none",
                WebFetchUrlSourcesServerToolResultsDiscriminatorType.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchUrlSourcesServerToolResultsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebFetchUrlSourcesServerToolResultsDiscriminatorType.All,
                "except" => WebFetchUrlSourcesServerToolResultsDiscriminatorType.Except,
                "none" => WebFetchUrlSourcesServerToolResultsDiscriminatorType.None,
                "only" => WebFetchUrlSourcesServerToolResultsDiscriminatorType.Only,
                _ => null,
            };
        }
    }
}