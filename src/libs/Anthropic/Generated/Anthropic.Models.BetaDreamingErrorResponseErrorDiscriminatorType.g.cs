
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDreamingErrorResponseErrorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ConflictError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamingErrorResponseErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamingErrorResponseErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaDreamingErrorResponseErrorDiscriminatorType.ConflictError => "conflict_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamingErrorResponseErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conflict_error" => BetaDreamingErrorResponseErrorDiscriminatorType.ConflictError,
                _ => null,
            };
        }
    }
}