
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The longest side of one or more images in the request exceeds the image size limit. Scale each image in `paths` so that neither side exceeds `max_side_length_pixels`, or remove it, then retry.
    /// </summary>
    public sealed partial class ImageDimensionsTooLargeErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"image_dimensions_too_large"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "image_dimensions_too_large";

        /// <summary>
        /// The limit the images exceeded: the largest width or height, in pixels, that an image on this request may have.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_side_length_pixels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSideLengthPixels { get; set; }

        /// <summary>
        /// The position of every image over the limit, in the order you sent them, nested blocks included, such as `messages.0.content.1`, or `messages.0.content.1.content.0` for an image in a `tool_result` block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDimensionsTooLargeErrorDetails" /> class.
        /// </summary>
        /// <param name="maxSideLengthPixels">
        /// The limit the images exceeded: the largest width or height, in pixels, that an image on this request may have.
        /// </param>
        /// <param name="paths">
        /// The position of every image over the limit, in the order you sent them, nested blocks included, such as `messages.0.content.1`, or `messages.0.content.1.content.0` for an image in a `tool_result` block.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageDimensionsTooLargeErrorDetails(
            int maxSideLengthPixels,
            global::System.Collections.Generic.IList<string> paths,
            string errorCode = "image_dimensions_too_large")
        {
            this.ErrorCode = errorCode;
            this.MaxSideLengthPixels = maxSideLengthPixels;
            this.Paths = paths ?? throw new global::System.ArgumentNullException(nameof(paths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDimensionsTooLargeErrorDetails" /> class.
        /// </summary>
        public ImageDimensionsTooLargeErrorDetails()
        {
        }

    }
}