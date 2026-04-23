
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// MemoryVersionOperation enum
    /// </summary>
    public enum BetaManagedAgentsMemoryVersionOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Modified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryVersionOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryVersionOperation value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryVersionOperation.Created => "created",
                BetaManagedAgentsMemoryVersionOperation.Deleted => "deleted",
                BetaManagedAgentsMemoryVersionOperation.Modified => "modified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryVersionOperation? ToEnum(string value)
        {
            return value switch
            {
                "created" => BetaManagedAgentsMemoryVersionOperation.Created,
                "deleted" => BetaManagedAgentsMemoryVersionOperation.Deleted,
                "modified" => BetaManagedAgentsMemoryVersionOperation.Modified,
                _ => null,
            };
        }
    }
}