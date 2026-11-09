using System.Net.Http;
using System.Net.Http.Headers;

namespace Anthropic;

public partial class AnthropicClient
{
    /// <summary>
    /// The `anthropic-version` this client sends by default.
    /// </summary>
    /// <remarks>
    /// Sent as a default request header, so it is overridden per call by the `anthropicVersion`
    /// parameter the generated methods take, and client-wide by setting `anthropic-version` in
    /// <see cref="AutoSDKClientOptions.Headers"/> - a header on the request always wins over a
    /// default one. Pin an older version only to postpone a breaking change: every version but the
    /// newest is missing later fixes.
    /// </remarks>
    public const string DefaultApiVersion = "2026-10-21";

    /// <inheritdoc cref="AnthropicClient(HttpClient?, Uri?, List{EndPointAuthorization}?, bool)"/>
    /// <param name="apiKey">API key for authentication via x-api-key header.</param>
    public AnthropicClient(string apiKey) : this(
        httpClient: null,
        authorizations: [new EndPointAuthorization
        {
            Type = "ApiKey",
            Location = "Header",
            Name = "x-api-key",
            Value = apiKey,
        }],
        options: null)
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
        client.DefaultRequestHeaders.Add("anthropic-version", DefaultApiVersion);
        client.DefaultRequestHeaders.Add("User-Agent", "tryAGI/Anthropic");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}
