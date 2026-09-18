#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the limit applies to. Claude Enterprise organizations set `user` limits. Claude Console organizations set `organization` and `workspace` limits. Any other combination returns 400. Setting `organization` and `workspace` limits through the API is in an early access preview. To request access, contact your Anthropic account team.
    /// </summary>
    public readonly partial struct Scope2 : global::System.IEquatable<Scope2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminatorType? Type { get; }

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
        /// Scope selecting one workspace of a Claude Console organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWorkspaceScope? Workspace { get; init; }
#else
        public global::Anthropic.BetaWorkspaceScope? Workspace { get; }
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
            out global::Anthropic.BetaWorkspaceScope? value)
        {
            value = Workspace;
            return IsWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceScope PickWorkspace() => IsWorkspace
            ? Workspace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Workspace' but the value was {ToString()}.");
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
        public static implicit operator Scope2(global::Anthropic.BetaWorkspaceScope value) => new Scope2((global::Anthropic.BetaWorkspaceScope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWorkspaceScope?(Scope2 @this) => @this.Workspace;

        /// <summary>
        ///
        /// </summary>
        public Scope2(global::Anthropic.BetaWorkspaceScope? value)
        {
            Workspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Scope2 FromWorkspace(global::Anthropic.BetaWorkspaceScope? value) => new Scope2(value);

        /// <summary>
        ///
        /// </summary>
        public Scope2(
            global::Anthropic.BetaSetSpendLimitParamsScopeDiscriminatorType? type,
            global::Anthropic.BetaUserScope? user,
            global::Anthropic.BetaOrganizationScope? organization,
            global::Anthropic.BetaWorkspaceScope? workspace
            )
        {
            Type = type;

            User = user;
            Organization = organization;
            Workspace = workspace;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Workspace as object ??
            Organization as object ??
            User as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            Organization?.ToString() ??
            Workspace?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsOrganization && !IsWorkspace || !IsUser && IsOrganization && !IsWorkspace || !IsUser && !IsOrganization && IsWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaUserScope, TResult>? user = null,
            global::System.Func<global::Anthropic.BetaOrganizationScope, TResult>? organization = null,
            global::System.Func<global::Anthropic.BetaWorkspaceScope, TResult>? workspace = null,
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
            else if (IsOrganization && organization != null)
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
            global::System.Action<global::Anthropic.BetaUserScope>? user = null,

            global::System.Action<global::Anthropic.BetaOrganizationScope>? organization = null,

            global::System.Action<global::Anthropic.BetaWorkspaceScope>? workspace = null,
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
            else if (IsOrganization)
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
            global::System.Action<global::Anthropic.BetaUserScope>? user = null,
            global::System.Action<global::Anthropic.BetaOrganizationScope>? organization = null,
            global::System.Action<global::Anthropic.BetaWorkspaceScope>? workspace = null,
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
            else if (IsOrganization)
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
                User,
                typeof(global::Anthropic.BetaUserScope),
                Organization,
                typeof(global::Anthropic.BetaOrganizationScope),
                Workspace,
                typeof(global::Anthropic.BetaWorkspaceScope),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOrganizationScope?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWorkspaceScope?>.Default.Equals(Workspace, other.Workspace)
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
