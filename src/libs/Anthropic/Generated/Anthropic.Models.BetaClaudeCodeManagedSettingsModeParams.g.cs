#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaClaudeCodeManagedSettingsModeParams : global::System.IEquatable<BetaClaudeCodeManagedSettingsModeParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? Organization { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? Organization { get; }
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
            out global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? RbacGroups { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? RbacGroups { get; }
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
            out global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? value)
        {
            value = RbacGroups;
            return IsRbacGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams PickRbacGroups() => RbacGroups is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RbacGroups' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeCodeManagedSettingsModeParams(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams value) => new BetaClaudeCodeManagedSettingsModeParams((global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams?(BetaClaudeCodeManagedSettingsModeParams @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeManagedSettingsModeParams(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeCodeManagedSettingsModeParams FromOrganization(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? value) => new BetaClaudeCodeManagedSettingsModeParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeCodeManagedSettingsModeParams(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams value) => new BetaClaudeCodeManagedSettingsModeParams((global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams?(BetaClaudeCodeManagedSettingsModeParams @this) => @this.RbacGroups;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeManagedSettingsModeParams(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? value)
        {
            RbacGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeCodeManagedSettingsModeParams FromRbacGroups(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? value) => new BetaClaudeCodeManagedSettingsModeParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeManagedSettingsModeParams(
            global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType? type,
            global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? organization,
            global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? rbacGroups
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
            global::System.Func<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams, TResult>? organization = null,
            global::System.Func<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams, TResult>? rbacGroups = null,
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
            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams>? organization = null,

            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams>? rbacGroups = null,
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
            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams>? organization = null,
            global::System.Action<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams>? rbacGroups = null,
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
                typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams),
                RbacGroups,
                typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams),
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
        public bool Equals(BetaClaudeCodeManagedSettingsModeParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams?>.Default.Equals(RbacGroups, other.RbacGroups)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeCodeManagedSettingsModeParams obj1, BetaClaudeCodeManagedSettingsModeParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeCodeManagedSettingsModeParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeCodeManagedSettingsModeParams obj1, BetaClaudeCodeManagedSettingsModeParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeCodeManagedSettingsModeParams o && Equals(o);
        }
    }
}
