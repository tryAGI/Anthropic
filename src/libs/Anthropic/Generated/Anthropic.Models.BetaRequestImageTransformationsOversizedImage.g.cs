
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the server does when this image exceeds the model's maximum image size. `"downsize"` (the default) scales the image down to fit, which changes the dimensions the model observes without telling you. `"error"` instead rejects the request with a 400 error naming the image's dimensions and the largest dimensions that fit, so you can scale the image deliberately — your image is never silently scaled down.
    /// </summary>
    public enum BetaRequestImageTransformationsOversizedImage
    {
        /// <summary>
        ///
        /// </summary>
        Downsize,
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestImageTransformationsOversizedImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestImageTransformationsOversizedImage value)
        {
            return value switch
            {
                BetaRequestImageTransformationsOversizedImage.Downsize => "downsize",
                BetaRequestImageTransformationsOversizedImage.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestImageTransformationsOversizedImage? ToEnum(string value)
        {
            return value switch
            {
                "downsize" => BetaRequestImageTransformationsOversizedImage.Downsize,
                "error" => BetaRequestImageTransformationsOversizedImage.Error,
                _ => null,
            };
        }
    }
}