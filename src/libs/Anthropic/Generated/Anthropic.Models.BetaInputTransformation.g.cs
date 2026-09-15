#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One entry of `input_transformations`: either a change the API made to the<br/>
    /// request's input before showing it to the model, or a block that failed a<br/>
    /// binding check and was still shown to the model unchanged. The `type` field<br/>
    /// says which.
    /// </summary>
    public readonly partial struct BetaInputTransformation : global::System.IEquatable<BetaInputTransformation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputTransformationDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingDroppedInputTransformation? ThinkingDropped { get; init; }
#else
        public global::Anthropic.BetaThinkingDroppedInputTransformation? ThinkingDropped { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingDropped))]
#endif
        public bool IsThinkingDropped => ThinkingDropped != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThinkingDropped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThinkingDroppedInputTransformation? value)
        {
            value = ThinkingDropped;
            return IsThinkingDropped;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingDroppedInputTransformation PickThinkingDropped() => IsThinkingDropped
            ? ThinkingDropped!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkingDropped' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? ThinkingMismatchAllowed { get; init; }
#else
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? ThinkingMismatchAllowed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingMismatchAllowed))]
#endif
        public bool IsThinkingMismatchAllowed => ThinkingMismatchAllowed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThinkingMismatchAllowed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? value)
        {
            value = ThinkingMismatchAllowed;
            return IsThinkingMismatchAllowed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingMismatchAllowedInputTransformation PickThinkingMismatchAllowed() => IsThinkingMismatchAllowed
            ? ThinkingMismatchAllowed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkingMismatchAllowed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputTransformation(global::Anthropic.BetaThinkingDroppedInputTransformation value) => new BetaInputTransformation((global::Anthropic.BetaThinkingDroppedInputTransformation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingDroppedInputTransformation?(BetaInputTransformation @this) => @this.ThinkingDropped;

        /// <summary>
        ///
        /// </summary>
        public BetaInputTransformation(global::Anthropic.BetaThinkingDroppedInputTransformation? value)
        {
            ThinkingDropped = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputTransformation FromThinkingDropped(global::Anthropic.BetaThinkingDroppedInputTransformation? value) => new BetaInputTransformation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputTransformation(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation value) => new BetaInputTransformation((global::Anthropic.BetaThinkingMismatchAllowedInputTransformation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingMismatchAllowedInputTransformation?(BetaInputTransformation @this) => @this.ThinkingMismatchAllowed;

        /// <summary>
        ///
        /// </summary>
        public BetaInputTransformation(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? value)
        {
            ThinkingMismatchAllowed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputTransformation FromThinkingMismatchAllowed(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? value) => new BetaInputTransformation(value);

        /// <summary>
        ///
        /// </summary>
        public BetaInputTransformation(
            global::Anthropic.BetaInputTransformationDiscriminatorType? type,
            global::Anthropic.BetaThinkingDroppedInputTransformation? thinkingDropped,
            global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? thinkingMismatchAllowed
            )
        {
            Type = type;

            ThinkingDropped = thinkingDropped;
            ThinkingMismatchAllowed = thinkingMismatchAllowed;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ThinkingMismatchAllowed as object ??
            ThinkingDropped as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ThinkingDropped?.ToString() ??
            ThinkingMismatchAllowed?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsThinkingDropped && !IsThinkingMismatchAllowed || !IsThinkingDropped && IsThinkingMismatchAllowed;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaThinkingDroppedInputTransformation, TResult>? thinkingDropped = null,
            global::System.Func<global::Anthropic.BetaThinkingMismatchAllowedInputTransformation, TResult>? thinkingMismatchAllowed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingDropped && thinkingDropped != null)
            {
                return thinkingDropped(ThinkingDropped!);
            }
            else if (IsThinkingMismatchAllowed && thinkingMismatchAllowed != null)
            {
                return thinkingMismatchAllowed(ThinkingMismatchAllowed!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaThinkingDroppedInputTransformation>? thinkingDropped = null,

            global::System.Action<global::Anthropic.BetaThinkingMismatchAllowedInputTransformation>? thinkingMismatchAllowed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingDropped)
            {
                thinkingDropped?.Invoke(ThinkingDropped!);
            }
            else if (IsThinkingMismatchAllowed)
            {
                thinkingMismatchAllowed?.Invoke(ThinkingMismatchAllowed!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaThinkingDroppedInputTransformation>? thinkingDropped = null,
            global::System.Action<global::Anthropic.BetaThinkingMismatchAllowedInputTransformation>? thinkingMismatchAllowed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingDropped)
            {
                thinkingDropped?.Invoke(ThinkingDropped!);
            }
            else if (IsThinkingMismatchAllowed)
            {
                thinkingMismatchAllowed?.Invoke(ThinkingMismatchAllowed!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ThinkingDropped,
                typeof(global::Anthropic.BetaThinkingDroppedInputTransformation),
                ThinkingMismatchAllowed,
                typeof(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation),
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
        public bool Equals(BetaInputTransformation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingDroppedInputTransformation?>.Default.Equals(ThinkingDropped, other.ThinkingDropped) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingMismatchAllowedInputTransformation?>.Default.Equals(ThinkingMismatchAllowed, other.ThinkingMismatchAllowed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaInputTransformation obj1, BetaInputTransformation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputTransformation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaInputTransformation obj1, BetaInputTransformation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputTransformation o && Equals(o);
        }
    }
}
