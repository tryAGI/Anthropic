
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateUserProfileActionUrlRequestBody
    {
        /// <summary>
        /// The action that the person who opens the URL takes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserProfileActionUrlRequestBody" /> class.
        /// </summary>
        /// <param name="action">
        /// The action that the person who opens the URL takes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUserProfileActionUrlRequestBody(
            global::Anthropic.UserProfileAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserProfileActionUrlRequestBody" /> class.
        /// </summary>
        public CreateUserProfileActionUrlRequestBody()
        {
        }

    }
}