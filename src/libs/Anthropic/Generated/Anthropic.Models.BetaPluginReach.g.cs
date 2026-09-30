
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginReach
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
    public static class BetaPluginReachExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginReach value)
        {
            return value switch
            {
                BetaPluginReach.Contained => "contained",
                BetaPluginReach.Privileged => "privileged",
                BetaPluginReach.Remote => "remote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginReach? ToEnum(string value)
        {
            return value switch
            {
                "contained" => BetaPluginReach.Contained,
                "privileged" => BetaPluginReach.Privileged,
                "remote" => BetaPluginReach.Remote,
                _ => null,
            };
        }
    }
}