#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Who the Plugin is shared with: `organization` (every member), `rbac_group` (one RBAC Group), or `organization_member` (one member).
    /// </summary>
    public readonly partial struct Target3 : global::System.IEquatable<Target3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginShareTargetDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPluginTargetOrganization? Organization { get; init; }
#else
        public global::Anthropic.BetaPluginTargetOrganization? Organization { get; }
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
            out global::Anthropic.BetaPluginTargetOrganization? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganization PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPluginTargetRbacGroup? RbacGroup { get; init; }
#else
        public global::Anthropic.BetaPluginTargetRbacGroup? RbacGroup { get; }
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
            out global::Anthropic.BetaPluginTargetRbacGroup? value)
        {
            value = RbacGroup;
            return IsRbacGroup;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetRbacGroup PickRbacGroup() => RbacGroup is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RbacGroup' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPluginTargetOrganizationMember? OrganizationMember { get; init; }
#else
        public global::Anthropic.BetaPluginTargetOrganizationMember? OrganizationMember { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationMember))]
#endif
        public bool IsOrganizationMember => OrganizationMember != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOrganizationMember(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaPluginTargetOrganizationMember? value)
        {
            value = OrganizationMember;
            return IsOrganizationMember;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginTargetOrganizationMember PickOrganizationMember() => OrganizationMember is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationMember' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target3(global::Anthropic.BetaPluginTargetOrganization value) => new Target3((global::Anthropic.BetaPluginTargetOrganization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPluginTargetOrganization?(Target3 @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Target3(global::Anthropic.BetaPluginTargetOrganization? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target3 FromOrganization(global::Anthropic.BetaPluginTargetOrganization? value) => new Target3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target3(global::Anthropic.BetaPluginTargetRbacGroup value) => new Target3((global::Anthropic.BetaPluginTargetRbacGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPluginTargetRbacGroup?(Target3 @this) => @this.RbacGroup;

        /// <summary>
        ///
        /// </summary>
        public Target3(global::Anthropic.BetaPluginTargetRbacGroup? value)
        {
            RbacGroup = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target3 FromRbacGroup(global::Anthropic.BetaPluginTargetRbacGroup? value) => new Target3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Target3(global::Anthropic.BetaPluginTargetOrganizationMember value) => new Target3((global::Anthropic.BetaPluginTargetOrganizationMember?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPluginTargetOrganizationMember?(Target3 @this) => @this.OrganizationMember;

        /// <summary>
        ///
        /// </summary>
        public Target3(global::Anthropic.BetaPluginTargetOrganizationMember? value)
        {
            OrganizationMember = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Target3 FromOrganizationMember(global::Anthropic.BetaPluginTargetOrganizationMember? value) => new Target3(value);

        /// <summary>
        ///
        /// </summary>
        public Target3(
            global::Anthropic.BetaPluginShareTargetDiscriminatorType? type,
            global::Anthropic.BetaPluginTargetOrganization? organization,
            global::Anthropic.BetaPluginTargetRbacGroup? rbacGroup,
            global::Anthropic.BetaPluginTargetOrganizationMember? organizationMember
            )
        {
            Type = type;

            Organization = organization;
            RbacGroup = rbacGroup;
            OrganizationMember = organizationMember;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OrganizationMember as object ??
            RbacGroup as object ??
            Organization as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Organization?.ToString() ??
            RbacGroup?.ToString() ??
            OrganizationMember?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOrganization && !IsRbacGroup && !IsOrganizationMember || !IsOrganization && IsRbacGroup && !IsOrganizationMember || !IsOrganization && !IsRbacGroup && IsOrganizationMember;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaPluginTargetOrganization, TResult>? organization = null,
            global::System.Func<global::Anthropic.BetaPluginTargetRbacGroup, TResult>? rbacGroup = null,
            global::System.Func<global::Anthropic.BetaPluginTargetOrganizationMember, TResult>? organizationMember = null,
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
            else if (RbacGroup is { } __value1 && rbacGroup != null)
            {
                return rbacGroup(__value1);
            }
            else if (OrganizationMember is { } __value2 && organizationMember != null)
            {
                return organizationMember(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaPluginTargetOrganization>? organization = null,

            global::System.Action<global::Anthropic.BetaPluginTargetRbacGroup>? rbacGroup = null,

            global::System.Action<global::Anthropic.BetaPluginTargetOrganizationMember>? organizationMember = null,
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
            else if (RbacGroup is { } __value1)
            {
                rbacGroup?.Invoke(__value1);
            }
            else if (OrganizationMember is { } __value2)
            {
                organizationMember?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaPluginTargetOrganization>? organization = null,
            global::System.Action<global::Anthropic.BetaPluginTargetRbacGroup>? rbacGroup = null,
            global::System.Action<global::Anthropic.BetaPluginTargetOrganizationMember>? organizationMember = null,
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
            else if (RbacGroup is { } __value1)
            {
                rbacGroup?.Invoke(__value1);
            }
            else if (OrganizationMember is { } __value2)
            {
                organizationMember?.Invoke(__value2);
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
                typeof(global::Anthropic.BetaPluginTargetOrganization),
                RbacGroup,
                typeof(global::Anthropic.BetaPluginTargetRbacGroup),
                OrganizationMember,
                typeof(global::Anthropic.BetaPluginTargetOrganizationMember),
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
        public bool Equals(Target3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPluginTargetOrganization?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPluginTargetRbacGroup?>.Default.Equals(RbacGroup, other.RbacGroup) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPluginTargetOrganizationMember?>.Default.Equals(OrganizationMember, other.OrganizationMember)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Target3 obj1, Target3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Target3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Target3 obj1, Target3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Target3 o && Equals(o);
        }
    }
}
