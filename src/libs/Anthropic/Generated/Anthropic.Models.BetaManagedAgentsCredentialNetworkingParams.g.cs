#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsCredentialNetworkingParams : global::System.IEquatable<BetaManagedAgentsCredentialNetworkingParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Substitute the secret on any host the session's Environment network policy permits egress to. The Environment's network policy is the only boundary on where the secret can reach.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? Unrestricted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? Unrestricted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unrestricted))]
#endif
        public bool IsUnrestricted => Unrestricted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnrestricted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? value)
        {
            value = Unrestricted;
            return IsUnrestricted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams PickUnrestricted() => IsUnrestricted
            ? Unrestricted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unrestricted' but the value was {ToString()}.");

        /// <summary>
        /// Substitute the secret only on requests to the listed hosts.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? Limited { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? Limited { get; }
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
        public bool TryPickLimited(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? value)
        {
            value = Limited;
            return IsLimited;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams PickLimited() => IsLimited
            ? Limited!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Limited' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialNetworkingParams(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams value) => new BetaManagedAgentsCredentialNetworkingParams((global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams?(BetaManagedAgentsCredentialNetworkingParams @this) => @this.Unrestricted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialNetworkingParams(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? value)
        {
            Unrestricted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialNetworkingParams FromUnrestricted(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? value) => new BetaManagedAgentsCredentialNetworkingParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialNetworkingParams(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams value) => new BetaManagedAgentsCredentialNetworkingParams((global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams?(BetaManagedAgentsCredentialNetworkingParams @this) => @this.Limited;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialNetworkingParams(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? value)
        {
            Limited = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialNetworkingParams FromLimited(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? value) => new BetaManagedAgentsCredentialNetworkingParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialNetworkingParams(
            global::Anthropic.BetaManagedAgentsCredentialNetworkingParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams? unrestricted,
            global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams? limited
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
            global::System.Func<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams, TResult>? unrestricted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams, TResult>? limited = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams>? unrestricted = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams>? limited = null,
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
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams>? unrestricted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams>? limited = null,
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
                typeof(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams),
                Limited,
                typeof(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams),
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
        public bool Equals(BetaManagedAgentsCredentialNetworkingParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingParams?>.Default.Equals(Unrestricted, other.Unrestricted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParams?>.Default.Equals(Limited, other.Limited) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCredentialNetworkingParams obj1, BetaManagedAgentsCredentialNetworkingParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCredentialNetworkingParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCredentialNetworkingParams obj1, BetaManagedAgentsCredentialNetworkingParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCredentialNetworkingParams o && Equals(o);
        }
    }
}
