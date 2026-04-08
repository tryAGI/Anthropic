#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Network configuration policy.
    /// </summary>
    public readonly partial struct Networking : global::System.IEquatable<Networking>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCloudConfigNetworkingDiscriminatorType? Type { get; }

        /// <summary>
        /// Unrestricted network access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaUnrestrictedNetwork? Unrestricted { get; init; }
#else
        public global::Anthropic.BetaUnrestrictedNetwork? Unrestricted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unrestricted))]
#endif
        public bool IsUnrestricted => Unrestricted != null;

        /// <summary>
        /// Limited network access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaLimitedNetwork? Limited { get; init; }
#else
        public global::Anthropic.BetaLimitedNetwork? Limited { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Limited))]
#endif
        public bool IsLimited => Limited != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Networking(global::Anthropic.BetaUnrestrictedNetwork value) => new Networking((global::Anthropic.BetaUnrestrictedNetwork?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaUnrestrictedNetwork?(Networking @this) => @this.Unrestricted;

        /// <summary>
        /// 
        /// </summary>
        public Networking(global::Anthropic.BetaUnrestrictedNetwork? value)
        {
            Unrestricted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Networking(global::Anthropic.BetaLimitedNetwork value) => new Networking((global::Anthropic.BetaLimitedNetwork?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaLimitedNetwork?(Networking @this) => @this.Limited;

        /// <summary>
        /// 
        /// </summary>
        public Networking(global::Anthropic.BetaLimitedNetwork? value)
        {
            Limited = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Networking(
            global::Anthropic.BetaCloudConfigNetworkingDiscriminatorType? type,
            global::Anthropic.BetaUnrestrictedNetwork? unrestricted,
            global::Anthropic.BetaLimitedNetwork? limited
            )
        {
            Type = type;

            Unrestricted = unrestricted;
            Limited = limited;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Limited as object ??
            Unrestricted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Unrestricted?.ToString() ??
            Limited?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnrestricted && !IsLimited || !IsUnrestricted && IsLimited;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaUnrestrictedNetwork?, TResult>? unrestricted = null,
            global::System.Func<global::Anthropic.BetaLimitedNetwork?, TResult>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted && unrestricted != null)
            {
                return unrestricted(Unrestricted!);
            }
            else if (IsLimited && limited != null)
            {
                return limited(Limited!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaUnrestrictedNetwork?>? unrestricted = null,
            global::System.Action<global::Anthropic.BetaLimitedNetwork?>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted)
            {
                unrestricted?.Invoke(Unrestricted!);
            }
            else if (IsLimited)
            {
                limited?.Invoke(Limited!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Unrestricted,
                typeof(global::Anthropic.BetaUnrestrictedNetwork),
                Limited,
                typeof(global::Anthropic.BetaLimitedNetwork),
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
        public bool Equals(Networking other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaUnrestrictedNetwork?>.Default.Equals(Unrestricted, other.Unrestricted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaLimitedNetwork?>.Default.Equals(Limited, other.Limited) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Networking obj1, Networking obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Networking>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Networking obj1, Networking obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Networking o && Equals(o);
        }
    }
}
