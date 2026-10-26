namespace Anthropic;

public readonly partial struct InputMessageUnion
{
    /// <summary>Creates a user message from text.</summary>
    public static implicit operator InputMessageUnion(string content) => FromString(content);

    /// <summary>Creates a user message from text.</summary>
    public static InputMessageUnion FromString(string content) => ToInputMessage(content);

    /// <summary>Creates a user message from text.</summary>
    public static InputMessageUnion ToInputMessage(string content) => new UserInputMessage { Content = content };

    /// <summary>Returns the text content of a role-specific message.</summary>
    public string AsSimpleText()
    {
        var content = User?.Content ?? Assistant?.Content;
        if (content is { } value)
        {
            return value.IsInputMessageContentVariant1 ? value.InputMessageContentVariant1 ?? string.Empty :
                string.Join(Environment.NewLine, (value.InputMessageContentVariant2 ?? []).Select(block => block.Text?.Text ?? string.Empty));
        }
        if (System is { } system)
        {
            return system.Content.IsValue1 ? system.Content.Value1 ?? string.Empty :
                string.Join(Environment.NewLine, (system.Content.Value2 ?? []).Select(block => block.Text?.Text ?? string.Empty));
        }
        return string.Empty;
    }
}
