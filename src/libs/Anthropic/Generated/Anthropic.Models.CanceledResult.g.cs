
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CanceledResult
    {
        /// <summary>
        /// Default Value: canceled
        /// </summary>
        /// <default>"canceled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "canceled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CanceledResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: canceled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CanceledResult(
            string type = "canceled")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CanceledResult" /> class.
        /// </summary>
        public CanceledResult()
        {
        }
    }
}