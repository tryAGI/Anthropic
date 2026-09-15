
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WebFetchUrlSourcesClientToolResultsDiscriminatorType
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
    public static class WebFetchUrlSourcesClientToolResultsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchUrlSourcesClientToolResultsDiscriminatorType value)
        {
            return value switch
            {
                WebFetchUrlSourcesClientToolResultsDiscriminatorType.All => "all",
                WebFetchUrlSourcesClientToolResultsDiscriminatorType.Except => "except",
                WebFetchUrlSourcesClientToolResultsDiscriminatorType.None => "none",
                WebFetchUrlSourcesClientToolResultsDiscriminatorType.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchUrlSourcesClientToolResultsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebFetchUrlSourcesClientToolResultsDiscriminatorType.All,
                "except" => WebFetchUrlSourcesClientToolResultsDiscriminatorType.Except,
                "none" => WebFetchUrlSourcesClientToolResultsDiscriminatorType.None,
                "only" => WebFetchUrlSourcesClientToolResultsDiscriminatorType.Only,
                _ => null,
            };
        }
    }
}