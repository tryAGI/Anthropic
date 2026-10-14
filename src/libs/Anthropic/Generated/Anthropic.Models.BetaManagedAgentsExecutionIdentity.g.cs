#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Execution principal for runs of this agent as returned in API responses.
    /// </summary>
    public readonly partial struct BetaManagedAgentsExecutionIdentity : global::System.IEquatable<BetaManagedAgentsExecutionIdentity>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminatorType? Type { get; }

        /// <summary>
        /// An AWS IAM role principal as returned in API responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? AwsRole { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? AwsRole { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AwsRole))]
#endif
        public bool IsAwsRole => AwsRole != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAwsRole(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? value)
        {
            value = AwsRole;
            return IsAwsRole;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity PickAwsRole() => AwsRole is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AwsRole' but the value was {ToString()}.");

        /// <summary>
        /// The Anthropic-managed service account as returned in API responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? ServiceAccount { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? ServiceAccount { get; }
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
            out global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? value)
        {
            value = ServiceAccount;
            return IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity PickServiceAccount() => ServiceAccount is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccount' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsExecutionIdentity(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity value) => new BetaManagedAgentsExecutionIdentity((global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity?(BetaManagedAgentsExecutionIdentity @this) => @this.AwsRole;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsExecutionIdentity(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? value)
        {
            AwsRole = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsExecutionIdentity FromAwsRole(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? value) => new BetaManagedAgentsExecutionIdentity(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsExecutionIdentity(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity value) => new BetaManagedAgentsExecutionIdentity((global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity?(BetaManagedAgentsExecutionIdentity @this) => @this.ServiceAccount;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsExecutionIdentity(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsExecutionIdentity FromServiceAccount(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? value) => new BetaManagedAgentsExecutionIdentity(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsExecutionIdentity(
            global::Anthropic.BetaManagedAgentsExecutionIdentityDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity? awsRole,
            global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity? serviceAccount
            )
        {
            Type = type;

            AwsRole = awsRole;
            ServiceAccount = serviceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ServiceAccount as object ??
            AwsRole as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AwsRole?.ToString() ??
            ServiceAccount?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAwsRole && !IsServiceAccount || !IsAwsRole && IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity, TResult>? awsRole = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity, TResult>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AwsRole is { } __value0 && awsRole != null)
            {
                return awsRole(__value0);
            }
            else if (ServiceAccount is { } __value1 && serviceAccount != null)
            {
                return serviceAccount(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity>? awsRole = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AwsRole is { } __value0)
            {
                awsRole?.Invoke(__value0);
            }
            else if (ServiceAccount is { } __value1)
            {
                serviceAccount?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity>? awsRole = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AwsRole is { } __value0)
            {
                awsRole?.Invoke(__value0);
            }
            else if (ServiceAccount is { } __value1)
            {
                serviceAccount?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AwsRole,
                typeof(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity),
                ServiceAccount,
                typeof(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity),
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
        public bool Equals(BetaManagedAgentsExecutionIdentity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentity?>.Default.Equals(AwsRole, other.AwsRole) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentity?>.Default.Equals(ServiceAccount, other.ServiceAccount)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsExecutionIdentity obj1, BetaManagedAgentsExecutionIdentity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsExecutionIdentity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsExecutionIdentity obj1, BetaManagedAgentsExecutionIdentity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsExecutionIdentity o && Equals(o);
        }
    }
}
