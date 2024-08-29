
#nullable enable

namespace Anthropic
{
    public sealed partial class AnthropicApi
    {
        /// <inheritdoc cref="AnthropicApi(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public AnthropicApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingApiKey(apiKey);
        }
    }
}