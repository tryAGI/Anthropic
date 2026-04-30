
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Selects which projection of a `memory` or `memory_version` the server returns. `basic` returns the object with `content` set to `null`; `full` populates `content`. When omitted, the default is endpoint-specific: retrieve operations default to `full`; list, create, and update operations default to `basic`. Listing with `view=full` caps `limit` at 20.
    /// </summary>
    public enum BetaManagedAgentsMemoryView
    {
        /// <summary>
        /// retrieve operations default to `full`; list, create, and update operations default to `basic`. Listing with `view=full` caps `limit` at 20.
        /// </summary>
        Basic,
        /// <summary>
        /// retrieve operations default to `full`; list, create, and update operations default to `basic`. Listing with `view=full` caps `limit` at 20.
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