
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaComputerUseTool20241022
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20241022TypeJsonConverter))]
        public global::Anthropic.BetaComputerUseTool20241022Type Type { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComputerUseTool20241022NameJsonConverter))]
        public global::Anthropic.BetaComputerUseTool20241022Name Name { get; set; }

        /// <summary>
        /// The height of the display in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayHeightPx { get; set; }

        /// <summary>
        /// The width of the display in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width_px")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisplayWidthPx { get; set; }

        /// <summary>
        /// The X11 display number (e.g. 0, 1) for the display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_number")]
        public int? DisplayNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerUseTool20241022" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </param>
        /// <param name="displayHeightPx">
        /// The height of the display in pixels.
        /// </param>
        /// <param name="displayWidthPx">
        /// The width of the display in pixels.
        /// </param>
        /// <param name="displayNumber">
        /// The X11 display number (e.g. 0, 1) for the display.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaComputerUseTool20241022(
            int displayHeightPx,
            int displayWidthPx,
            global::Anthropic.BetaCacheControlEphemeral? cacheControl,
            global::Anthropic.BetaComputerUseTool20241022Type type,
            global::Anthropic.BetaComputerUseTool20241022Name name,
            int? displayNumber)
        {
            this.DisplayHeightPx = displayHeightPx;
            this.DisplayWidthPx = displayWidthPx;
            this.CacheControl = cacheControl;
            this.Type = type;
            this.Name = name;
            this.DisplayNumber = displayNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerUseTool20241022" /> class.
        /// </summary>
        public BetaComputerUseTool20241022()
        {
        }
    }
}