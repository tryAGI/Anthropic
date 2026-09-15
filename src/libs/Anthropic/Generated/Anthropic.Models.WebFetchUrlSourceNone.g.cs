
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The ``url_sources`` variant under which a source contributes nothing:<br/>
    /// no result of the tool filter's source, or no user input.
    /// </summary>
    public sealed partial class WebFetchUrlSourceNone
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"none"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "none";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchUrlSourceNone" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebFetchUrlSourceNone(
            string type = "none")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchUrlSourceNone" /> class.
        /// </summary>
        public WebFetchUrlSourceNone()
        {
        }

    }
}