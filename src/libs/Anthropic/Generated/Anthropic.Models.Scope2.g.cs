#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the limit applies to. A tagged union on `type`; each variant carries the identifier for its scope.
    /// </summary>
    public readonly partial struct Scope2 : global::System.IEquatable<Scope2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSpendLimitScopeDiscriminatorType? Type { get; }

        /// <summary>
        /// Scope selecting a single member of the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaUserScope? User { get; init; }
#else
        public global::Anthropic.BetaUserScope? User { get; }
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
            out global::Anthropic.BetaUserScope? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserScope PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaSeatTierScope? SeatTier { get; init; }
#else
        public global::Anthropic.BetaSeatTierScope? SeatTier { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SeatTier))]
#endif
        public bool IsSeatTier => SeatTier != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSeatTier(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaSeatTierScope? value)
        {
            value = SeatTier;
            return IsSeatTier;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSeatTierScope PickSeatTier() => IsSeatTier
            ? SeatTier!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SeatTier' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRbacGroupScope? RbacGroup { get; init; }
#else
        public global::Anthropic.BetaRbacGroupScope? RbacGroup { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RbacGroup))]
#endif
        public bool IsRbacGroup => RbacGroup != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRbacGroup(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRbacGroupScope? value)
        {
            value = RbacGroup;
            return IsRbacGroup;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacGroupScope PickRbacGroup() => IsRbacGroup
            ? RbacGroup!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RbacGroup' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaOrgServiceScope? OrganizationService { get; init; }
#else
        public global::Anthropic.BetaOrgServiceScope? OrganizationService { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationService))]
