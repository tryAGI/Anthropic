#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where the API key belongs: its Workspace (`{"type": "workspace", "workspace_id": "wrkspc_..."}`, with the Workspace's real ID even when it is the organization's default Workspace), or the organization (`{"type": "organization"}`) for a principal-bound API key that has no Workspace.
    /// </summary>
    public readonly partial struct Scope : global::System.IEquatable<Scope>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyScopeDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaApiKeyOrganizationScope? Organization { get; init; }
#else
        public global::Anthropic.BetaApiKeyOrganizationScope? Organization { get; }
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
            out global::Anthropic.BetaApiKeyOrganizationScope? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyOrganizationScope PickOrganization() => IsOrganization
            ? Organization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaApiKeyWorkspaceScope? Workspace { get; init; }
#else
        public global::Anthropic.BetaApiKeyWorkspaceScope? Workspace { get; }
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
            out global::Anthropic.BetaApiKeyWorkspaceScope? value)
        {
            value = Workspace;
            return IsWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyWorkspaceScope PickWorkspace() => IsWorkspace
            ? Workspace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Workspace' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope(global::Anthropic.BetaApiKeyOrganizationScope value) => new Scope((global::Anthropic.BetaApiKeyOrganizationScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaApiKeyOrganizationScope?(Scope @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Scope(global::Anthropic.BetaApiKeyOrganizationScope? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope FromOrganization(global::Anthropic.BetaApiKeyOrganizationScope? value) => new Scope(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope(global::Anthropic.BetaApiKeyWorkspaceScope value) => new Scope((global::Anthropic.BetaApiKeyWorkspaceScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaApiKeyWorkspaceScope?(Scope @this) => @this.Workspace;

        /// <summary>
        ///
        /// </summary>
        public Scope(global::Anthropic.BetaApiKeyWorkspaceScope? value)
        {
            Workspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope FromWorkspace(global::Anthropic.BetaApiKeyWorkspaceScope? value) => new Scope(value);

        /// <summary>
        ///
        /// </summary>
        public Scope(
            global::Anthropic.BetaApiKeyScopeDiscriminatorType? type,
            global::Anthropic.BetaApiKeyOrganizationScope? organization,
            global::Anthropic.BetaApiKeyWorkspaceScope? workspace
            )
        {
            Type = type;

            Organization = organization;
            Workspace = workspace;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Workspace as object ??
            Organization as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Organization?.ToString() ??
            Workspace?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOrganization && !IsWorkspace || !IsOrganization && IsWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaApiKeyOrganizationScope, TResult>? organization = null,
            global::System.Func<global::Anthropic.BetaApiKeyWorkspaceScope, TResult>? workspace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization && organization != null)
            {
                return organization(Organization!);
            }
            else if (IsWorkspace && workspace != null)
            {
                return workspace(Workspace!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaApiKeyOrganizationScope>? organization = null,

            global::System.Action<global::Anthropic.BetaApiKeyWorkspaceScope>? workspace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization)
            {
                organization?.Invoke(Organization!);
            }
            else if (IsWorkspace)
            {
                workspace?.Invoke(Workspace!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaApiKeyOrganizationScope>? organization = null,
            global::System.Action<global::Anthropic.BetaApiKeyWorkspaceScope>? workspace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization)
            {
                organization?.Invoke(Organization!);
            }
            else if (IsWorkspace)
            {
                workspace?.Invoke(Workspace!);
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
                typeof(global::Anthropic.BetaApiKeyOrganizationScope),
                Workspace,
                typeof(global::Anthropic.BetaApiKeyWorkspaceScope),
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
        public bool Equals(Scope other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaApiKeyOrganizationScope?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaApiKeyWorkspaceScope?>.Default.Equals(Workspace, other.Workspace)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Scope obj1, Scope obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Scope>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Scope obj1, Scope obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Scope o && Equals(o);
        }
    }
}
