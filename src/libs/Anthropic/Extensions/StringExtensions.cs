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
    public static InputMessageUnion AsUserMessage(this string content)
    {
        return new UserInputMessage
        {
            Content = content,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static InputMessageUnion AsAssistantMessage(this string content)
    {
        return new AssistantInputMessage
        {
            Content = content,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="toolUse"></param>
    /// <returns></returns>
    public static InputMessageUnion AsToolCall(this string content, ResponseToolUseBlock toolUse)
    {
        toolUse = toolUse ?? throw new ArgumentNullException(nameof(toolUse));
        
        return new UserInputMessage
        {
            Content = new InputMessageContent(null, new List<InputContentBlock>
            {
                new RequestToolResultBlock
                {
                    ToolUseId = toolUse.Id,
                    Content = content,
                },
            }),
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static InputMessageUnion AsInputMessage(this Message message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));
        
        return new AssistantInputMessage
        {
            Content = new InputMessageContent(null, message.Content.Select(x =>
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
            }).ToList()),
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
    
    // /// <summary>
    // /// 
    // /// </summary>
    // /// <param name="tools"></param>
    // /// <returns></returns>
    // public static global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305>> AsAnthropicTools(
    //     this IList<CSharpToJsonSchema.Tool> tools)
    // {
    //     return tools
    //         .Select(x => new global::Anthropic.OneOf<global::Anthropic.Tool, global::Anthropic.BashTool20250124, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305>(new Tool
    //         {
    //             Description = x.Description ?? string.Empty,
    //             Name = x.Name ?? string.Empty,
    //             InputSchema = x.Parameters ?? new InputSchema(),
    //         }))
    //         .ToList();
    // }
}