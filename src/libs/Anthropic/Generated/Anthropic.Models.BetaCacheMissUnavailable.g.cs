
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCacheMissUnavailable
    {
        /// <summary>
        /// Default Value: unavailable
        /// </summary>
        /// <default>"unavailable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "unavailable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheMissUnavailable" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCacheMissUnavailable(
            string type = "unavailable")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCacheMissUnavailable" /> class.
        /// </summary>
        public BetaCacheMissUnavailable()
        {
        }

    }
}