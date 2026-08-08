
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestMidConvSystemBlockContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestMidConvSystemBlockContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestMidConvSystemBlockContentItemDiscriminatorType value)
        {
            return value switch
            {
                RequestMidConvSystemBlockContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestMidConvSystemBlockContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => RequestMidConvSystemBlockContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}