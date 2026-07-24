#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentItem : global::System.IEquatable<ContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestMidConvSystemBlockContentItemDiscriminatorType? Type { get; }

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
        public global::Anthropic.BetaRequestTextBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Mid-conversation directive to surface a declared tool.<br/>
        /// ``tool`` references a tool (or MCP toolset) by name from the request's<br/>
        /// ``tools``; it is offered to the model from this point in the<br/>
        /// conversation onward.
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
        public global::Anthropic.BetaRequestToolAdditionBlock PickToolAddition() => IsToolAddition
            ? ToolAddition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolAddition' but the value was {ToString()}.");

        /// <summary>
        /// Mid-conversation directive to withdraw a tool.<br/>
        /// ``tool`` references a tool (or MCP toolset) by name from the request's<br/>
        /// ``tools``; it is no longer offered to the model from this point in the<br/>
        /// conversation onward.
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
        public global::Anthropic.BetaRequestToolRemovalBlock PickToolRemoval() => IsToolRemoval
            ? ToolRemoval!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolRemoval' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::Anthropic.BetaRequestTextBlock value) => new ContentItem((global::Anthropic.BetaRequestTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestTextBlock?(ContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::Anthropic.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem FromText(global::Anthropic.BetaRequestTextBlock? value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::Anthropic.BetaRequestToolAdditionBlock value) => new ContentItem((global::Anthropic.BetaRequestToolAdditionBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolAdditionBlock?(ContentItem @this) => @this.ToolAddition;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::Anthropic.BetaRequestToolAdditionBlock? value)
        {
            ToolAddition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem FromToolAddition(global::Anthropic.BetaRequestToolAdditionBlock? value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::Anthropic.BetaRequestToolRemovalBlock value) => new ContentItem((global::Anthropic.BetaRequestToolRemovalBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolRemovalBlock?(ContentItem @this) => @this.ToolRemoval;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::Anthropic.BetaRequestToolRemovalBlock? value)
        {
            ToolRemoval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem FromToolRemoval(global::Anthropic.BetaRequestToolRemovalBlock? value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(
            global::Anthropic.BetaRequestMidConvSystemBlockContentItemDiscriminatorType? type,
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

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsToolAddition && toolAddition != null)
            {
                return toolAddition(ToolAddition!);
            }
            else if (IsToolRemoval && toolRemoval != null)
            {
                return toolRemoval(ToolRemoval!);
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

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsToolAddition)
            {
                toolAddition?.Invoke(ToolAddition!);
            }
            else if (IsToolRemoval)
            {
                toolRemoval?.Invoke(ToolRemoval!);
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

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsToolAddition)
            {
                toolAddition?.Invoke(ToolAddition!);
            }
            else if (IsToolRemoval)
            {
                toolRemoval?.Invoke(ToolRemoval!);
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
        public bool Equals(ContentItem other)
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
        public static bool operator ==(ContentItem obj1, ContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem obj1, ContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem o && Equals(o);
        }
    }
}
