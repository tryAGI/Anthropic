
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type of the actor that created the object.
    /// </summary>
    public enum BetaCreatedByType
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
    public static class BetaCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCreatedByType value)
        {
            return value switch
            {
                BetaCreatedByType.ServiceAccount => "service_account",
                BetaCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "service_account" => BetaCreatedByType.ServiceAccount,
                "user" => BetaCreatedByType.User,
                _ => null,
            };
        }
    }
}