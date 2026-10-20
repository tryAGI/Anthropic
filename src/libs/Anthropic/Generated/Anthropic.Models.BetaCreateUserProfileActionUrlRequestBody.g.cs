
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateUserProfileActionUrlRequestBody
    {
        /// <summary>
        /// The action that the person who opens the URL takes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUserProfileActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUserProfileAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateUserProfileActionUrlRequestBody" /> class.
        /// </summary>
        /// <param name="action">
        /// The action that the person who opens the URL takes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateUserProfileActionUrlRequestBody(
            global::Anthropic.BetaUserProfileAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateUserProfileActionUrlRequestBody" /> class.
        /// </summary>
        public BetaCreateUserProfileActionUrlRequestBody()
        {
        }

    }
}