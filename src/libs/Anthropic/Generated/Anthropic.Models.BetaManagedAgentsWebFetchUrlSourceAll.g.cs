
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Every URL from this source may be fetched. This is the default.
    /// </summary>
    public sealed partial class BetaManagedAgentsWebFetchUrlSourceAll
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourceAll" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWebFetchUrlSourceAll(
            string type = "all")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourceAll" /> class.
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceAll()
        {
        }

    }
}