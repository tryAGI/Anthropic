
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionEndTurnType
    {
        /// <summary>
        /// 
        /// </summary>
        EndTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionEndTurnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionEndTurnType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionEndTurnType.EndTurn => "end_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionEndTurnType? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => BetaManagedAgentsSessionEndTurnType.EndTurn,
                _ => null,
            };
        }
    }
}