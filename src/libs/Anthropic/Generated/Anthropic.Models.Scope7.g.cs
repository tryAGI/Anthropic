#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where the API key belongs: its Workspace (`{"type": "workspace", "workspace_id": "wrkspc_..."}`, with the Workspace's real ID even when it is the organization's default Workspace), or the organization (`{"type": "organization"}`) for a principal-bound API key that has no Workspace.
    /// </summary>
    public readonly partial struct Scope7 : global::System.IEquatable<Scope7>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyScopeDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ApiKeyOrganizationScope? Organization { get; init; }
#else
        public global::Anthropic.ApiKeyOrganizationScope? Organization { get; }
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
            out global::Anthropic.ApiKeyOrganizationScope? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyOrganizationScope PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ApiKeyWorkspaceScope? Workspace { get; init; }
#else
        public global::Anthropic.ApiKeyWorkspaceScope? Workspace { get; }
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
            out global::Anthropic.ApiKeyWorkspaceScope? value)
        {
            value = Workspace;
            return IsWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyWorkspaceScope PickWorkspace() => Workspace is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Workspace' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope7(global::Anthropic.ApiKeyOrganizationScope value) => new Scope7((global::Anthropic.ApiKeyOrganizationScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ApiKeyOrganizationScope?(Scope7 @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Scope7(global::Anthropic.ApiKeyOrganizationScope? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope7 FromOrganization(global::Anthropic.ApiKeyOrganizationScope? value) => new Scope7(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Scope7(global::Anthropic.ApiKeyWorkspaceScope value) => new Scope7((global::Anthropic.ApiKeyWorkspaceScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ApiKeyWorkspaceScope?(Scope7 @this) => @this.Workspace;

        /// <summary>
        ///
        /// </summary>
        public Scope7(global::Anthropic.ApiKeyWorkspaceScope? value)
        {
            Workspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope7 FromWorkspace(global::Anthropic.ApiKeyWorkspaceScope? value) => new Scope7(value);

        /// <summary>
        ///
        /// </summary>
        public Scope7(
            global::Anthropic.ApiKeyScopeDiscriminatorType? type,
            global::Anthropic.ApiKeyOrganizationScope? organization,
            global::Anthropic.ApiKeyWorkspaceScope? workspace
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
            global::System.Func<global::Anthropic.ApiKeyOrganizationScope, TResult>? organization = null,
            global::System.Func<global::Anthropic.ApiKeyWorkspaceScope, TResult>? workspace = null,
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
            else if (Workspace is { } __value1 && workspace != null)
            {
                return workspace(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ApiKeyOrganizationScope>? organization = null,

            global::System.Action<global::Anthropic.ApiKeyWorkspaceScope>? workspace = null,
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
            else if (Workspace is { } __value1)
            {
                workspace?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.ApiKeyOrganizationScope>? organization = null,
            global::System.Action<global::Anthropic.ApiKeyWorkspaceScope>? workspace = null,
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
            else if (Workspace is { } __value1)
            {
                workspace?.Invoke(__value1);
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
                typeof(global::Anthropic.ApiKeyOrganizationScope),
                Workspace,
                typeof(global::Anthropic.ApiKeyWorkspaceScope),
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
        public bool Equals(Scope7 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ApiKeyOrganizationScope?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ApiKeyWorkspaceScope?>.Default.Equals(Workspace, other.Workspace)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Scope7 obj1, Scope7 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Scope7>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Scope7 obj1, Scope7 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Scope7 o && Equals(o);
        }
    }
}
