
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsGitHubRepositoryResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        GithubRepository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsGitHubRepositoryResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsGitHubRepositoryResourceType value)
        {
            return value switch
            {
                BetaManagedAgentsGitHubRepositoryResourceType.GithubRepository => "github_repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsGitHubRepositoryResourceType? ToEnum(string value)
        {
            return value switch
            {
                "github_repository" => BetaManagedAgentsGitHubRepositoryResourceType.GithubRepository,
                _ => null,
            };
        }
    }
}