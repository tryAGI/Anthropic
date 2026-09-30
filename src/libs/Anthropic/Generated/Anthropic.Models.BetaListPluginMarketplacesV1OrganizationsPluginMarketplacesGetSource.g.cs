
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource
    {
        /// <summary>
        ///
        /// </summary>
        Directory,
        /// <summary>
        ///
        /// </summary>
        Github,
        /// <summary>
        ///
        /// </summary>
        Gitlab,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        PublicGit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource value)
        {
            return value switch
            {
                BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Directory => "directory",
                BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Github => "github",
                BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Gitlab => "gitlab",
                BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Manual => "manual",
                BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.PublicGit => "public_git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource? ToEnum(string value)
        {
            return value switch
            {
                "directory" => BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Directory,
                "github" => BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Github,
                "gitlab" => BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Gitlab,
                "manual" => BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.Manual,
                "public_git" => BetaListPluginMarketplacesV1OrganizationsPluginMarketplacesGetSource.PublicGit,
                _ => null,
            };
        }
    }
}