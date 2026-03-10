using System.Net.Http;
using System.Net.Http.Headers;

namespace Anthropic;

public partial class AnthropicClient
{
    /// <inheritdoc cref="AnthropicClient(HttpClient?, Uri?, List{EndPointAuthorization}?, bool)"/>
    /// <param name="apiKey">API key for authentication via x-api-key header.</param>
    public AnthropicClient(string apiKey) : this(
        authorizations: [new EndPointAuthorization
        {
            Type = "ApiKey",
            Location = "Header",
            Name = "x-api-key",
            Value = apiKey,
        }])
    {
    }

    partial void Initialized(HttpClient client)
    {
        foreach (var auth in Authorizations)
        {
            if (auth is { Type: "ApiKey", Location: "Header" })
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation(auth.Name, auth.Value);
            }
        }
        client.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
        client.DefaultRequestHeaders.Add("User-Agent", "tryAGI/Anthropic");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}