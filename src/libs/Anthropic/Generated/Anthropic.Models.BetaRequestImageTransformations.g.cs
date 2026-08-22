
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configures the transformations the server applies to this image before the model observes it. Each key names a condition the server transforms images for; its value selects the transformation applied. Omitted keys keep their default behavior, and an empty object is equivalent to omitting the field.
    /// </summary>
    public sealed partial class BetaRequestImageTransformations
    {
        /// <summary>
        /// What the server does when this image exceeds the model's maximum image size. `"downsize"` (the default) scales the image down to fit, which changes the dimensions the model observes without telling you. `"error"` instead rejects the request with a 400 error naming the image's dimensions and the largest dimensions that fit, so you can scale the image deliberately — your image is never silently scaled down.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oversized_image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestImageTransformationsOversizedImageJsonConverter))]
        public global::Anthropic.BetaRequestImageTransformationsOversizedImage? OversizedImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestImageTransformations" /> class.
        /// </summary>
        /// <param name="oversizedImage">
        /// What the server does when this image exceeds the model's maximum image size. `"downsize"` (the default) scales the image down to fit, which changes the dimensions the model observes without telling you. `"error"` instead rejects the request with a 400 error naming the image's dimensions and the largest dimensions that fit, so you can scale the image deliberately — your image is never silently scaled down.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestImageTransformations(
            global::Anthropic.BetaRequestImageTransformationsOversizedImage? oversizedImage)
        {
            this.OversizedImage = oversizedImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestImageTransformations" /> class.
        /// </summary>
        public BetaRequestImageTransformations()
        {
        }

    }
}