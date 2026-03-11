
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErroredResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ErrorResponse Error { get; set; }

        /// <summary>
        /// Default Value: errored
        /// </summary>
        /// <default>"errored"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "errored";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErroredResult" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type">
        /// Default Value: errored
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErroredResult(
            global::Anthropic.ErrorResponse error,
            string type = "errored")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErroredResult" /> class.
        /// </summary>
        public ErroredResult()
        {
        }
    }
}