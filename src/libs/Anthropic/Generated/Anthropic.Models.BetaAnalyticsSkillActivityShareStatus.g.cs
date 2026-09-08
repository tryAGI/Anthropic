
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsSkillActivityShareStatus
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsSkillActivityShareStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsSkillActivityShareStatus value)
        {
            return value switch
            {
                BetaAnalyticsSkillActivityShareStatus.Organization => "organization",
                BetaAnalyticsSkillActivityShareStatus.Private => "private",
                BetaAnalyticsSkillActivityShareStatus.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsSkillActivityShareStatus? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaAnalyticsSkillActivityShareStatus.Organization,
                "private" => BetaAnalyticsSkillActivityShareStatus.Private,
                "public" => BetaAnalyticsSkillActivityShareStatus.Public,
                _ => null,
            };
        }
    }
}