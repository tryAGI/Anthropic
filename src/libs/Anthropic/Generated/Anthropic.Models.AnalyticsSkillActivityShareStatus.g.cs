
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalyticsSkillActivityShareStatus
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
    public static class AnalyticsSkillActivityShareStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsSkillActivityShareStatus value)
        {
            return value switch
            {
                AnalyticsSkillActivityShareStatus.Organization => "organization",
                AnalyticsSkillActivityShareStatus.Private => "private",
                AnalyticsSkillActivityShareStatus.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsSkillActivityShareStatus? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AnalyticsSkillActivityShareStatus.Organization,
                "private" => AnalyticsSkillActivityShareStatus.Private,
                "public" => AnalyticsSkillActivityShareStatus.Public,
                _ => null,
            };
        }
    }
}