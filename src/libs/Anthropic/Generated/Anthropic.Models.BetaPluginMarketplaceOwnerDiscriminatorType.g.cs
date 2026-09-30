
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginMarketplaceOwnerDiscriminatorType
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
    public static class BetaPluginMarketplaceOwnerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginMarketplaceOwnerDiscriminatorType value)
        {
            return value switch
            {
                BetaPluginMarketplaceOwnerDiscriminatorType.Organization => "organization",
                BetaPluginMarketplaceOwnerDiscriminatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginMarketplaceOwnerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaPluginMarketplaceOwnerDiscriminatorType.Organization,
                "user" => BetaPluginMarketplaceOwnerDiscriminatorType.User,
                _ => null,
            };
        }
    }
}