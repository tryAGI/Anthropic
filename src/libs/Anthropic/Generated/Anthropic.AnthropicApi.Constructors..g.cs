
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
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingApiKey(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}