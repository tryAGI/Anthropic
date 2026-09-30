
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `processing` while a scan runs, `completed` when it ran to completion, `errored` when it could not run or its outcome cannot be read.
    /// </summary>
    public enum BetaPluginContentScanStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Errored,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginContentScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginContentScanStatus value)
        {
            return value switch
            {
                BetaPluginContentScanStatus.Completed => "completed",
                BetaPluginContentScanStatus.Errored => "errored",
                BetaPluginContentScanStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginContentScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaPluginContentScanStatus.Completed,
                "errored" => BetaPluginContentScanStatus.Errored,
                "processing" => BetaPluginContentScanStatus.Processing,
                _ => null,
            };
        }
    }
}