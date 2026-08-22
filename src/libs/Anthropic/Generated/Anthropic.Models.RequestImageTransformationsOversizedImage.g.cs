
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the server does when this image exceeds the model's maximum image size. `"downsize"` (the default) scales the image down to fit, which changes the dimensions the model observes without telling you. `"error"` instead rejects the request with a 400 error naming the image's dimensions and the largest dimensions that fit, so you can scale the image deliberately — your image is never silently scaled down.
    /// </summary>
    public enum RequestImageTransformationsOversizedImage
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
    public static class RequestImageTransformationsOversizedImageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestImageTransformationsOversizedImage value)
        {
            return value switch
            {
                RequestImageTransformationsOversizedImage.Downsize => "downsize",
                RequestImageTransformationsOversizedImage.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestImageTransformationsOversizedImage? ToEnum(string value)
        {
            return value switch
            {
                "downsize" => RequestImageTransformationsOversizedImage.Downsize,
                "error" => RequestImageTransformationsOversizedImage.Error,
                _ => null,
            };
        }
    }
}