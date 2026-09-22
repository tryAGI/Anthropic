
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Reference to a single tool, by the name the model uses to call it, as<br/>
    /// a ``compaction`` block's ``tool_changes`` entry reports it: a tool<br/>
    /// declared in ``tools`` or defined by an earlier ``tool_addition`` block.<br/>
    /// Send it back unchanged with the block.
    /// </summary>
    public sealed partial class BetaResponseToolChangeToolReference
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: tool_reference
        /// </summary>
        /// <default>"tool_reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_reference";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeToolReference" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: tool_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolChangeToolReference(
            string name,
            string type = "tool_reference")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeToolReference" /> class.
        /// </summary>
        public BetaResponseToolChangeToolReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseToolChangeToolReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseToolChangeToolReference FromName(string name)
        {
            return new BetaResponseToolChangeToolReference
            {
                Name = name,
            };
        }

    }
}