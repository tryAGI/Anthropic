
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsImageSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsImageSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsImageSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsImageSourceDiscriminatorType.Base64 => "base64",
                BetaManagedAgentsImageSourceDiscriminatorType.File => "file",
                BetaManagedAgentsImageSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsImageSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaManagedAgentsImageSourceDiscriminatorType.Base64,
                "file" => BetaManagedAgentsImageSourceDiscriminatorType.File,
                "url" => BetaManagedAgentsImageSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}