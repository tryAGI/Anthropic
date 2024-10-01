
#nullable enable

namespace Anthropic
{
    public sealed partial class AnthropicApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Anthropic.EndPointAuthorization
            {
                Name = "x-api-key",
                Value = apiKey,
            };
        }
    }
}