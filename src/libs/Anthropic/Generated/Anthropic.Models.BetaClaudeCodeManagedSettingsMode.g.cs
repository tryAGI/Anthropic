#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaClaudeCodeManagedSettingsMode : global::System.IEquatable<BetaClaudeCodeManagedSettingsMode>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? Organization { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? Organization { get; }
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
            out global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? RbacGroups { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? RbacGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RbacGroups))]
#endif
        public bool IsRbacGroups => RbacGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRbacGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? value)
        {
            value = RbacGroups;
            return IsRbacGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode PickRbacGroups() => RbacGroups is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RbacGroups' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeCodeManagedSettingsMode(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode value) => new BetaClaudeCodeManagedSettingsMode((global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode?(BetaClaudeCodeManagedSettingsMode @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeManagedSettingsMode(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeCodeManagedSettingsMode FromOrganization(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? value) => new BetaClaudeCodeManagedSettingsMode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeCodeManagedSettingsMode(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode value) => new BetaClaudeCodeManagedSettingsMode((global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode?(BetaClaudeCodeManagedSettingsMode @this) => @this.RbacGroups;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeManagedSettingsMode(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? value)
        {
            RbacGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeCodeManagedSettingsMode FromRbacGroups(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? value) => new BetaClaudeCodeManagedSettingsMode(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeManagedSettingsMode(
            global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminatorType? type,
            global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? organization,
            global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? rbacGroups
            )
        {
            Type = type;

            Organization = organization;
            RbacGroups = rbacGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RbacGroups as object ??
            Organization as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Organization?.ToString() ??
            RbacGroups?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOrganization && !IsRbacGroups || !IsOrganization && IsRbacGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode, TResult>? organization = null,
            global::System.Func<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode, TResult>? rbacGroups = null,
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
            else if (RbacGroups is { } __value1 && rbacGroups != null)
            {
                return rbacGroups(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode>? organization = null,

            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode>? rbacGroups = null,
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
            else if (RbacGroups is { } __value1)
            {
                rbacGroups?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode>? organization = null,
            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode>? rbacGroups = null,
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
            else if (RbacGroups is { } __value1)
            {
                rbacGroups?.Invoke(__value1);
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
                typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode),
                RbacGroups,
                typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode),
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
        public bool Equals(BetaClaudeCodeManagedSettingsMode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode?>.Default.Equals(RbacGroups, other.RbacGroups)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeCodeManagedSettingsMode obj1, BetaClaudeCodeManagedSettingsMode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeCodeManagedSettingsMode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeCodeManagedSettingsMode obj1, BetaClaudeCodeManagedSettingsMode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeCodeManagedSettingsMode o && Equals(o);
        }
    }
}
