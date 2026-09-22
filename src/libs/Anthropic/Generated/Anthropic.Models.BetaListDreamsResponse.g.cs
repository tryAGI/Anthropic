
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A page of dreams, newest first.
    /// </summary>
    public sealed partial class BetaListDreamsResponse
    {
        /// <summary>
        /// The dreams on this page, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaDream> Data { get; set; }

        /// <summary>
        /// The cursor for the next page, or `null` if this is the last page.<br/>
        /// Pass it as `page` to get the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListDreamsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The dreams on this page, newest first.
        /// </param>
        /// <param name="nextPage">
        /// The cursor for the next page, or `null` if this is the last page.<br/>
        /// Pass it as `page` to get the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaListDreamsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaDream> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListDreamsResponse" /> class.
        /// </summary>
        public BetaListDreamsResponse()
        {
        }

    }
}