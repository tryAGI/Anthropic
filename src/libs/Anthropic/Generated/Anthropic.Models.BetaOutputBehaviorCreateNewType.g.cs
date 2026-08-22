
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaOutputBehaviorCreateNewType
    {
        /// <summary>
        /// 
        /// </summary>
        CreateNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputBehaviorCreateNewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputBehaviorCreateNewType value)
        {
            return value switch
            {
                BetaOutputBehaviorCreateNewType.CreateNew => "create_new",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputBehaviorCreateNewType? ToEnum(string value)
        {
            return value switch
            {
                "create_new" => BetaOutputBehaviorCreateNewType.CreateNew,
                _ => null,
            };
        }
    }
}