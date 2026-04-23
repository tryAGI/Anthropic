
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsGetSessionResourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        GithubRepository,
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsGetSessionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsGetSessionResourceDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsGetSessionResourceDiscriminatorType.File => "file",
                BetaManagedAgentsGetSessionResourceDiscriminatorType.GithubRepository => "github_repository",
                BetaManagedAgentsGetSessionResourceDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsGetSessionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsGetSessionResourceDiscriminatorType.File,
                "github_repository" => BetaManagedAgentsGetSessionResourceDiscriminatorType.GithubRepository,
                "memory_store" => BetaManagedAgentsGetSessionResourceDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}