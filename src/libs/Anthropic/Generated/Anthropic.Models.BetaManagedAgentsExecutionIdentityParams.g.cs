#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Execution principal for runs of this agent: `service_account` (the default) or `aws_role`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsExecutionIdentityParams : global::System.IEquatable<BetaManagedAgentsExecutionIdentityParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// An AWS IAM role principal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? AwsRole { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? AwsRole { get; }
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
            out global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? value)
        {
            value = AwsRole;
            return IsAwsRole;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams PickAwsRole() => AwsRole is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AwsRole' but the value was {ToString()}.");

        /// <summary>
        /// The Anthropic-managed service account — the default execution principal. Carries no identifier.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? ServiceAccount { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? ServiceAccount { get; }
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
            out global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? value)
        {
            value = ServiceAccount;
            return IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams PickServiceAccount() => ServiceAccount is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccount' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsExecutionIdentityParams(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams value) => new BetaManagedAgentsExecutionIdentityParams((global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams?(BetaManagedAgentsExecutionIdentityParams @this) => @this.AwsRole;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsExecutionIdentityParams(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? value)
        {
            AwsRole = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsExecutionIdentityParams FromAwsRole(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? value) => new BetaManagedAgentsExecutionIdentityParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsExecutionIdentityParams(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams value) => new BetaManagedAgentsExecutionIdentityParams((global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams?(BetaManagedAgentsExecutionIdentityParams @this) => @this.ServiceAccount;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsExecutionIdentityParams(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsExecutionIdentityParams FromServiceAccount(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? value) => new BetaManagedAgentsExecutionIdentityParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsExecutionIdentityParams(
            global::Anthropic.BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams? awsRole,
            global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams? serviceAccount
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
            global::System.Func<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams, TResult>? awsRole = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams, TResult>? serviceAccount = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams>? awsRole = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams>? serviceAccount = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams>? awsRole = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams>? serviceAccount = null,
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
                typeof(global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams),
                ServiceAccount,
                typeof(global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams),
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
        public bool Equals(BetaManagedAgentsExecutionIdentityParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAwsRoleExecutionIdentityParams?>.Default.Equals(AwsRole, other.AwsRole) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsServiceAccountExecutionIdentityParams?>.Default.Equals(ServiceAccount, other.ServiceAccount)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsExecutionIdentityParams obj1, BetaManagedAgentsExecutionIdentityParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsExecutionIdentityParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsExecutionIdentityParams obj1, BetaManagedAgentsExecutionIdentityParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsExecutionIdentityParams o && Equals(o);
        }
    }
}
