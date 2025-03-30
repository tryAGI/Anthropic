#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentBlock : global::System.IEquatable<ContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaResponseTextBlock? Text { get; }
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
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseTextBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseTextBlock?(ContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.BetaResponseToolUseBlock? ToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUse))]
#endif
        public bool IsToolUse => ToolUse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseToolUseBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolUseBlock?(ContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseThinkingBlock? Thinking { get; init; }
#else
        public global::Anthropic.BetaResponseThinkingBlock? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseThinkingBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseThinkingBlock?(ContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::Anthropic.BetaResponseRedactedThinkingBlock? RedactedThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedThinking))]
#endif
        public bool IsRedactedThinking => RedactedThinking != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentBlock(global::Anthropic.BetaResponseRedactedThinkingBlock value) => new ContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseRedactedThinkingBlock?(ContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(global::Anthropic.BetaResponseRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentBlock(
            global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? type,
            global::Anthropic.BetaResponseTextBlock? text,
            global::Anthropic.BetaResponseToolUseBlock? toolUse,
            global::Anthropic.BetaResponseThinkingBlock? thinking,
            global::Anthropic.BetaResponseRedactedThinkingBlock? redactedThinking
            )
        {
            Type = type;

            Text = text;
            ToolUse = toolUse;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RedactedThinking as object ??
            Thinking as object ??
            ToolUse as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolUse?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolUse && !IsThinking && !IsRedactedThinking || !IsText && IsToolUse && !IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && IsThinking && !IsRedactedThinking || !IsText && !IsToolUse && !IsThinking && IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaResponseTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaResponseToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.BetaResponseThinkingBlock?, TResult>? thinking = null,
            global::System.Func<global::Anthropic.BetaResponseRedactedThinkingBlock?, TResult>? redactedThinking = null,
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
            else if (IsToolUse && toolUse != null)
            {
                return toolUse(ToolUse!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsRedactedThinking && redactedThinking != null)
            {
                return redactedThinking(RedactedThinking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaResponseTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaResponseToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.BetaResponseThinkingBlock?>? thinking = null,
            global::System.Action<global::Anthropic.BetaResponseRedactedThinkingBlock?>? redactedThinking = null,
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
            else if (IsToolUse)
            {
                toolUse?.Invoke(ToolUse!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsRedactedThinking)
            {
                redactedThinking?.Invoke(RedactedThinking!);
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
                typeof(global::Anthropic.BetaResponseTextBlock),
                ToolUse,
                typeof(global::Anthropic.BetaResponseToolUseBlock),
                Thinking,
                typeof(global::Anthropic.BetaResponseThinkingBlock),
                RedactedThinking,
                typeof(global::Anthropic.BetaResponseRedactedThinkingBlock),
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
        public bool Equals(ContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentBlock obj1, ContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentBlock obj1, ContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentBlock o && Equals(o);
        }
    }
}
