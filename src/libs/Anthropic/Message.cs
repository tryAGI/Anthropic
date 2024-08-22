namespace Anthropic;

public partial class Message
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static implicit operator Message(string content)
    {
        return ToMessage(content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static Message ToMessage(string content)
    {
        return new Message
        {
            Role = MessageRole.User,
            Content = content,
        };
    }

    /// <summary>
    /// Returns the message content as a simple text.
    /// </summary>
    /// <returns></returns>
    public string AsSimpleText()
    {
        if (Content.IsValue1)
        {
            return Content.Value1!;
        }
        if (Content.IsValue2)
        {
            return string.Join(Environment.NewLine, Content.Value2!
                .Select(x =>
                {
                    if (x.IsText)
                    {
                        return x.Text!.Text;
                    }
                    if (x.IsImage)
                    {
                        return x.Image!.Source.Data;
                    }
                    if (x.IsToolUse)
                    {
                        return x.ToolUse!.Name;
                    }
                    if (x.IsToolResult)
                    {
                        return x.ToolResult!.ToolUseId;
                    }
                    
                    return string.Empty;
                }));
        }
        
        return string.Empty;
    }
}