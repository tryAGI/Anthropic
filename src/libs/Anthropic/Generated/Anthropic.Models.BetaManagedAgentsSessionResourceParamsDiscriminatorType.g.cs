
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionResourceParamsDiscriminatorType
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
    public static class BetaManagedAgentsSessionResourceParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionResourceParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionResourceParamsDiscriminatorType.File => "file",
                BetaManagedAgentsSessionResourceParamsDiscriminatorType.GithubRepository => "github_repository",
                BetaManagedAgentsSessionResourceParamsDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionResourceParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsSessionResourceParamsDiscriminatorType.File,
                "github_repository" => BetaManagedAgentsSessionResourceParamsDiscriminatorType.GithubRepository,
                "memory_store" => BetaManagedAgentsSessionResourceParamsDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}