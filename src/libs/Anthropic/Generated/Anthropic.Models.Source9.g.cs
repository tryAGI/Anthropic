#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Source9 : global::System.IEquatable<Source9>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SpendSummarySourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Scope selecting a single member of the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.UserScope? User { get; init; }
#else
        public global::Anthropic.UserScope? User { get; }
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
            out global::Anthropic.UserScope? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserScope PickUser() => User is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.SeatTierScope? SeatTier { get; init; }
#else
        public global::Anthropic.SeatTierScope? SeatTier { get; }
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
            out global::Anthropic.SeatTierScope? value)
        {
            value = SeatTier;
            return IsSeatTier;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SeatTierScope PickSeatTier() => SeatTier is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SeatTier' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RbacGroupScope? RbacGroup { get; init; }
#else
        public global::Anthropic.RbacGroupScope? RbacGroup { get; }
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
            out global::Anthropic.RbacGroupScope? value)
        {
            value = RbacGroup;
            return IsRbacGroup;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacGroupScope PickRbacGroup() => RbacGroup is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RbacGroup' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OrgServiceScope? OrganizationService { get; init; }
#else
        public global::Anthropic.OrgServiceScope? OrganizationService { get; }
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
            out global::Anthropic.OrgServiceScope? value)
        {
            value = OrganizationService;
            return IsOrganizationService;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrgServiceScope PickOrganizationService() => OrganizationService is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationService' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OrganizationScope? Organization { get; init; }
#else
        public global::Anthropic.OrganizationScope? Organization { get; }
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
            out global::Anthropic.OrganizationScope? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationScope PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        /// Scope selecting one workspace of a Claude Console organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.WorkspaceScope? Workspace { get; init; }
#else
        public global::Anthropic.WorkspaceScope? Workspace { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Workspace))]
#endif
        public bool IsWorkspace => Workspace != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkspace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.WorkspaceScope? value)
        {
            value = Workspace;
            return IsWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceScope PickWorkspace() => Workspace is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Workspace' but the value was {ToString()}.");

        /// <summary>
        /// Scope of the monthly spend cap Anthropic sets for a Claude Console<br/>
        /// organization from its usage tier, or a higher cap Anthropic granted the<br/>
        /// organization. Read-only; its `created_at` and `updated_at` are the<br/>
        /// organization's creation time, so `amount` can change while `updated_at` stays<br/>
        /// the same.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.UsageTierScope? UsageTier { get; init; }
#else
        public global::Anthropic.UsageTierScope? UsageTier { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageTier))]
