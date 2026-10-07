
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Only the named tools' results contribute URLs that may be fetched.
    /// </summary>
    public sealed partial class BetaManagedAgentsWebFetchUrlSourceOnly
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"only"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "only";

        /// <summary>
        /// The tools whose results contribute. Between 1 and 128 entries, each with a different name. An empty list is rejected; use "none" to allow no tool's results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourceOnly" /> class.
        /// </summary>
        /// <param name="tools">
        /// The tools whose results contribute. Between 1 and 128 entries, each with a different name. An empty list is rejected; use "none" to allow no tool's results.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWebFetchUrlSourceOnly(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolReference> tools,
            string type = "only")
        {
            this.Type = type;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourceOnly" /> class.
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceOnly()
        {
        }

    }
}