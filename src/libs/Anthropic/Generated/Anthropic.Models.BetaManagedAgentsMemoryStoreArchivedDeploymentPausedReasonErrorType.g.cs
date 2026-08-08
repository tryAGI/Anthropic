
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStoreArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType.MemoryStoreArchivedError => "memory_store_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store_archived_error" => BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonErrorType.MemoryStoreArchivedError,
                _ => null,
            };
        }
    }
}