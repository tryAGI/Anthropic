
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Another request changed the Workspace, so this request left the setting named in `field` as it is. The error's `message` says which of this request's other changes are in place. Read the Workspace and send the request again if you still want the change.
    /// </summary>
    public sealed partial class BetaWorkspaceChangedConcurrentlyErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workspace_changed_concurrently"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "workspace_changed_concurrently";

        /// <summary>
        /// The request field whose change was refused. Other values may be returned. The value is a name with no data of its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWorkspaceChangedConcurrentlyFieldJsonConverter))]
        public global::Anthropic.BetaWorkspaceChangedConcurrentlyField Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceChangedConcurrentlyErrorDetails" /> class.
        /// </summary>
        /// <param name="field">
        /// The request field whose change was refused. Other values may be returned. The value is a name with no data of its own.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceChangedConcurrentlyErrorDetails(
            global::Anthropic.BetaWorkspaceChangedConcurrentlyField field,
            string errorCode = "workspace_changed_concurrently")
        {
            this.ErrorCode = errorCode;
            this.Field = field;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceChangedConcurrentlyErrorDetails" /> class.
        /// </summary>
        public BetaWorkspaceChangedConcurrentlyErrorDetails()
        {
        }

    }
}