
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType
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
    public static class RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadCompleted => "download_completed",
                RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadFailed => "download_failed",
                RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadStarted => "download_started",
                RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.TabOpened => "tab_opened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "download_completed" => RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadCompleted,
                "download_failed" => RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadFailed,
                "download_started" => RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.DownloadStarted,
                "tab_opened" => RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType.TabOpened,
                _ => null,
            };
        }
    }
}