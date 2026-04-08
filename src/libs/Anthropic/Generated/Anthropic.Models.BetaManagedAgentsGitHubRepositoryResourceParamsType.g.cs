
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsGitHubRepositoryResourceParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        GithubRepository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsGitHubRepositoryResourceParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsGitHubRepositoryResourceParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsGitHubRepositoryResourceParamsType.GithubRepository => "github_repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsGitHubRepositoryResourceParamsType? ToEnum(string value)
        {
            return value switch
            {
                "github_repository" => BetaManagedAgentsGitHubRepositoryResourceParamsType.GithubRepository,
                _ => null,
            };
        }
    }
}