#endif
        public bool IsUsageTier => UsageTier != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUsageTier(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.UsageTierScope? value)
        {
            value = UsageTier;
            return IsUsageTier;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UsageTierScope PickUsageTier() => UsageTier is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UsageTier' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source9(global::Anthropic.UserScope value) => new Source9((global::Anthropic.UserScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.UserScope?(Source9 @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public Source9(global::Anthropic.UserScope? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source9 FromUser(global::Anthropic.UserScope? value) => new Source9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source9(global::Anthropic.SeatTierScope value) => new Source9((global::Anthropic.SeatTierScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.SeatTierScope?(Source9 @this) => @this.SeatTier;

        /// <summary>
        ///
        /// </summary>
        public Source9(global::Anthropic.SeatTierScope? value)
        {
            SeatTier = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source9 FromSeatTier(global::Anthropic.SeatTierScope? value) => new Source9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source9(global::Anthropic.RbacGroupScope value) => new Source9((global::Anthropic.RbacGroupScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RbacGroupScope?(Source9 @this) => @this.RbacGroup;

        /// <summary>
        ///
        /// </summary>
        public Source9(global::Anthropic.RbacGroupScope? value)
        {
            RbacGroup = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source9 FromRbacGroup(global::Anthropic.RbacGroupScope? value) => new Source9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source9(global::Anthropic.OrgServiceScope value) => new Source9((global::Anthropic.OrgServiceScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.OrgServiceScope?(Source9 @this) => @this.OrganizationService;

        /// <summary>
        ///
        /// </summary>
        public Source9(global::Anthropic.OrgServiceScope? value)
        {
            OrganizationService = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source9 FromOrganizationService(global::Anthropic.OrgServiceScope? value) => new Source9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source9(global::Anthropic.OrganizationScope value) => new Source9((global::Anthropic.OrganizationScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.OrganizationScope?(Source9 @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Source9(global::Anthropic.OrganizationScope? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source9 FromOrganization(global::Anthropic.OrganizationScope? value) => new Source9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source9(global::Anthropic.WorkspaceScope value) => new Source9((global::Anthropic.WorkspaceScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.WorkspaceScope?(Source9 @this) => @this.Workspace;

        /// <summary>
        ///
        /// </summary>
        public Source9(global::Anthropic.WorkspaceScope? value)
        {
            Workspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source9 FromWorkspace(global::Anthropic.WorkspaceScope? value) => new Source9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source9(global::Anthropic.UsageTierScope value) => new Source9((global::Anthropic.UsageTierScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.UsageTierScope?(Source9 @this) => @this.UsageTier;

        /// <summary>
        ///
        /// </summary>
        public Source9(global::Anthropic.UsageTierScope? value)
        {
            UsageTier = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source9 FromUsageTier(global::Anthropic.UsageTierScope? value) => new Source9(value);

        /// <summary>
        ///
        /// </summary>
        public Source9(
            global::Anthropic.SpendSummarySourceDiscriminatorType? type,
            global::Anthropic.UserScope? user,
            global::Anthropic.SeatTierScope? seatTier,
            global::Anthropic.RbacGroupScope? rbacGroup,
            global::Anthropic.OrgServiceScope? organizationService,
            global::Anthropic.OrganizationScope? organization,
            global::Anthropic.WorkspaceScope? workspace,
            global::Anthropic.UsageTierScope? usageTier
            )
        {
            Type = type;

            User = user;
            SeatTier = seatTier;
            RbacGroup = rbacGroup;
            OrganizationService = organizationService;
            Organization = organization;
            Workspace = workspace;
            UsageTier = usageTier;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UsageTier as object ??
            Workspace as object ??
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
            Organization?.ToString() ??
            Workspace?.ToString() ??
            UsageTier?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsSeatTier && !IsRbacGroup && !IsOrganizationService && !IsOrganization && !IsWorkspace && !IsUsageTier || !IsUser && IsSeatTier && !IsRbacGroup && !IsOrganizationService && !IsOrganization && !IsWorkspace && !IsUsageTier || !IsUser && !IsSeatTier && IsRbacGroup && !IsOrganizationService && !IsOrganization && !IsWorkspace && !IsUsageTier || !IsUser && !IsSeatTier && !IsRbacGroup && IsOrganizationService && !IsOrganization && !IsWorkspace && !IsUsageTier || !IsUser && !IsSeatTier && !IsRbacGroup && !IsOrganizationService && IsOrganization && !IsWorkspace && !IsUsageTier || !IsUser && !IsSeatTier && !IsRbacGroup && !IsOrganizationService && !IsOrganization && IsWorkspace && !IsUsageTier || !IsUser && !IsSeatTier && !IsRbacGroup && !IsOrganizationService && !IsOrganization && !IsWorkspace && IsUsageTier;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.UserScope, TResult>? user = null,
            global::System.Func<global::Anthropic.SeatTierScope, TResult>? seatTier = null,
            global::System.Func<global::Anthropic.RbacGroupScope, TResult>? rbacGroup = null,
            global::System.Func<global::Anthropic.OrgServiceScope, TResult>? organizationService = null,
            global::System.Func<global::Anthropic.OrganizationScope, TResult>? organization = null,
            global::System.Func<global::Anthropic.WorkspaceScope, TResult>? workspace = null,
            global::System.Func<global::Anthropic.UsageTierScope, TResult>? usageTier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0 && user != null)
            {
                return user(__value0);
            }
            else if (SeatTier is { } __value1 && seatTier != null)
            {
                return seatTier(__value1);
            }
            else if (RbacGroup is { } __value2 && rbacGroup != null)
            {
                return rbacGroup(__value2);
            }
            else if (OrganizationService is { } __value3 && organizationService != null)
            {
                return organizationService(__value3);
            }
            else if (Organization is { } __value4 && organization != null)
            {
                return organization(__value4);
            }
            else if (Workspace is { } __value5 && workspace != null)
            {
                return workspace(__value5);
            }
            else if (UsageTier is { } __value6 && usageTier != null)
            {
                return usageTier(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.UserScope>? user = null,

            global::System.Action<global::Anthropic.SeatTierScope>? seatTier = null,

            global::System.Action<global::Anthropic.RbacGroupScope>? rbacGroup = null,

            global::System.Action<global::Anthropic.OrgServiceScope>? organizationService = null,

            global::System.Action<global::Anthropic.OrganizationScope>? organization = null,

            global::System.Action<global::Anthropic.WorkspaceScope>? workspace = null,

            global::System.Action<global::Anthropic.UsageTierScope>? usageTier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0)
            {
                user?.Invoke(__value0);
            }
            else if (SeatTier is { } __value1)
            {
                seatTier?.Invoke(__value1);
            }
            else if (RbacGroup is { } __value2)
            {
                rbacGroup?.Invoke(__value2);
            }
            else if (OrganizationService is { } __value3)
            {
                organizationService?.Invoke(__value3);
            }
            else if (Organization is { } __value4)
            {
                organization?.Invoke(__value4);
            }
            else if (Workspace is { } __value5)
            {
                workspace?.Invoke(__value5);
            }
            else if (UsageTier is { } __value6)
            {
                usageTier?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.UserScope>? user = null,
            global::System.Action<global::Anthropic.SeatTierScope>? seatTier = null,
            global::System.Action<global::Anthropic.RbacGroupScope>? rbacGroup = null,
            global::System.Action<global::Anthropic.OrgServiceScope>? organizationService = null,
            global::System.Action<global::Anthropic.OrganizationScope>? organization = null,
            global::System.Action<global::Anthropic.WorkspaceScope>? workspace = null,
            global::System.Action<global::Anthropic.UsageTierScope>? usageTier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0)
            {
                user?.Invoke(__value0);
            }
            else if (SeatTier is { } __value1)
            {
                seatTier?.Invoke(__value1);
            }
            else if (RbacGroup is { } __value2)
            {
                rbacGroup?.Invoke(__value2);
            }
            else if (OrganizationService is { } __value3)
            {
                organizationService?.Invoke(__value3);
            }
            else if (Organization is { } __value4)
            {
                organization?.Invoke(__value4);
            }
            else if (Workspace is { } __value5)
            {
                workspace?.Invoke(__value5);
            }
            else if (UsageTier is { } __value6)
            {
                usageTier?.Invoke(__value6);
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
                typeof(global::Anthropic.UserScope),
                SeatTier,
                typeof(global::Anthropic.SeatTierScope),
                RbacGroup,
                typeof(global::Anthropic.RbacGroupScope),
                OrganizationService,
                typeof(global::Anthropic.OrgServiceScope),
                Organization,
                typeof(global::Anthropic.OrganizationScope),
                Workspace,
                typeof(global::Anthropic.WorkspaceScope),
                UsageTier,
                typeof(global::Anthropic.UsageTierScope),
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
        public bool Equals(Source9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.UserScope?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.SeatTierScope?>.Default.Equals(SeatTier, other.SeatTier) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RbacGroupScope?>.Default.Equals(RbacGroup, other.RbacGroup) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OrgServiceScope?>.Default.Equals(OrganizationService, other.OrganizationService) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OrganizationScope?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.WorkspaceScope?>.Default.Equals(Workspace, other.Workspace) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.UsageTierScope?>.Default.Equals(UsageTier, other.UsageTier)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Source9 obj1, Source9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Source9 obj1, Source9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source9 o && Equals(o);
        }
    }
}
