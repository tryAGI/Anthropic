
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpiredResult
    {
        /// <summary>
        /// Default Value: expired
        /// </summary>
        /// <default>"expired"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "expired";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: expired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpiredResult(
            string type = "expired")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredResult" /> class.
        /// </summary>
        public ExpiredResult()
        {
        }
    }
}