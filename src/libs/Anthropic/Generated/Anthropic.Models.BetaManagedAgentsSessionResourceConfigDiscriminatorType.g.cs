
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionResourceConfigDiscriminatorType
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
    public static class BetaManagedAgentsSessionResourceConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionResourceConfigDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionResourceConfigDiscriminatorType.File => "file",
                BetaManagedAgentsSessionResourceConfigDiscriminatorType.GithubRepository => "github_repository",
                BetaManagedAgentsSessionResourceConfigDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionResourceConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsSessionResourceConfigDiscriminatorType.File,
                "github_repository" => BetaManagedAgentsSessionResourceConfigDiscriminatorType.GithubRepository,
                "memory_store" => BetaManagedAgentsSessionResourceConfigDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}