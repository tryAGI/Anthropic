namespace Anthropic;

public partial class InputMessage
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static implicit operator InputMessage(string content)
    {
        return ToInputMessage(content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static InputMessage ToInputMessage(string content)
    {
        return new InputMessage
        {
            Role = InputMessageRole.User,
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
                    // if (x.IsText)
                    // {
                    //     return x.Text!.Text;
                    // }
                    // if (x.IsImage)
                    // {
                    //     return "Image";
                    //     //return x.Image!.Source.Data;
                    // }
                    // if (x.IsToolUse)
                    // {
                    //     return x.ToolUse!.Name;
                    // }
                    // if (x.IsToolResult)
                    // {
                    //     return x.ToolResult!.ToolUseId;
                    // }
                    
                    return string.Empty;
                }));
        }
        
        return string.Empty;
    }
}