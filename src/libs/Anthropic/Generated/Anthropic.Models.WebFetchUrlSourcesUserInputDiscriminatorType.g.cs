
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WebFetchUrlSourcesUserInputDiscriminatorType
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
    public static class WebFetchUrlSourcesUserInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchUrlSourcesUserInputDiscriminatorType value)
        {
            return value switch
            {
                WebFetchUrlSourcesUserInputDiscriminatorType.All => "all",
                WebFetchUrlSourcesUserInputDiscriminatorType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchUrlSourcesUserInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebFetchUrlSourcesUserInputDiscriminatorType.All,
                "none" => WebFetchUrlSourcesUserInputDiscriminatorType.None,
                _ => null,
            };
        }
    }
}