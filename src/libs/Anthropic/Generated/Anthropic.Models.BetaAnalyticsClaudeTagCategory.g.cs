
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsClaudeTagCategory
    {
        /// <summary>
        ///
        /// </summary>
        Dm,
        /// <summary>
        ///
        /// </summary>
        Engaged,
        /// <summary>
        ///
        /// </summary>
        Monitoring,
        /// <summary>
        ///
        /// </summary>
        Proactive,
        /// <summary>
        ///
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsClaudeTagCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsClaudeTagCategory value)
        {
            return value switch
            {
                BetaAnalyticsClaudeTagCategory.Dm => "dm",
                BetaAnalyticsClaudeTagCategory.Engaged => "engaged",
                BetaAnalyticsClaudeTagCategory.Monitoring => "monitoring",
                BetaAnalyticsClaudeTagCategory.Proactive => "proactive",
                BetaAnalyticsClaudeTagCategory.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsClaudeTagCategory? ToEnum(string value)
        {
            return value switch
            {
                "dm" => BetaAnalyticsClaudeTagCategory.Dm,
                "engaged" => BetaAnalyticsClaudeTagCategory.Engaged,
                "monitoring" => BetaAnalyticsClaudeTagCategory.Monitoring,
                "proactive" => BetaAnalyticsClaudeTagCategory.Proactive,
                "scheduled" => BetaAnalyticsClaudeTagCategory.Scheduled,
                _ => null,
            };
        }
    }
}