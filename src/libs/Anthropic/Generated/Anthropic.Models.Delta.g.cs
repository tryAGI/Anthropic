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
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingContentBlockDelta? ThinkingDelta { get; init; }
#else
        public global::Anthropic.BetaThinkingContentBlockDelta? ThinkingDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingDelta))]
#endif
        public bool IsThinkingDelta => ThinkingDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::Anthropic.BetaThinkingContentBlockDelta value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingContentBlockDelta?(Delta @this) => @this.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::Anthropic.BetaThinkingContentBlockDelta? value)
        {
            ThinkingDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaSignatureContentBlockDelta? SignatureDelta { get; init; }
#else
        public global::Anthropic.BetaSignatureContentBlockDelta? SignatureDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SignatureDelta))]
#endif
        public bool IsSignatureDelta => SignatureDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta(global::Anthropic.BetaSignatureContentBlockDelta value) => new Delta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaSignatureContentBlockDelta?(Delta @this) => @this.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta(global::Anthropic.BetaSignatureContentBlockDelta? value)
        {
            SignatureDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Delta(
            global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType? type,
            global::Anthropic.BetaTextContentBlockDelta? textDelta,
            global::Anthropic.BetaInputJsonContentBlockDelta? inputJsonDelta,
            global::Anthropic.BetaCitationsDelta? citationsDelta,
            global::Anthropic.BetaThinkingContentBlockDelta? thinkingDelta,
            global::Anthropic.BetaSignatureContentBlockDelta? signatureDelta
            )
        {
            Type = type;

            TextDelta = textDelta;
            InputJsonDelta = inputJsonDelta;
            CitationsDelta = citationsDelta;
            ThinkingDelta = thinkingDelta;
            SignatureDelta = signatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SignatureDelta as object ??
            ThinkingDelta as object ??
            CitationsDelta as object ??
            InputJsonDelta as object ??
            TextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && IsSignatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTextContentBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::Anthropic.BetaInputJsonContentBlockDelta?, TResult>? inputJsonDelta = null,
            global::System.Func<global::Anthropic.BetaCitationsDelta?, TResult>? citationsDelta = null,
            global::System.Func<global::Anthropic.BetaThinkingContentBlockDelta?, TResult>? thinkingDelta = null,
            global::System.Func<global::Anthropic.BetaSignatureContentBlockDelta?, TResult>? signatureDelta = null,
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
            else if (IsThinkingDelta && thinkingDelta != null)
            {
                return thinkingDelta(ThinkingDelta!);
            }
            else if (IsSignatureDelta && signatureDelta != null)
            {
                return signatureDelta(SignatureDelta!);
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
            global::System.Action<global::Anthropic.BetaThinkingContentBlockDelta?>? thinkingDelta = null,
            global::System.Action<global::Anthropic.BetaSignatureContentBlockDelta?>? signatureDelta = null,
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
            else if (IsThinkingDelta)
            {
                thinkingDelta?.Invoke(ThinkingDelta!);
            }
            else if (IsSignatureDelta)
            {
                signatureDelta?.Invoke(SignatureDelta!);
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
                ThinkingDelta,
                typeof(global::Anthropic.BetaThinkingContentBlockDelta),
                SignatureDelta,
                typeof(global::Anthropic.BetaSignatureContentBlockDelta),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCitationsDelta?>.Default.Equals(CitationsDelta, other.CitationsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingContentBlockDelta?>.Default.Equals(ThinkingDelta, other.ThinkingDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaSignatureContentBlockDelta?>.Default.Equals(SignatureDelta, other.SignatureDelta) 
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
