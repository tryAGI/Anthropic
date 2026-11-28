
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaStorageMemberParamsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaStorageMemberParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaStorageMemberParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaStorageMemberParamsDiscriminatorType.External => "external",
                BetaStorageMemberParamsDiscriminatorType.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaStorageMemberParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "external" => BetaStorageMemberParamsDiscriminatorType.External,
                "internal" => BetaStorageMemberParamsDiscriminatorType.Internal,
                _ => null,
            };
        }
    }
}