
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginVersionReach
    {
        /// <summary>
        ///
        /// </summary>
        Contained,
        /// <summary>
        ///
        /// </summary>
        Privileged,
        /// <summary>
        ///
        /// </summary>
        Remote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginVersionReachExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginVersionReach value)
        {
            return value switch
            {
                BetaPluginVersionReach.Contained => "contained",
                BetaPluginVersionReach.Privileged => "privileged",
                BetaPluginVersionReach.Remote => "remote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginVersionReach? ToEnum(string value)
        {
            return value switch
            {
                "contained" => BetaPluginVersionReach.Contained,
                "privileged" => BetaPluginVersionReach.Privileged,
                "remote" => BetaPluginVersionReach.Remote,
                _ => null,
            };
        }
    }
}