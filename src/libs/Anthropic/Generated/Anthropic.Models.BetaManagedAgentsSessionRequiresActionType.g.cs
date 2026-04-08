
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionRequiresActionType
    {
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionRequiresActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionRequiresActionType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionRequiresActionType.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionRequiresActionType? ToEnum(string value)
        {
            return value switch
            {
                "requires_action" => BetaManagedAgentsSessionRequiresActionType.RequiresAction,
                _ => null,
            };
        }
    }
}