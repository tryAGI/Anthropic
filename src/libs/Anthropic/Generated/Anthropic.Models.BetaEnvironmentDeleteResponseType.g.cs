
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of response<br/>
    /// Default Value: environment_deleted
    /// </summary>
    public enum BetaEnvironmentDeleteResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaEnvironmentDeleteResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEnvironmentDeleteResponseType value)
        {
            return value switch
            {
                BetaEnvironmentDeleteResponseType.EnvironmentDeleted => "environment_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEnvironmentDeleteResponseType? ToEnum(string value)
        {
            return value switch
            {
                "environment_deleted" => BetaEnvironmentDeleteResponseType.EnvironmentDeleted,
                _ => null,
            };
        }
    }
}