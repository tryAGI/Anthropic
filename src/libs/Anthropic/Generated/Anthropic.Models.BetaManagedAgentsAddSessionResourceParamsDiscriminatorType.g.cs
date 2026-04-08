
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAddSessionResourceParamsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAddSessionResourceParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAddSessionResourceParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAddSessionResourceParamsDiscriminatorType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsAddSessionResourceParamsDiscriminatorType.File,
                _ => null,
            };
        }
    }
}