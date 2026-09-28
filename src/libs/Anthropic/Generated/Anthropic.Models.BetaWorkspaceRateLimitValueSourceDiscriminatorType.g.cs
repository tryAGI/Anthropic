
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWorkspaceRateLimitValueSourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWorkspaceRateLimitValueSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspaceRateLimitValueSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaWorkspaceRateLimitValueSourceDiscriminatorType.Organization => "organization",
                BetaWorkspaceRateLimitValueSourceDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspaceRateLimitValueSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaWorkspaceRateLimitValueSourceDiscriminatorType.Organization,
                "workspace" => BetaWorkspaceRateLimitValueSourceDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}