
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The tool the model wants to use.
    /// </summary>
    public sealed partial class ToolUseBlock
    {
        /// <summary>
        /// A unique identifier for this particular tool use block. <br/>
        /// This will be used to match up the tool results later.<br/>
        /// Example: toolu_01A09q90qw90lq917835lq9
        /// </summary>
        /// <example>toolu_01A09q90qw90lq917835lq9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the tool being used.<br/>
        /// Example: get_weather
        /// </summary>
        /// <example>get_weather</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An object containing the input being passed to the tool, conforming to the tool's `input_schema`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: tool_use
        /// </summary>
        /// <default>global::Anthropic.ToolUseBlockType.ToolUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolUseBlockTypeJsonConverter))]
        public global::Anthropic.ToolUseBlockType Type { get; set; } = global::Anthropic.ToolUseBlockType.ToolUse;

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUseBlock" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for this particular tool use block. <br/>
        /// This will be used to match up the tool results later.<br/>
        /// Example: toolu_01A09q90qw90lq917835lq9
        /// </param>
        /// <param name="name">
        /// The name of the tool being used.<br/>
        /// Example: get_weather
        /// </param>
        /// <param name="input">
        /// An object containing the input being passed to the tool, conforming to the tool's `input_schema`.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: tool_use
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolUseBlock(
            string id,
            string name,
            object input,
            global::Anthropic.CacheControlEphemeral? cacheControl,
            global::Anthropic.ToolUseBlockType type = global::Anthropic.ToolUseBlockType.ToolUse)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUseBlock" /> class.
        /// </summary>
        public ToolUseBlock()
        {
        }
    }
}