
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of the actor that created the object.
    /// </summary>
    public enum CreatedByType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceAccount,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedByType value)
        {
            return value switch
            {
                CreatedByType.ServiceAccount => "service_account",
                CreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "service_account" => CreatedByType.ServiceAccount,
                "user" => CreatedByType.User,
                _ => null,
            };
        }
    }
}