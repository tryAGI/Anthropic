#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaFederationRuleTarget : global::System.IEquatable<BetaFederationRuleTarget>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationRuleTargetDiscriminatorType? Type { get; }

        /// <summary>
        /// Bind to a fixed service account by ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaServiceAccountTarget? ServiceAccount { get; init; }
#else
        public global::Anthropic.BetaServiceAccountTarget? ServiceAccount { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServiceAccount))]
#endif
        public bool IsServiceAccount => ServiceAccount != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServiceAccount(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaServiceAccountTarget? value)
        {
            value = ServiceAccount;
            return IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaServiceAccountTarget PickServiceAccount() => ServiceAccount is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccount' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaFederationRuleTarget(global::Anthropic.BetaServiceAccountTarget value) => new BetaFederationRuleTarget((global::Anthropic.BetaServiceAccountTarget?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaServiceAccountTarget?(BetaFederationRuleTarget @this) => @this.ServiceAccount;

        /// <summary>
        ///
        /// </summary>
        public BetaFederationRuleTarget(global::Anthropic.BetaServiceAccountTarget? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaFederationRuleTarget FromServiceAccount(global::Anthropic.BetaServiceAccountTarget? value) => new BetaFederationRuleTarget(value);

        /// <summary>
        ///
        /// </summary>
        public BetaFederationRuleTarget(
            global::Anthropic.BetaFederationRuleTargetDiscriminatorType? type,
            global::Anthropic.BetaServiceAccountTarget? serviceAccount
            )
        {
            Type = type;

            ServiceAccount = serviceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ServiceAccount as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ServiceAccount?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaServiceAccountTarget, TResult>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ServiceAccount is { } __value0 && serviceAccount != null)
            {
                return serviceAccount(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaServiceAccountTarget>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ServiceAccount is { } __value0)
            {
                serviceAccount?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaServiceAccountTarget>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ServiceAccount is { } __value0)
            {
                serviceAccount?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ServiceAccount,
                typeof(global::Anthropic.BetaServiceAccountTarget),
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
        public bool Equals(BetaFederationRuleTarget other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaServiceAccountTarget?>.Default.Equals(ServiceAccount, other.ServiceAccount)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaFederationRuleTarget obj1, BetaFederationRuleTarget obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaFederationRuleTarget>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaFederationRuleTarget obj1, BetaFederationRuleTarget obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaFederationRuleTarget o && Equals(o);
        }
    }
}
