
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsFileNotFoundRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        FileNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsFileNotFoundRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsFileNotFoundRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsFileNotFoundRunErrorType.FileNotFoundError => "file_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsFileNotFoundRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "file_not_found_error" => BetaManagedAgentsFileNotFoundRunErrorType.FileNotFoundError,
                _ => null,
            };
        }
    }
}