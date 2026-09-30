#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Who owns the Plugin: the organization, or the member whose personal plugin marketplace it lives in.
    /// </summary>
    public readonly partial struct Owner : global::System.IEquatable<Owner>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPluginOwnerOrganization? Organization { get; init; }
#else
        public global::Anthropic.BetaPluginOwnerOrganization? Organization { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Organization))]
#endif
        public bool IsOrganization => Organization != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOrganization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaPluginOwnerOrganization? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerOrganization PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPluginOwnerUser? User { get; init; }
#else
        public global::Anthropic.BetaPluginOwnerUser? User { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaPluginOwnerUser? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginOwnerUser PickUser() => User is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Owner(global::Anthropic.BetaPluginOwnerOrganization value) => new Owner((global::Anthropic.BetaPluginOwnerOrganization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPluginOwnerOrganization?(Owner @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Owner(global::Anthropic.BetaPluginOwnerOrganization? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Owner FromOrganization(global::Anthropic.BetaPluginOwnerOrganization? value) => new Owner(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Owner(global::Anthropic.BetaPluginOwnerUser value) => new Owner((global::Anthropic.BetaPluginOwnerUser?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPluginOwnerUser?(Owner @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public Owner(global::Anthropic.BetaPluginOwnerUser? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Owner FromUser(global::Anthropic.BetaPluginOwnerUser? value) => new Owner(value);

        /// <summary>
        ///
        /// </summary>
        public Owner(
            global::Anthropic.BetaPluginOwnerDiscriminatorType? type,
            global::Anthropic.BetaPluginOwnerOrganization? organization,
            global::Anthropic.BetaPluginOwnerUser? user
            )
        {
            Type = type;

            Organization = organization;
            User = user;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            User as object ??
            Organization as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Organization?.ToString() ??
            User?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOrganization && !IsUser || !IsOrganization && IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaPluginOwnerOrganization, TResult>? organization = null,
            global::System.Func<global::Anthropic.BetaPluginOwnerUser, TResult>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Organization is { } __value0 && organization != null)
            {
                return organization(__value0);
            }
            else if (User is { } __value1 && user != null)
            {
                return user(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaPluginOwnerOrganization>? organization = null,

            global::System.Action<global::Anthropic.BetaPluginOwnerUser>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Organization is { } __value0)
            {
                organization?.Invoke(__value0);
            }
            else if (User is { } __value1)
            {
                user?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaPluginOwnerOrganization>? organization = null,
            global::System.Action<global::Anthropic.BetaPluginOwnerUser>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Organization is { } __value0)
            {
                organization?.Invoke(__value0);
            }
            else if (User is { } __value1)
            {
                user?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Organization,
                typeof(global::Anthropic.BetaPluginOwnerOrganization),
                User,
                typeof(global::Anthropic.BetaPluginOwnerUser),
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
        public bool Equals(Owner other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPluginOwnerOrganization?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPluginOwnerUser?>.Default.Equals(User, other.User)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Owner obj1, Owner obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Owner>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Owner obj1, Owner obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Owner o && Equals(o);
        }
    }
}
