#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Content block in a mid-conversation system message. Text-only.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSystemContentBlock : global::System.IEquatable<BetaManagedAgentsSystemContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// Regular text content.<br/>
        /// Example: {"type":"text","text":"Where is my order #1234?"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTextBlock? Text { get; }
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
            out global::Anthropic.BetaManagedAgentsTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTextBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSystemContentBlock(global::Anthropic.BetaManagedAgentsTextBlock value) => new BetaManagedAgentsSystemContentBlock((global::Anthropic.BetaManagedAgentsTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTextBlock?(BetaManagedAgentsSystemContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSystemContentBlock(global::Anthropic.BetaManagedAgentsTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSystemContentBlock FromText(global::Anthropic.BetaManagedAgentsTextBlock? value) => new BetaManagedAgentsSystemContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSystemContentBlock(
            global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTextBlock? text
            )
        {
            Type = type;

            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsTextBlock, TResult>? text = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsTextBlock>? text = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsTextBlock>? text = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.BetaManagedAgentsTextBlock),
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
        public bool Equals(BetaManagedAgentsSystemContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTextBlock?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSystemContentBlock obj1, BetaManagedAgentsSystemContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSystemContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSystemContentBlock obj1, BetaManagedAgentsSystemContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSystemContentBlock o && Equals(o);
        }
    }
}
