
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeCodeRbacGroupStatusDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Deleted,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeCodeRbacGroupStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeCodeRbacGroupStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeCodeRbacGroupStatusDiscriminatorType.Active => "active",
                BetaClaudeCodeRbacGroupStatusDiscriminatorType.Deleted => "deleted",
                BetaClaudeCodeRbacGroupStatusDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeCodeRbacGroupStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaClaudeCodeRbacGroupStatusDiscriminatorType.Active,
                "deleted" => BetaClaudeCodeRbacGroupStatusDiscriminatorType.Deleted,
                "unknown" => BetaClaudeCodeRbacGroupStatusDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}