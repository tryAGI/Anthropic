
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCloudConfigNetworkingDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Limited,
        /// <summary>
        /// 
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCloudConfigNetworkingDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCloudConfigNetworkingDiscriminatorType value)
        {
            return value switch
            {
                BetaCloudConfigNetworkingDiscriminatorType.Limited => "limited",
                BetaCloudConfigNetworkingDiscriminatorType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCloudConfigNetworkingDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => BetaCloudConfigNetworkingDiscriminatorType.Limited,
                "unrestricted" => BetaCloudConfigNetworkingDiscriminatorType.Unrestricted,
                _ => null,
            };
        }
    }
}