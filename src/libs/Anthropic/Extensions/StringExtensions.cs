namespace Anthropic;

/// <summary>
/// 
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static InputMessage AsUserMessage(this string content)
    {
        return new InputMessage
        {
            Role = InputMessageRole.User,
            Content = content,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static InputMessage AsAssistantMessage(this string content)
    {
        return new InputMessage
        {
            Role = InputMessageRole.Assistant,
            Content = content,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="toolUse"></param>
    /// <returns></returns>
    public static InputMessage AsToolCall(this string content, ResponseToolUseBlock toolUse)
    {
        toolUse = toolUse ?? throw new ArgumentNullException(nameof(toolUse));
        
        return new InputMessage
        {
            Role = InputMessageRole.User,
            Content = new List<InputContentBlock>
            {
                new RequestToolResultBlock
                {
                    ToolUseId = toolUse.Id,
                    Content = content,
                }
            },
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static InputMessage AsInputMessage(this Message message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));
        
        return new InputMessage
        {
            Content = message.Content.Select(x =>
            {
                if (x.IsText)
                {
                    return new InputContentBlock(new RequestTextBlock
                    {
                        Text = x.Text!.Text,
                    });
                }
                if (x.IsToolUse)
                {
                    return new InputContentBlock(new RequestToolUseBlock
                    {
                        Id = x.ToolUse!.Id,
                        Input = x.ToolUse.Input,
                        Name = x.ToolUse!.Name,
                    });
                }
                
                return new InputContentBlock();
            }).ToList(),
            Role = InputMessageRole.Assistant,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public static string AsJson(this object args)
    {
        if (args is JsonElement element)
        {
            return element.GetRawText();
        }
        
        return string.Empty;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tools"></param>
    /// <returns></returns>
    public static IList<global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.TextEditor20250124, global::Anthropic.WebSearchTool20250305>> AsAnthropicTools(
        this IList<CSharpToJsonSchema.Tool> tools)
    {
        return tools
            .Select(x => new global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.TextEditor20250124, global::Anthropic.WebSearchTool20250305>(new Tool
            {
                Description = x.Description ?? string.Empty,
                Name = x.Name ?? string.Empty,
                InputSchema = x.Parameters ?? new InputSchema(),
            }))
            .ToList();
    }
}