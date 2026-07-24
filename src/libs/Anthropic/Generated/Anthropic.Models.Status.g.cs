#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether the fallback-credit reprice was applied to this response's billing.<br/>
    /// A union discriminated on `type`. `redeemed`: the retry is billed as if<br/>
    /// the conversation had been on the retry model all along — including when the<br/>
    /// resulting shift is zero because there was nothing to move. `not_applied`:<br/>
    /// no reprice was applied; the arm's `reason` says why.
    /// </summary>
    public readonly partial struct Status : global::System.IEquatable<Status>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// The reprice was applied: the retry is billed as if the conversation<br/>
        /// had been on the retry model all along.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaFallbackCreditRedeemed? Redeemed { get; init; }
#else
        public global::Anthropic.BetaFallbackCreditRedeemed? Redeemed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Redeemed))]
#endif
        public bool IsRedeemed => Redeemed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRedeemed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaFallbackCreditRedeemed? value)
        {
            value = Redeemed;
            return IsRedeemed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaFallbackCreditRedeemed PickRedeemed() => IsRedeemed
            ? Redeemed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Redeemed' but the value was {ToString()}.");

        /// <summary>
        /// No reprice was applied; ``reason`` says why.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaFallbackCreditNotApplied? NotApplied { get; init; }
#else
        public global::Anthropic.BetaFallbackCreditNotApplied? NotApplied { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NotApplied))]
#endif
        public bool IsNotApplied => NotApplied != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNotApplied(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaFallbackCreditNotApplied? value)
        {
            value = NotApplied;
            return IsNotApplied;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaFallbackCreditNotApplied PickNotApplied() => IsNotApplied
            ? NotApplied!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotApplied' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Status(global::Anthropic.BetaFallbackCreditRedeemed value) => new Status((global::Anthropic.BetaFallbackCreditRedeemed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaFallbackCreditRedeemed?(Status @this) => @this.Redeemed;

        /// <summary>
        /// 
        /// </summary>
        public Status(global::Anthropic.BetaFallbackCreditRedeemed? value)
        {
            Redeemed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Status FromRedeemed(global::Anthropic.BetaFallbackCreditRedeemed? value) => new Status(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Status(global::Anthropic.BetaFallbackCreditNotApplied value) => new Status((global::Anthropic.BetaFallbackCreditNotApplied?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaFallbackCreditNotApplied?(Status @this) => @this.NotApplied;

        /// <summary>
        /// 
        /// </summary>
        public Status(global::Anthropic.BetaFallbackCreditNotApplied? value)
        {
            NotApplied = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Status FromNotApplied(global::Anthropic.BetaFallbackCreditNotApplied? value) => new Status(value);

        /// <summary>
        /// 
        /// </summary>
        public Status(
            global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType? type,
            global::Anthropic.BetaFallbackCreditRedeemed? redeemed,
            global::Anthropic.BetaFallbackCreditNotApplied? notApplied
            )
        {
            Type = type;

            Redeemed = redeemed;
            NotApplied = notApplied;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NotApplied as object ??
            Redeemed as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Redeemed?.ToString() ??
            NotApplied?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRedeemed && !IsNotApplied || !IsRedeemed && IsNotApplied;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaFallbackCreditRedeemed, TResult>? redeemed = null,
            global::System.Func<global::Anthropic.BetaFallbackCreditNotApplied, TResult>? notApplied = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRedeemed && redeemed != null)
            {
                return redeemed(Redeemed!);
            }
            else if (IsNotApplied && notApplied != null)
            {
                return notApplied(NotApplied!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaFallbackCreditRedeemed>? redeemed = null,

            global::System.Action<global::Anthropic.BetaFallbackCreditNotApplied>? notApplied = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRedeemed)
            {
                redeemed?.Invoke(Redeemed!);
            }
            else if (IsNotApplied)
            {
                notApplied?.Invoke(NotApplied!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaFallbackCreditRedeemed>? redeemed = null,
            global::System.Action<global::Anthropic.BetaFallbackCreditNotApplied>? notApplied = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRedeemed)
            {
                redeemed?.Invoke(Redeemed!);
            }
            else if (IsNotApplied)
            {
                notApplied?.Invoke(NotApplied!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Redeemed,
                typeof(global::Anthropic.BetaFallbackCreditRedeemed),
                NotApplied,
                typeof(global::Anthropic.BetaFallbackCreditNotApplied),
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
        public bool Equals(Status other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaFallbackCreditRedeemed?>.Default.Equals(Redeemed, other.Redeemed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaFallbackCreditNotApplied?>.Default.Equals(NotApplied, other.NotApplied) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Status obj1, Status obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Status>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Status obj1, Status obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Status o && Equals(o);
        }
    }
}
