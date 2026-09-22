
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How the platform uses the API on behalf of the entity this profile represents. `application`: the platform sells a product that uses the API behind the scenes, and the profile represents an individual end-user of that product. `passthrough`: the platform resells raw inference, and the profile identifies the resold-to company.
    /// </summary>
    public enum BetaUserProfileAccessType
    {
        /// <summary>
        /// The user profile represents an individual end-user of a product that the platform builds on the API. New profiles get this value by default.
        /// </summary>
        Application,
        /// <summary>
        /// The user profile represents a company that the platform resells Claude access to.
        /// </summary>
        Passthrough,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserProfileAccessTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileAccessType value)
        {
            return value switch
            {
                BetaUserProfileAccessType.Application => "application",
                BetaUserProfileAccessType.Passthrough => "passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileAccessType? ToEnum(string value)
        {
            return value switch
            {
                "application" => BetaUserProfileAccessType.Application,
                "passthrough" => BetaUserProfileAccessType.Passthrough,
                _ => null,
            };
        }
    }
}