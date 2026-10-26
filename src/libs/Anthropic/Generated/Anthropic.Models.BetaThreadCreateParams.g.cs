
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Start holding conversation state under this response's ``id``.
    /// </summary>
    public sealed partial class BetaThreadCreateParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"create"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "create";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadCreateParams" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThreadCreateParams(
            string type = "create")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadCreateParams" /> class.
        /// </summary>
        public BetaThreadCreateParams()
        {
        }

    }
}