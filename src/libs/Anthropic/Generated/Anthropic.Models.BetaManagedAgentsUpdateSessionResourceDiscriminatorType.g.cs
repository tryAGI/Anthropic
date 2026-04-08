
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUpdateSessionResourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        GithubRepository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUpdateSessionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUpdateSessionResourceDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsUpdateSessionResourceDiscriminatorType.File => "file",
                BetaManagedAgentsUpdateSessionResourceDiscriminatorType.GithubRepository => "github_repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUpdateSessionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsUpdateSessionResourceDiscriminatorType.File,
                "github_repository" => BetaManagedAgentsUpdateSessionResourceDiscriminatorType.GithubRepository,
                _ => null,
            };
        }
    }
}