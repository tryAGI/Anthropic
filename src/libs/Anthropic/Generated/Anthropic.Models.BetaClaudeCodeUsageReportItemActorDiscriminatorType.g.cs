
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeCodeUsageReportItemActorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ApiActor,
        /// <summary>
        ///
        /// </summary>
        UserActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeCodeUsageReportItemActorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeCodeUsageReportItemActorDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeCodeUsageReportItemActorDiscriminatorType.ApiActor => "api_actor",
                BetaClaudeCodeUsageReportItemActorDiscriminatorType.UserActor => "user_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeCodeUsageReportItemActorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaClaudeCodeUsageReportItemActorDiscriminatorType.ApiActor,
                "user_actor" => BetaClaudeCodeUsageReportItemActorDiscriminatorType.UserActor,
                _ => null,
            };
        }
    }
}