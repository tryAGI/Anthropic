#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ThreadVariant1 : global::System.IEquatable<ThreadVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsThreadVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Start holding conversation state under this response's ``id``.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThreadCreateParams? Create { get; init; }
#else
        public global::Anthropic.BetaThreadCreateParams? Create { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Create))]
#endif
        public bool IsCreate => Create != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThreadCreateParams? value)
        {
            value = Create;
            return IsCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadCreateParams PickCreate() => Create is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Create' but the value was {ToString()}.");

        /// <summary>
        /// Resume from the response named by ``previous_message_id``.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThreadContinueParams? Continue { get; init; }
#else
        public global::Anthropic.BetaThreadContinueParams? Continue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Continue))]
#endif
        public bool IsContinue => Continue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContinue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThreadContinueParams? value)
        {
            value = Continue;
            return IsContinue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThreadContinueParams PickContinue() => Continue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Continue' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ThreadVariant1(global::Anthropic.BetaThreadCreateParams value) => new ThreadVariant1((global::Anthropic.BetaThreadCreateParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThreadCreateParams?(ThreadVariant1 @this) => @this.Create;

        /// <summary>
        ///
        /// </summary>
        public ThreadVariant1(global::Anthropic.BetaThreadCreateParams? value)
        {
            Create = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ThreadVariant1 FromCreate(global::Anthropic.BetaThreadCreateParams? value) => new ThreadVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ThreadVariant1(global::Anthropic.BetaThreadContinueParams value) => new ThreadVariant1((global::Anthropic.BetaThreadContinueParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThreadContinueParams?(ThreadVariant1 @this) => @this.Continue;

        /// <summary>
        ///
        /// </summary>
        public ThreadVariant1(global::Anthropic.BetaThreadContinueParams? value)
        {
            Continue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ThreadVariant1 FromContinue(global::Anthropic.BetaThreadContinueParams? value) => new ThreadVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public ThreadVariant1(
            global::Anthropic.BetaCreateMessageParamsThreadVariant1DiscriminatorType? type,
            global::Anthropic.BetaThreadCreateParams? create,
            global::Anthropic.BetaThreadContinueParams? @continue
            )
        {
            Type = type;

            Create = create;
            Continue = @continue;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Continue as object ??
            Create as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Create?.ToString() ??
            Continue?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreate && !IsContinue || !IsCreate && IsContinue;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaThreadCreateParams, TResult>? create = null,
            global::System.Func<global::Anthropic.BetaThreadContinueParams, TResult>? @continue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Create is { } __value0 && create != null)
            {
                return create(__value0);
            }
            else if (Continue is { } __value1 && @continue != null)
            {
                return @continue(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaThreadCreateParams>? create = null,

            global::System.Action<global::Anthropic.BetaThreadContinueParams>? @continue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Create is { } __value0)
            {
                create?.Invoke(__value0);
            }
            else if (Continue is { } __value1)
            {
                @continue?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaThreadCreateParams>? create = null,
            global::System.Action<global::Anthropic.BetaThreadContinueParams>? @continue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Create is { } __value0)
            {
                create?.Invoke(__value0);
            }
            else if (Continue is { } __value1)
            {
                @continue?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Create,
                typeof(global::Anthropic.BetaThreadCreateParams),
                Continue,
                typeof(global::Anthropic.BetaThreadContinueParams),
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
        public bool Equals(ThreadVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThreadCreateParams?>.Default.Equals(Create, other.Create) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThreadContinueParams?>.Default.Equals(Continue, other.Continue)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ThreadVariant1 obj1, ThreadVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThreadVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ThreadVariant1 obj1, ThreadVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThreadVariant1 o && Equals(o);
        }
    }
}
