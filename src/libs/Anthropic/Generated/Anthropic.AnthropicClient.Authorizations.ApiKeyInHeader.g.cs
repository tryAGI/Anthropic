
#nullable enable

namespace Anthropic
{
    public sealed partial class AnthropicClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Anthropic.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "x-api-key",
                Value = apiKey,
            });
        }
    }
}