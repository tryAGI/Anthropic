
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// MemoryView enum
    /// </summary>
    public enum BetaManagedAgentsMemoryView
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
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