
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryStoreArchivedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStoreArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryStoreArchivedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryStoreArchivedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryStoreArchivedRunErrorType.MemoryStoreArchivedError => "memory_store_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryStoreArchivedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store_archived_error" => BetaManagedAgentsMemoryStoreArchivedRunErrorType.MemoryStoreArchivedError,
                _ => null,
            };
        }
    }
}