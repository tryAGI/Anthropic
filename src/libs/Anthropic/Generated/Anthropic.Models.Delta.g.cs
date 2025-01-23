#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Delta : global::System.IEquatable<Delta>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTextContentBlockDelta? TextDelta { get; init; }
#else
        public global::Anthropic.BetaTextContentBlockDelta? TextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::Anthropic.BetaTextContentBlockDelta value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextContentBlockDelta?(Delta @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::Anthropic.BetaTextContentBlockDelta? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaInputJsonContentBlockDelta? InputJsonDelta { get; init; }
#else
        public global::Anthropic.BetaInputJsonContentBlockDelta? InputJsonDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputJsonDelta))]
#endif
        public bool IsInputJsonDelta => InputJsonDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::Anthropic.BetaInputJsonContentBlockDelta value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaInputJsonContentBlockDelta?(Delta @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::Anthropic.BetaInputJsonContentBlockDelta? value)
        {
            InputJsonDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCitationsDelta? CitationsDelta { get; init; }
#else
        public global::Anthropic.BetaCitationsDelta? CitationsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationsDelta))]
#endif
        public bool IsCitationsDelta => CitationsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::Anthropic.BetaCitationsDelta value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCitationsDelta?(Delta @this) => @this.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::Anthropic.BetaCitationsDelta? value)
        {
            CitationsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Delta(
            global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? type,
            global::Anthropic.BetaTextContentBlockDelta? textDelta,
            global::Anthropic.BetaInputJsonContentBlockDelta? inputJsonDelta,
            global::Anthropic.BetaCitationsDelta? citationsDelta
            )
        {
            Type = type;

            TextDelta = textDelta;
            InputJsonDelta = inputJsonDelta;
            CitationsDelta = citationsDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CitationsDelta as object ??
            InputJsonDelta as object ??
            TextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta || !IsTextDelta && IsInputJsonDelta && !IsCitationsDelta || !IsTextDelta && !IsInputJsonDelta && IsCitationsDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTextContentBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::Anthropic.BetaInputJsonContentBlockDelta?, TResult>? inputJsonDelta = null,
            global::System.Func<global::Anthropic.BetaCitationsDelta?, TResult>? citationsDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta && textDelta != null)
            {
                return textDelta(TextDelta!);
            }
            else if (IsInputJsonDelta && inputJsonDelta != null)
            {
                return inputJsonDelta(InputJsonDelta!);
            }
            else if (IsCitationsDelta && citationsDelta != null)
            {
                return citationsDelta(CitationsDelta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaTextContentBlockDelta?>? textDelta = null,
            global::System.Action<global::Anthropic.BetaInputJsonContentBlockDelta?>? inputJsonDelta = null,
            global::System.Action<global::Anthropic.BetaCitationsDelta?>? citationsDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsInputJsonDelta)
            {
                inputJsonDelta?.Invoke(InputJsonDelta!);
            }
            else if (IsCitationsDelta)
            {
                citationsDelta?.Invoke(CitationsDelta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextDelta,
                typeof(global::Anthropic.BetaTextContentBlockDelta),
                InputJsonDelta,
                typeof(global::Anthropic.BetaInputJsonContentBlockDelta),
                CitationsDelta,
                typeof(global::Anthropic.BetaCitationsDelta),
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
        public bool Equals(Delta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextContentBlockDelta?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaInputJsonContentBlockDelta?>.Default.Equals(InputJsonDelta, other.InputJsonDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCitationsDelta?>.Default.Equals(CitationsDelta, other.CitationsDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Delta obj1, Delta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Delta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Delta obj1, Delta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Delta o && Equals(o);
        }
    }
}
