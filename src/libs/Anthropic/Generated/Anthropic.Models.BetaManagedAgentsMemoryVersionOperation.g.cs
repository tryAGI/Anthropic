
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The kind of mutation a `memory_version` records. Every non-no-op mutation to a memory appends exactly one version row with one of these values.
    /// </summary>
    public enum BetaManagedAgentsMemoryVersionOperation
    {
        /// <summary>
        /// The memory was created. The first version in any memory's lineage.
        /// </summary>
        Created,
        /// <summary>
        /// The memory was deleted. The `content`, `content_size_bytes`, and `content_sha256` fields are `null` on this version. The preceding version, while it is retained, records the deleted content's size and hash.
        /// </summary>
        Deleted,
        /// <summary>
        /// The memory's `content`, `path`, or both were changed via update. Writes the agent makes through the filesystem mount also appear as `modified`.
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