
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionResourceDiscriminatorType
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
    public static class BetaManagedAgentsSessionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionResourceDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionResourceDiscriminatorType.File => "file",
                BetaManagedAgentsSessionResourceDiscriminatorType.GithubRepository => "github_repository",
                BetaManagedAgentsSessionResourceDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsSessionResourceDiscriminatorType.File,
                "github_repository" => BetaManagedAgentsSessionResourceDiscriminatorType.GithubRepository,
                "memory_store" => BetaManagedAgentsSessionResourceDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}