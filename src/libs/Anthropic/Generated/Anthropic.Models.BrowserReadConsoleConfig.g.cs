
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// ``read_console``'s config overrides.
    /// </summary>
    public sealed partial class BrowserReadConsoleConfig
    {
        /// <summary>
        /// Defer loading for this member. Must resolve to the same value on every enabled member of the toolset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// Whether this member is offered to the model. Default is per member, per the toolset's documentation. A member whose enabled resolves false is withheld from the served schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserReadConsoleConfig" /> class.
        /// </summary>
        /// <param name="deferLoading">
        /// Defer loading for this member. Must resolve to the same value on every enabled member of the toolset.
        /// </param>
        /// <param name="enabled">
        /// Whether this member is offered to the model. Default is per member, per the toolset's documentation. A member whose enabled resolves false is withheld from the served schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserReadConsoleConfig(
            bool? deferLoading,
            bool? enabled)
        {
            this.DeferLoading = deferLoading;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserReadConsoleConfig" /> class.
        /// </summary>
        public BrowserReadConsoleConfig()
        {
        }

    }
}