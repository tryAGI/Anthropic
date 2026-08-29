
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        DownloadCompleted,
        /// <summary>
        ///
        /// </summary>
        DownloadFailed,
        /// <summary>
        ///
        /// </summary>
        DownloadStarted,
        /// <summary>
        ///
        /// </summary>
        TabOpened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadCompleted => "download_completed",
                BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadFailed => "download_failed",
                BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadStarted => "download_started",
                BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.TabOpened => "tab_opened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "download_completed" => BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadCompleted,
                "download_failed" => BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadFailed,
                "download_started" => BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadStarted,
                "tab_opened" => BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.TabOpened,
                _ => null,
            };
        }
    }
}