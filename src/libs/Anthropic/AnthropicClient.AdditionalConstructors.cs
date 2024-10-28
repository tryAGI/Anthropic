using System.Net.Http;
using System.Net.Http.Headers;

namespace Anthropic;

public partial class AnthropicClient
{
    partial void Initialized(HttpClient client)
    {
        client.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
        client.DefaultRequestHeaders.Add("anthropic-beta", [
            "tools-2024-04-04",
            "message-batches-2024-09-24",
            "prompt-caching-2024-07-31",
            "computer-use-2024-10-22",
            //"max-tokens-3-5-sonnet-2024-07-15",
        ]);
        client.DefaultRequestHeaders.Add("User-Agent", "tryAGI/Anthropic");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}