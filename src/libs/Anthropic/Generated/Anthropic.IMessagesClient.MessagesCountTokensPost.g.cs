#nullable enable

namespace Anthropic
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Count tokens in a Message<br/>
        /// Count the number of tokens in a Message.<br/>
        /// The Token Count API can be used to count the number of tokens in a Message, including tools, images, and documents, without creating it.<br/>
        /// Learn more about token counting in our [user guide](/en/docs/build-with-claude/token-counting)
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.CountMessageTokensResponse> MessagesCountTokensPostAsync(
            global::Anthropic.CountMessageTokensParams request,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Count tokens in a Message<br/>
        /// Count the number of tokens in a Message.<br/>
        /// The Token Count API can be used to count the number of tokens in a Message, including tools, images, and documents, without creating it.<br/>
        /// Learn more about token counting in our [user guide](/en/docs/build-with-claude/token-counting)
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="messages">
        /// Input messages.<br/>
        /// Our models are trained to operate on alternating `user` and `assistant` conversational turns. When creating a new `Message`, you specify the prior conversational turns with the `messages` parameter, and the model then generates the next `Message` in the conversation. Consecutive `user` or `assistant` turns in your request will be combined into a single turn.<br/>
        /// Each input message must be an object with a `role` and `content`. You can specify a single `user`-role message, or you can include multiple `user` and `assistant` messages.<br/>
        /// If the final message uses the `assistant` role, the response content will continue immediately from the content in that message. This can be used to constrain part of the model's response.<br/>
        /// Example with a single `user` message:<br/>
        /// ```json<br/>
        /// [{"role": "user", "content": "Hello, Claude"}]<br/>
        /// ```<br/>
        /// Example with multiple conversational turns:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "Hello there."},<br/>
        ///   {"role": "assistant", "content": "Hi, I'm Claude. How can I help you?"},<br/>
        ///   {"role": "user", "content": "Can you explain LLMs in plain English?"},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Example with a partially-filled response from Claude:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun"},<br/>
        ///   {"role": "assistant", "content": "The best answer is ("},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Each input message `content` may be either a single `string` or an array of content blocks, where each block has a specific `type`. Using a `string` for `content` is shorthand for an array of one content block of type `"text"`. The following input messages are equivalent:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": "Hello, Claude"}<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [{"type": "text", "text": "Hello, Claude"}]}<br/>
        /// ```<br/>
        /// Starting with Claude 3 models, you can also send image content blocks:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [<br/>
        ///   {<br/>
        ///     "type": "image",<br/>
        ///     "source": {<br/>
        ///       "type": "base64",<br/>
        ///       "media_type": "image/jpeg",<br/>
        ///       "data": "/9j/4AAQSkZJRg...",<br/>
        ///     }<br/>
        ///   },<br/>
        ///   {"type": "text", "text": "What is in this image?"}<br/>
        /// ]}<br/>
        /// ```<br/>
        /// We currently support the `base64` source type for images, and the `image/jpeg`, `image/png`, `image/gif`, and `image/webp` media types.<br/>
        /// See [examples](https://docs.anthropic.com/en/api/messages-examples#vision) for more input examples.<br/>
        /// Note that if you want to include a [system prompt](https://docs.anthropic.com/en/docs/system-prompts), you can use the top-level `system` parameter — there is no `"system"` role for input messages in the Messages API.<br/>
        /// There is a limit of 100,000 messages in a single request.
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="system">
        /// System prompt.<br/>
        /// A system prompt is a way of providing context and instructions to Claude, such as specifying a particular goal or role. See our [guide to system prompts](https://docs.anthropic.com/en/docs/system-prompts).<br/>
        /// Example: []
        /// </param>
        /// <param name="thinking">
        /// Configuration for enabling Claude's extended thinking. <br/>
        /// When enabled, responses include `thinking` content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your `max_tokens` limit.<br/>
        /// See [extended thinking](https://docs.anthropic.com/en/docs/build-with-claude/extended-thinking) for details.
        /// </param>
        /// <param name="toolChoice">
        /// How the model should use the provided tools. The model can use a specific tool, any available tool, decide by itself, or not use tools at all.
        /// </param>
        /// <param name="tools">
        /// Definitions of tools that the model may use.<br/>
        /// If you include `tools` in your API request, the model may return `tool_use` content blocks that represent the model's use of those tools. You can then run those tools using the tool input generated by the model and then optionally return results back to the model using `tool_result` content blocks.<br/>
        /// There are two types of tools: **client tools** and **server tools**. The behavior described below applies to client tools. For [server tools](https://docs.anthropic.com/en/docs/agents-and-tools/tool-use/overview\#server-tools), see their individual documentation as each has its own behavior (e.g., the [web search tool](https://docs.anthropic.com/en/docs/agents-and-tools/tool-use/web-search-tool)).<br/>
        /// Each tool definition includes:<br/>
        /// * `name`: Name of the tool.<br/>
        /// * `description`: Optional, but strongly-recommended description of the tool.<br/>
        /// * `input_schema`: [JSON schema](https://json-schema.org/draft/2020-12) for the tool `input` shape that the model will produce in `tool_use` output content blocks.<br/>
        /// For example, if you defined `tools` as:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "description": "Get the current stock price for a given ticker symbol.",<br/>
        ///     "input_schema": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "ticker": {<br/>
        ///           "type": "string",<br/>
        ///           "description": "The stock ticker symbol, e.g. AAPL for Apple Inc."<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["ticker"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// And then asked the model "What's the S&amp;P 500 at today?", the model might produce `tool_use` content blocks in the response like this:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_use",<br/>
        ///     "id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "input": { "ticker": "^GSPC" }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// You might then run your `get_stock_price` tool with `{"ticker": "^GSPC"}` as an input, and return the following back to the model in a subsequent `user` message:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_result",<br/>
        ///     "tool_use_id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "content": "259.75 USD"<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// Tools can be used for workflows that include running client-side tools and functions, or more generally whenever you want the model to produce a particular JSON structure of output.<br/>
        /// See our [guide](https://docs.anthropic.com/en/docs/tool-use) for more details.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.CountMessageTokensResponse> MessagesCountTokensPostAsync(
            global::System.Collections.Generic.IList<global::Anthropic.InputMessage> messages,
#pragma warning disable CS0618 // Type or member is obsolete
            global::Anthropic.Model model,
#pragma warning disable CS0618 // Type or member is obsolete
            string? anthropicVersion = default,
            global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.RequestTextBlock>>? system = default,
            global::Anthropic.ThinkingConfigParam? thinking = default,
            global::Anthropic.ToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.WebSearchTool20250305>>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}