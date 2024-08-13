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
    public static Message AsUserMessage(this string content)
    {
        return new Message
        {
            Role = MessageRole.User,
            Content = content,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static Message AsAssistantMessage(this string content)
    {
        return new Message
        {
            Role = MessageRole.Assistant,
            Content = content,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="toolUse"></param>
    /// <returns></returns>
    public static Message AsToolCall(this string content, ToolUseBlock toolUse)
    {
        toolUse = toolUse ?? throw new ArgumentNullException(nameof(toolUse));
        
        return new Message
        {
            Role = MessageRole.User,
            Content = new List<Block>
            {
                new ToolResultBlock
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
    public static Message AsRequestMessage(this Message message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));
        
        return new Message
        {
            Content = message.Content,
            Role = message.Role,
            StopSequence = message.StopSequence,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public static string AsJson(this object args)
    {
        return JsonSerializer.Serialize(args, SourceGenerationContext.Default.ToolUseBlockInput);
    }
}