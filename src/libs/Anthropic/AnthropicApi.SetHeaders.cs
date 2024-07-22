using System.Net.Http.Headers;

namespace Anthropic;

public partial class AnthropicApi
{
    /// <summary>
    /// 
    /// </summary>
    public void SetHeaders()
    {
        _httpClient.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
        _httpClient.DefaultRequestHeaders.Add("anthropic-beta", "tools-2024-04-04"); //max-tokens-3-5-sonnet-2024-07-15
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "tryAGI/Anthropic");
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}
