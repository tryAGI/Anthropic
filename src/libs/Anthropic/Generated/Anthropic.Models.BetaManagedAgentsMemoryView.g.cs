
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether a `memory` or `memory_version` in the response includes its `content`. Defaults to `full` on retrieve operations and to `basic` on list, create, and update operations.<br/>
    /// With `full`, list operations return at most 20 items per page.
    /// </summary>
    public enum BetaManagedAgentsMemoryView
    {
        /// <summary>
        /// Return the object with `content` set to `null`. The `content_size_bytes` and `content_sha256` fields remain populated, so sync clients can diff without fetching content.
        /// </summary>
        Basic,
        /// <summary>
        /// Return the object with `content` populated. On list endpoints, `view=full` caps `limit` at 20.
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryView value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryView.Basic => "basic",
                BetaManagedAgentsMemoryView.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryView? ToEnum(string value)
        {
            return value switch
            {
                "basic" => BetaManagedAgentsMemoryView.Basic,
                "full" => BetaManagedAgentsMemoryView.Full,
                _ => null,
            };
        }
    }
}