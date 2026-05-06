
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How the entity behind a user profile relates to the platform that owns the API key. `external`: an individual end-user of the platform. `resold`: a company the platform resells Claude access to. `internal`: the platform's own usage.
    /// </summary>
    public enum BetaUserProfileRelationship
    {
        /// <summary>
        /// an individual end-user of the platform. `resold`: a company the platform resells Claude access to. `internal`: the platform's own usage.
        /// </summary>
        External,
        /// <summary>
        /// an individual end-user of the platform. `resold`: a company the platform resells Claude access to. `internal`: the platform's own usage.
        /// </summary>
        Internal,
        /// <summary>
        /// an individual end-user of the platform. `resold`: a company the platform resells Claude access to. `internal`: the platform's own usage.
        /// </summary>
        Resold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserProfileRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserProfileRelationship value)
        {
            return value switch
            {
                BetaUserProfileRelationship.External => "external",
                BetaUserProfileRelationship.Internal => "internal",
                BetaUserProfileRelationship.Resold => "resold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserProfileRelationship? ToEnum(string value)
        {
            return value switch
            {
                "external" => BetaUserProfileRelationship.External,
                "internal" => BetaUserProfileRelationship.Internal,
                "resold" => BetaUserProfileRelationship.Resold,
                _ => null,
            };
        }
    }
}