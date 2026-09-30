
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginContentScanAssessment
    {
        /// <summary>
        ///
        /// </summary>
        Fail,
        /// <summary>
        ///
        /// </summary>
        Pass,
        /// <summary>
        ///
        /// </summary>
        Unknown,
        /// <summary>
        ///
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginContentScanAssessmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginContentScanAssessment value)
        {
            return value switch
            {
                BetaPluginContentScanAssessment.Fail => "fail",
                BetaPluginContentScanAssessment.Pass => "pass",
                BetaPluginContentScanAssessment.Unknown => "unknown",
                BetaPluginContentScanAssessment.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginContentScanAssessment? ToEnum(string value)
        {
            return value switch
            {
                "fail" => BetaPluginContentScanAssessment.Fail,
                "pass" => BetaPluginContentScanAssessment.Pass,
                "unknown" => BetaPluginContentScanAssessment.Unknown,
                "warn" => BetaPluginContentScanAssessment.Warn,
                _ => null,
            };
        }
    }
}