
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginCreatedByVariant1DiscriminatorType
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
    public static class BetaPluginCreatedByVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginCreatedByVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaPluginCreatedByVariant1DiscriminatorType.ApiActor => "api_actor",
                BetaPluginCreatedByVariant1DiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginCreatedByVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaPluginCreatedByVariant1DiscriminatorType.ApiActor,
                "user_actor" => BetaPluginCreatedByVariant1DiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}