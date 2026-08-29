#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Content block in an agent message.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentMessageContentBlock : global::System.IEquatable<BetaManagedAgentsAgentMessageContentBlock>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? Type { get; }

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
        /// Placeholder for content withheld by Anthropic model policy.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRedactedBlock? Redacted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRedactedBlock? Redacted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Redacted))]
#endif
        public bool IsRedacted => Redacted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRedacted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsRedactedBlock? value)
        {
            value = Redacted;
            return IsRedacted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRedactedBlock PickRedacted() => IsRedacted
            ? Redacted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Redacted' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentMessageContentBlock(global::Anthropic.BetaManagedAgentsTextBlock value) => new BetaManagedAgentsAgentMessageContentBlock((global::Anthropic.BetaManagedAgentsTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTextBlock?(BetaManagedAgentsAgentMessageContentBlock @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentMessageContentBlock(global::Anthropic.BetaManagedAgentsTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentMessageContentBlock FromText(global::Anthropic.BetaManagedAgentsTextBlock? value) => new BetaManagedAgentsAgentMessageContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentMessageContentBlock(global::Anthropic.BetaManagedAgentsRedactedBlock value) => new BetaManagedAgentsAgentMessageContentBlock((global::Anthropic.BetaManagedAgentsRedactedBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRedactedBlock?(BetaManagedAgentsAgentMessageContentBlock @this) => @this.Redacted;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentMessageContentBlock(global::Anthropic.BetaManagedAgentsRedactedBlock? value)
        {
            Redacted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentMessageContentBlock FromRedacted(global::Anthropic.BetaManagedAgentsRedactedBlock? value) => new BetaManagedAgentsAgentMessageContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentMessageContentBlock(
            global::Anthropic.BetaManagedAgentsAgentMessageContentBlockDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTextBlock? text,
            global::Anthropic.BetaManagedAgentsRedactedBlock? redacted
            )
        {
            Type = type;

            Text = text;
            Redacted = redacted;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Redacted as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Redacted?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsRedacted || !IsText && IsRedacted;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsTextBlock, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRedactedBlock, TResult>? redacted = null,
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
            else if (IsRedacted && redacted != null)
            {
                return redacted(Redacted!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsTextBlock>? text = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsRedactedBlock>? redacted = null,
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
            else if (IsRedacted)
            {
                redacted?.Invoke(Redacted!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsTextBlock>? text = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRedactedBlock>? redacted = null,
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
            else if (IsRedacted)
            {
                redacted?.Invoke(Redacted!);
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
                Redacted,
                typeof(global::Anthropic.BetaManagedAgentsRedactedBlock),
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
        public bool Equals(BetaManagedAgentsAgentMessageContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRedactedBlock?>.Default.Equals(Redacted, other.Redacted)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentMessageContentBlock obj1, BetaManagedAgentsAgentMessageContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentMessageContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentMessageContentBlock obj1, BetaManagedAgentsAgentMessageContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentMessageContentBlock o && Equals(o);
        }
    }
}
