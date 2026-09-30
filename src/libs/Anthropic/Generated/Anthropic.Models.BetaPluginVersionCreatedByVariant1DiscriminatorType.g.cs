
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginVersionCreatedByVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ApiActor,
        /// <summary>
        ///
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginVersionCreatedByVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginVersionCreatedByVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaPluginVersionCreatedByVariant1DiscriminatorType.ApiActor => "api_actor",
                BetaPluginVersionCreatedByVariant1DiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginVersionCreatedByVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaPluginVersionCreatedByVariant1DiscriminatorType.ApiActor,
                "user_actor" => BetaPluginVersionCreatedByVariant1DiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}