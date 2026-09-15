
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The ``url_sources`` variant under which a source contributes in<br/>
    /// full: every result of the tool filter's source, or all user input.
    /// </summary>
    public sealed partial class BetaWebFetchUrlSourceAll
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"all"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "all";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchUrlSourceAll" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebFetchUrlSourceAll(
            string type = "all")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchUrlSourceAll" /> class.
        /// </summary>
        public BetaWebFetchUrlSourceAll()
        {
        }

    }
}