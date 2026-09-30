
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginOwnerDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginOwnerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginOwnerDiscriminatorType value)
        {
            return value switch
            {
                BetaPluginOwnerDiscriminatorType.Organization => "organization",
                BetaPluginOwnerDiscriminatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginOwnerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaPluginOwnerDiscriminatorType.Organization,
                "user" => BetaPluginOwnerDiscriminatorType.User,
                _ => null,
            };
        }
    }
}