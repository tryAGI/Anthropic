
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where the plugin marketplace's Plugins come from: `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
    /// </summary>
    public enum BetaPluginMarketplaceSource
    {
        /// <summary>
        /// `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
        /// </summary>
        Directory,
        /// <summary>
        /// `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
        /// </summary>
        Github,
        /// <summary>
        /// `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
        /// </summary>
        Gitlab,
        /// <summary>
        /// `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
        /// </summary>
        Manual,
        /// <summary>
        /// `manual` when they are uploaded; `github`, `gitlab` or `public_git` when they are synchronized from the Git repository the owner connected, into which nothing can be uploaded; `directory` is Anthropic's own catalog, which this API does not list. A value this API does not yet name is returned as stored.
        /// </summary>
        PublicGit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginMarketplaceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginMarketplaceSource value)
        {
            return value switch
            {
                BetaPluginMarketplaceSource.Directory => "directory",
                BetaPluginMarketplaceSource.Github => "github",
                BetaPluginMarketplaceSource.Gitlab => "gitlab",
                BetaPluginMarketplaceSource.Manual => "manual",
                BetaPluginMarketplaceSource.PublicGit => "public_git",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginMarketplaceSource? ToEnum(string value)
        {
            return value switch
            {
                "directory" => BetaPluginMarketplaceSource.Directory,
                "github" => BetaPluginMarketplaceSource.Github,
                "gitlab" => BetaPluginMarketplaceSource.Gitlab,
                "manual" => BetaPluginMarketplaceSource.Manual,
                "public_git" => BetaPluginMarketplaceSource.PublicGit,
                _ => null,
            };
        }
    }
}