
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Object type.<br/>
    /// For Models, this is always `"model"`.<br/>
    /// Default Value: model
    /// </summary>
    public enum BetaModelResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModelResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModelResponseType value)
        {
            return value switch
            {
                BetaModelResponseType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModelResponseType? ToEnum(string value)
        {
            return value switch
            {
                "model" => BetaModelResponseType.Model,
                _ => null,
            };
        }
    }
}