#endif
        public bool IsOrganizationService => OrganizationService != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOrganizationService(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaOrgServiceScope? value)
        {
            value = OrganizationService;
            return IsOrganizationService;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrgServiceScope PickOrganizationService() => IsOrganizationService
            ? OrganizationService!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationService' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaOrganizationScope? Organization { get; init; }
#else
        public global::Anthropic.BetaOrganizationScope? Organization { get; }
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
            out global::Anthropic.BetaOrganizationScope? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationScope PickOrganization() => IsOrganization
            ? Organization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope2(global::Anthropic.BetaUserScope value) => new Scope2((global::Anthropic.BetaUserScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaUserScope?(Scope2 @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public Scope2(global::Anthropic.BetaUserScope? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope2 FromUser(global::Anthropic.BetaUserScope? value) => new Scope2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope2(global::Anthropic.BetaSeatTierScope value) => new Scope2((global::Anthropic.BetaSeatTierScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaSeatTierScope?(Scope2 @this) => @this.SeatTier;

        /// <summary>
        ///
        /// </summary>
        public Scope2(global::Anthropic.BetaSeatTierScope? value)
        {
            SeatTier = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope2 FromSeatTier(global::Anthropic.BetaSeatTierScope? value) => new Scope2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope2(global::Anthropic.BetaRbacGroupScope value) => new Scope2((global::Anthropic.BetaRbacGroupScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRbacGroupScope?(Scope2 @this) => @this.RbacGroup;

        /// <summary>
        ///
        /// </summary>
        public Scope2(global::Anthropic.BetaRbacGroupScope? value)
        {
            RbacGroup = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope2 FromRbacGroup(global::Anthropic.BetaRbacGroupScope? value) => new Scope2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope2(global::Anthropic.BetaOrgServiceScope value) => new Scope2((global::Anthropic.BetaOrgServiceScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaOrgServiceScope?(Scope2 @this) => @this.OrganizationService;

        /// <summary>
        ///
        /// </summary>
        public Scope2(global::Anthropic.BetaOrgServiceScope? value)
        {
            OrganizationService = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope2 FromOrganizationService(global::Anthropic.BetaOrgServiceScope? value) => new Scope2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope2(global::Anthropic.BetaOrganizationScope value) => new Scope2((global::Anthropic.BetaOrganizationScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaOrganizationScope?(Scope2 @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Scope2(global::Anthropic.BetaOrganizationScope? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope2 FromOrganization(global::Anthropic.BetaOrganizationScope? value) => new Scope2(value);

        /// <summary>
        ///
        /// </summary>
        public Scope2(
            global::Anthropic.BetaSpendLimitScopeDiscriminatorType? type,
            global::Anthropic.BetaUserScope? user,
            global::Anthropic.BetaSeatTierScope? seatTier,
            global::Anthropic.BetaRbacGroupScope? rbacGroup,
            global::Anthropic.BetaOrgServiceScope? organizationService,
            global::Anthropic.BetaOrganizationScope? organization
            )
        {
            Type = type;

            User = user;
            SeatTier = seatTier;
            RbacGroup = rbacGroup;
            OrganizationService = organizationService;
            Organization = organization;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Organization as object ??
            OrganizationService as object ??
            RbacGroup as object ??
            SeatTier as object ??
            User as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            SeatTier?.ToString() ??
            RbacGroup?.ToString() ??
            OrganizationService?.ToString() ??
            Organization?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsSeatTier && !IsRbacGroup && !IsOrganizationService && !IsOrganization || !IsUser && IsSeatTier && !IsRbacGroup && !IsOrganizationService && !IsOrganization || !IsUser && !IsSeatTier && IsRbacGroup && !IsOrganizationService && !IsOrganization || !IsUser && !IsSeatTier && !IsRbacGroup && IsOrganizationService && !IsOrganization || !IsUser && !IsSeatTier && !IsRbacGroup && !IsOrganizationService && IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaUserScope, TResult>? user = null,
            global::System.Func<global::Anthropic.BetaSeatTierScope, TResult>? seatTier = null,
            global::System.Func<global::Anthropic.BetaRbacGroupScope, TResult>? rbacGroup = null,
            global::System.Func<global::Anthropic.BetaOrgServiceScope, TResult>? organizationService = null,
            global::System.Func<global::Anthropic.BetaOrganizationScope, TResult>? organization = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsSeatTier && seatTier != null)
            {
                return seatTier(SeatTier!);
            }
            else if (IsRbacGroup && rbacGroup != null)
            {
                return rbacGroup(RbacGroup!);
            }
            else if (IsOrganizationService && organizationService != null)
            {
                return organizationService(OrganizationService!);
            }
            else if (IsOrganization && organization != null)
            {
                return organization(Organization!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaUserScope>? user = null,

            global::System.Action<global::Anthropic.BetaSeatTierScope>? seatTier = null,

            global::System.Action<global::Anthropic.BetaRbacGroupScope>? rbacGroup = null,

            global::System.Action<global::Anthropic.BetaOrgServiceScope>? organizationService = null,

            global::System.Action<global::Anthropic.BetaOrganizationScope>? organization = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsSeatTier)
            {
                seatTier?.Invoke(SeatTier!);
            }
            else if (IsRbacGroup)
            {
                rbacGroup?.Invoke(RbacGroup!);
            }
            else if (IsOrganizationService)
            {
                organizationService?.Invoke(OrganizationService!);
            }
            else if (IsOrganization)
            {
                organization?.Invoke(Organization!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaUserScope>? user = null,
            global::System.Action<global::Anthropic.BetaSeatTierScope>? seatTier = null,
            global::System.Action<global::Anthropic.BetaRbacGroupScope>? rbacGroup = null,
            global::System.Action<global::Anthropic.BetaOrgServiceScope>? organizationService = null,
            global::System.Action<global::Anthropic.BetaOrganizationScope>? organization = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsSeatTier)
            {
                seatTier?.Invoke(SeatTier!);
            }
            else if (IsRbacGroup)
            {
                rbacGroup?.Invoke(RbacGroup!);
            }
            else if (IsOrganizationService)
            {
                organizationService?.Invoke(OrganizationService!);
            }
            else if (IsOrganization)
            {
                organization?.Invoke(Organization!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::Anthropic.BetaUserScope),
                SeatTier,
                typeof(global::Anthropic.BetaSeatTierScope),
                RbacGroup,
                typeof(global::Anthropic.BetaRbacGroupScope),
                OrganizationService,
                typeof(global::Anthropic.BetaOrgServiceScope),
                Organization,
                typeof(global::Anthropic.BetaOrganizationScope),
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
        public bool Equals(Scope2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaUserScope?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaSeatTierScope?>.Default.Equals(SeatTier, other.SeatTier) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRbacGroupScope?>.Default.Equals(RbacGroup, other.RbacGroup) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOrgServiceScope?>.Default.Equals(OrganizationService, other.OrganizationService) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOrganizationScope?>.Default.Equals(Organization, other.Organization)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Scope2 obj1, Scope2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Scope2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Scope2 obj1, Scope2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Scope2 o && Equals(o);
        }
    }
}
