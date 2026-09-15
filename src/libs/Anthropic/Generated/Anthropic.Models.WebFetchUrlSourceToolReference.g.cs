
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One entry of a tool filter's ``tools``: it must name a tool declared<br/>
    /// in this request's ``tools[]``.
    /// </summary>
    public sealed partial class WebFetchUrlSourceToolReference
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="WebFetchUrlSourceToolReference" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebFetchUrlSourceToolReference(
            string name,
            string type = "tool_reference")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchUrlSourceToolReference" /> class.
        /// </summary>
        public WebFetchUrlSourceToolReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebFetchUrlSourceToolReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebFetchUrlSourceToolReference FromName(string name)
        {
            return new WebFetchUrlSourceToolReference
            {
                Name = name,
            };
        }

    }
}