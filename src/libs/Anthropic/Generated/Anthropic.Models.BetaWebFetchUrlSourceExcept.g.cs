
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The tool filter variant under which every result but the named<br/>
    /// tools' contributes.
    /// </summary>
    public sealed partial class BetaWebFetchUrlSourceExcept
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaWebFetchUrlSourceToolReference> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"except"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "except";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchUrlSourceExcept" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebFetchUrlSourceExcept(
            global::System.Collections.Generic.IList<global::Anthropic.BetaWebFetchUrlSourceToolReference> tools,
            string type = "except")
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebFetchUrlSourceExcept" /> class.
        /// </summary>
        public BetaWebFetchUrlSourceExcept()
        {
        }

    }
}