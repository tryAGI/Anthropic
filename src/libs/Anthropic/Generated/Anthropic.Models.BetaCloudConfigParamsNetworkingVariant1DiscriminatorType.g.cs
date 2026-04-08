
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCloudConfigParamsNetworkingVariant1DiscriminatorType
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
    public static class BetaCloudConfigParamsNetworkingVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCloudConfigParamsNetworkingVariant1DiscriminatorType value)
        {
            return value switch
            {
                BetaCloudConfigParamsNetworkingVariant1DiscriminatorType.Limited => "limited",
                BetaCloudConfigParamsNetworkingVariant1DiscriminatorType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCloudConfigParamsNetworkingVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => BetaCloudConfigParamsNetworkingVariant1DiscriminatorType.Limited,
                "unrestricted" => BetaCloudConfigParamsNetworkingVariant1DiscriminatorType.Unrestricted,
                _ => null,
            };
        }
    }
}