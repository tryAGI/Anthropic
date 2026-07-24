
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsGitHubRepositoryResourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        GithubRepository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsGitHubRepositoryResourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsGitHubRepositoryResourceConfigType value)
        {
            return value switch
            {
                BetaManagedAgentsGitHubRepositoryResourceConfigType.GithubRepository => "github_repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsGitHubRepositoryResourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "github_repository" => BetaManagedAgentsGitHubRepositoryResourceConfigType.GithubRepository,
                _ => null,
            };
        }
    }
}