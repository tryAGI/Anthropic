
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentMessageContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Redacted,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentMessageContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentMessageContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentMessageContentBlockDiscriminatorType.Redacted => "redacted",
                BetaManagedAgentsAgentMessageContentBlockDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "redacted" => BetaManagedAgentsAgentMessageContentBlockDiscriminatorType.Redacted,
                "text" => BetaManagedAgentsAgentMessageContentBlockDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}