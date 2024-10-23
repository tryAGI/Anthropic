
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool that uses a mouse and keyboard to interact with a computer, and take screenshots.
    /// </summary>
    public sealed partial class ToolComputerUse
    {
        /// <summary>
        /// The type of tool.<br/>
        /// Default Value: computer_20241022
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "computer_20241022";

        /// <summary>
        /// The name of the tool.<br/>
        /// Default Value: computer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; } = "computer";

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// The width of the display in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayWidthPx { get; set; }

        /// <summary>
        /// The height of the display in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayHeightPx { get; set; }

        /// <summary>
        /// The number of the display to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_number")]
        public int? DisplayNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Anthropic.ToolComputerUse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Anthropic.ToolComputerUse),
                jsonSerializerContext) as global::Anthropic.ToolComputerUse;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Anthropic.ToolComputerUse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ToolComputerUse>(
                json,
                jsonSerializerOptions);
        }

    }
}