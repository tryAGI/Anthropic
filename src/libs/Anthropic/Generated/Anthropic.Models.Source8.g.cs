#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where `value` comes from. `organization` values are listed only when `include_inherited` is `true`, and then `value` equals `org_limit`.
    /// </summary>
    public readonly partial struct Source8 : global::System.IEquatable<Source8>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? Workspace { get; init; }
#else
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? Workspace { get; }
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
            out global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? value)
        {
            value = Workspace;
            return IsWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource PickWorkspace() => Workspace is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Workspace' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? Organization { get; init; }
#else
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? Organization { get; }
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
            out global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitOrganizationSource PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source8(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource value) => new Source8((global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource?(Source8 @this) => @this.Workspace;

        /// <summary>
        ///
        /// </summary>
        public Source8(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? value)
        {
            Workspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source8 FromWorkspace(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? value) => new Source8(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source8(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource value) => new Source8((global::Anthropic.BetaWorkspaceRateLimitOrganizationSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWorkspaceRateLimitOrganizationSource?(Source8 @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Source8(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source8 FromOrganization(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? value) => new Source8(value);

        /// <summary>
        ///
        /// </summary>
        public Source8(
            global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType? type,
            global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? workspace,
            global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? organization
            )
        {
            Type = type;

            Workspace = workspace;
            Organization = organization;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Organization as object ??
            Workspace as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Workspace?.ToString() ??
            Organization?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkspace && !IsOrganization || !IsWorkspace && IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource, TResult>? workspace = null,
            global::System.Func<global::Anthropic.BetaWorkspaceRateLimitOrganizationSource, TResult>? organization = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Workspace is { } __value0 && workspace != null)
            {
                return workspace(__value0);
            }
            else if (Organization is { } __value1 && organization != null)
            {
                return organization(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource>? workspace = null,

            global::System.Action<global::Anthropic.BetaWorkspaceRateLimitOrganizationSource>? organization = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Workspace is { } __value0)
            {
                workspace?.Invoke(__value0);
            }
            else if (Organization is { } __value1)
            {
                organization?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource>? workspace = null,
            global::System.Action<global::Anthropic.BetaWorkspaceRateLimitOrganizationSource>? organization = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Workspace is { } __value0)
            {
                workspace?.Invoke(__value0);
            }
            else if (Organization is { } __value1)
            {
                organization?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Workspace,
                typeof(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource),
                Organization,
                typeof(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource),
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
        public bool Equals(Source8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource?>.Default.Equals(Workspace, other.Workspace) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWorkspaceRateLimitOrganizationSource?>.Default.Equals(Organization, other.Organization)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Source8 obj1, Source8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Source8 obj1, Source8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source8 o && Equals(o);
        }
    }
}
