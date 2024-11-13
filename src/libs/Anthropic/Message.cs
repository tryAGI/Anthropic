namespace Anthropic;

public partial class Message
{
    /// <summary>
    /// Returns the message content as a simple text.
    /// </summary>
    /// <returns></returns>
    public string AsSimpleText()
    {
        return string.Join(Environment.NewLine, Content
            .Select(x =>
            {
                if (x.IsText)
                {
                    return x.Text!.Text;
                }
                if (x.IsToolUse)
                {
                    return x.ToolUse!.Name;
                }
                
                return string.Empty;
            }));
    }
}