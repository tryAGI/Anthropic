using System.Net.Http;

namespace Anthropic;

/// <summary>
/// Class providing methods for API access.
/// </summary>
public partial class AnthropicApi
{
    /// <summary>
    /// Sets the selected apiKey as a default header for the HttpClient.
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="httpClient"></param>
    public AnthropicApi(string apiKey, HttpClient httpClient) : this(httpClient)
    {
        apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);
    }
}
