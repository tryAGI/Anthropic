#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentBlocksItem : global::System.IEquatable<ContentBlocksItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessageContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaRequestTextBlock? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestTextBlock PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Mid-conversation directive to make a tool available.<br/>
        /// ``tool`` is a reference to a tool (or MCP toolset) declared in the<br/>
        /// request's ``tools``. Under the ``inline-tools-2026-09-15`` beta it may<br/>
        /// instead be a reference to a tool defined earlier in ``messages``, or a<br/>
        /// ``tool_definition`` object that carries an inline tool definition in<br/>
        /// ``definition`` (the same object a ``tools`` entry holds). An ``mcp_toolset``<br/>
        /// definition also requires the ``mcp-client-2026-09-15`` beta. The tool is<br/>
        /// offered to the model from this point in the conversation onward.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolAdditionBlock? ToolAddition { get; init; }
#else
        public global::Anthropic.BetaRequestToolAdditionBlock? ToolAddition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolAddition))]
#endif
        public bool IsToolAddition => ToolAddition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolAddition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestToolAdditionBlock? value)
        {
            value = ToolAddition;
            return IsToolAddition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock PickToolAddition() => ToolAddition is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolAddition' but the value was {ToString()}.");

        /// <summary>
        /// Mid-conversation directive to withdraw a tool.<br/>
        /// ``tool`` references a tool (or MCP toolset) by name: one declared in the<br/>
        /// request's ``tools`` or defined earlier in ``messages``. It is no longer<br/>
        /// offered to the model from this point in the conversation onward.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolRemovalBlock? ToolRemoval { get; init; }
#else
        public global::Anthropic.BetaRequestToolRemovalBlock? ToolRemoval { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolRemoval))]
#endif
        public bool IsToolRemoval => ToolRemoval != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolRemoval(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRequestToolRemovalBlock? value)
        {
            value = ToolRemoval;
            return IsToolRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock PickToolRemoval() => ToolRemoval is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolRemoval' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentBlocksItem(global::Anthropic.BetaRequestTextBlock value) => new ContentBlocksItem((global::Anthropic.BetaRequestTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestTextBlock?(ContentBlocksItem @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentBlocksItem(global::Anthropic.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentBlocksItem FromText(global::Anthropic.BetaRequestTextBlock? value) => new ContentBlocksItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentBlocksItem(global::Anthropic.BetaRequestToolAdditionBlock value) => new ContentBlocksItem((global::Anthropic.BetaRequestToolAdditionBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolAdditionBlock?(ContentBlocksItem @this) => @this.ToolAddition;

        /// <summary>
        ///
        /// </summary>
        public ContentBlocksItem(global::Anthropic.BetaRequestToolAdditionBlock? value)
        {
            ToolAddition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentBlocksItem FromToolAddition(global::Anthropic.BetaRequestToolAdditionBlock? value) => new ContentBlocksItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentBlocksItem(global::Anthropic.BetaRequestToolRemovalBlock value) => new ContentBlocksItem((global::Anthropic.BetaRequestToolRemovalBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolRemovalBlock?(ContentBlocksItem @this) => @this.ToolRemoval;

        /// <summary>
        ///
        /// </summary>
        public ContentBlocksItem(global::Anthropic.BetaRequestToolRemovalBlock? value)
        {
            ToolRemoval = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentBlocksItem FromToolRemoval(global::Anthropic.BetaRequestToolRemovalBlock? value) => new ContentBlocksItem(value);

        /// <summary>
        ///
        /// </summary>
        public ContentBlocksItem(
            global::Anthropic.BetaSystemInputMessageContentBlockDiscriminatorType? type,
            global::Anthropic.BetaRequestTextBlock? text,
            global::Anthropic.BetaRequestToolAdditionBlock? toolAddition,
            global::Anthropic.BetaRequestToolRemovalBlock? toolRemoval
            )
        {
            Type = type;

            Text = text;
            ToolAddition = toolAddition;
            ToolRemoval = toolRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ToolRemoval as object ??
            ToolAddition as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolAddition?.ToString() ??
            ToolRemoval?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolAddition && !IsToolRemoval || !IsText && IsToolAddition && !IsToolRemoval || !IsText && !IsToolAddition && IsToolRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestTextBlock, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaRequestToolAdditionBlock, TResult>? toolAddition = null,
            global::System.Func<global::Anthropic.BetaRequestToolRemovalBlock, TResult>? toolRemoval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (ToolAddition is { } __value1 && toolAddition != null)
            {
                return toolAddition(__value1);
            }
            else if (ToolRemoval is { } __value2 && toolRemoval != null)
            {
                return toolRemoval(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRequestTextBlock>? text = null,

            global::System.Action<global::Anthropic.BetaRequestToolAdditionBlock>? toolAddition = null,

            global::System.Action<global::Anthropic.BetaRequestToolRemovalBlock>? toolRemoval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ToolAddition is { } __value1)
            {
                toolAddition?.Invoke(__value1);
            }
            else if (ToolRemoval is { } __value2)
            {
                toolRemoval?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaRequestTextBlock>? text = null,
            global::System.Action<global::Anthropic.BetaRequestToolAdditionBlock>? toolAddition = null,
            global::System.Action<global::Anthropic.BetaRequestToolRemovalBlock>? toolRemoval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ToolAddition is { } __value1)
            {
                toolAddition?.Invoke(__value1);
            }
            else if (ToolRemoval is { } __value2)
            {
                toolRemoval?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.BetaRequestTextBlock),
                ToolAddition,
                typeof(global::Anthropic.BetaRequestToolAdditionBlock),
                ToolRemoval,
                typeof(global::Anthropic.BetaRequestToolRemovalBlock),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ContentBlocksItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolAdditionBlock?>.Default.Equals(ToolAddition, other.ToolAddition) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolRemovalBlock?>.Default.Equals(ToolRemoval, other.ToolRemoval)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentBlocksItem obj1, ContentBlocksItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentBlocksItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentBlocksItem obj1, ContentBlocksItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentBlocksItem o && Equals(o);
        }
    }
}
