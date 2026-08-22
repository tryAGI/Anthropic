#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The error that triggered an auto-pause. Matches the failed run's `error.type`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsDeploymentPausedReasonError : global::System.IEquatable<BetaManagedAgentsDeploymentPausedReasonError>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// The deployment's environment was archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? EnvironmentArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? EnvironmentArchivedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentArchivedError))]
#endif
        public bool IsEnvironmentArchivedError => EnvironmentArchivedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentArchivedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? value)
        {
            value = EnvironmentArchivedError;
            return IsEnvironmentArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError PickEnvironmentArchivedError() => IsEnvironmentArchivedError
            ? EnvironmentArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's agent was archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? AgentArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? AgentArchivedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentArchivedError))]
#endif
        public bool IsAgentArchivedError => AgentArchivedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentArchivedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? value)
        {
            value = AgentArchivedError;
            return IsAgentArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError PickAgentArchivedError() => IsAgentArchivedError
            ? AgentArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's environment no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? EnvironmentNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? EnvironmentNotFoundError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentNotFoundError))]
#endif
        public bool IsEnvironmentNotFoundError => EnvironmentNotFoundError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? value)
        {
            value = EnvironmentNotFoundError;
            return IsEnvironmentNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError PickEnvironmentNotFoundError() => IsEnvironmentNotFoundError
            ? EnvironmentNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A vault referenced by the deployment no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? VaultNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? VaultNotFoundError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultNotFoundError))]
#endif
        public bool IsVaultNotFoundError => VaultNotFoundError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? value)
        {
            value = VaultNotFoundError;
            return IsVaultNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError PickVaultNotFoundError() => IsVaultNotFoundError
            ? VaultNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A file resource referenced by the deployment no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? FileNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? FileNotFoundError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileNotFoundError))]
#endif
        public bool IsFileNotFoundError => FileNotFoundError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? value)
        {
            value = FileNotFoundError;
            return IsFileNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError PickFileNotFoundError() => IsFileNotFoundError
            ? FileNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A referenced resource no longer exists and its kind was not reported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? SessionResourceNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? SessionResourceNotFoundError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionResourceNotFoundError))]
#endif
        public bool IsSessionResourceNotFoundError => SessionResourceNotFoundError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionResourceNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? value)
        {
            value = SessionResourceNotFoundError;
            return IsSessionResourceNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError PickSessionResourceNotFoundError() => IsSessionResourceNotFoundError
            ? SessionResourceNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionResourceNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's workspace was archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? WorkspaceArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? WorkspaceArchivedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkspaceArchivedError))]
#endif
        public bool IsWorkspaceArchivedError => WorkspaceArchivedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWorkspaceArchivedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? value)
        {
            value = WorkspaceArchivedError;
            return IsWorkspaceArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError PickWorkspaceArchivedError() => IsWorkspaceArchivedError
            ? WorkspaceArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkspaceArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's organization is disabled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? OrganizationDisabledError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? OrganizationDisabledError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationDisabledError))]
#endif
        public bool IsOrganizationDisabledError => OrganizationDisabledError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationDisabledError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? value)
        {
            value = OrganizationDisabledError;
            return IsOrganizationDisabledError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError PickOrganizationDisabledError() => IsOrganizationDisabledError
            ? OrganizationDisabledError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationDisabledError' but the value was {ToString()}.");

        /// <summary>
        /// A memory store referenced by the deployment is archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? MemoryStoreArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? MemoryStoreArchivedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryStoreArchivedError))]
#endif
        public bool IsMemoryStoreArchivedError => MemoryStoreArchivedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMemoryStoreArchivedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? value)
        {
            value = MemoryStoreArchivedError;
            return IsMemoryStoreArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError PickMemoryStoreArchivedError() => IsMemoryStoreArchivedError
            ? MemoryStoreArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStoreArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// A skill referenced by the deployment's agent no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? SkillNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? SkillNotFoundError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkillNotFoundError))]
#endif
        public bool IsSkillNotFoundError => SkillNotFoundError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSkillNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? value)
        {
            value = SkillNotFoundError;
            return IsSkillNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError PickSkillNotFoundError() => IsSkillNotFoundError
            ? SkillNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A vault referenced by the deployment is archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? VaultArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? VaultArchivedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultArchivedError))]
#endif
        public bool IsVaultArchivedError => VaultArchivedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultArchivedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? value)
        {
            value = VaultArchivedError;
            return IsVaultArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError PickVaultArchivedError() => IsVaultArchivedError
            ? VaultArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// An unrecognized error auto-paused the deployment. A fallback variant; matches a run whose `error.type` is `unknown_error`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? UnknownError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? UnknownError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnknownError))]
#endif
        public bool IsUnknownError => UnknownError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnknownError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? value)
        {
            value = UnknownError;
            return IsUnknownError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError PickUnknownError() => IsUnknownError
            ? UnknownError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnknownError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment configures resources, but its environment is self-hosted and cannot mount them.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? SelfHostedResourcesUnsupportedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? SelfHostedResourcesUnsupportedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelfHostedResourcesUnsupportedError))]
#endif
        public bool IsSelfHostedResourcesUnsupportedError => SelfHostedResourcesUnsupportedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSelfHostedResourcesUnsupportedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? value)
        {
            value = SelfHostedResourcesUnsupportedError;
            return IsSelfHostedResourcesUnsupportedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError PickSelfHostedResourcesUnsupportedError() => IsSelfHostedResourcesUnsupportedError
            ? SelfHostedResourcesUnsupportedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SelfHostedResourcesUnsupportedError' but the value was {ToString()}.");

        /// <summary>
        /// An MCP server host used by the deployment's agent is blocked by the environment's network policy.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? McpEgressBlockedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? McpEgressBlockedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpEgressBlockedError))]
#endif
        public bool IsMcpEgressBlockedError => McpEgressBlockedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpEgressBlockedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? value)
        {
            value = McpEgressBlockedError;
            return IsMcpEgressBlockedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError PickMcpEgressBlockedError() => IsMcpEgressBlockedError
            ? McpEgressBlockedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpEgressBlockedError' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.EnvironmentArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? value)
        {
            EnvironmentArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromEnvironmentArchivedError(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.AgentArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? value)
        {
            AgentArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromAgentArchivedError(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.EnvironmentNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? value)
        {
            EnvironmentNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromEnvironmentNotFoundError(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.VaultNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? value)
        {
            VaultNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromVaultNotFoundError(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.FileNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? value)
        {
            FileNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromFileNotFoundError(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.SessionResourceNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? value)
        {
            SessionResourceNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromSessionResourceNotFoundError(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.WorkspaceArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? value)
        {
            WorkspaceArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromWorkspaceArchivedError(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.OrganizationDisabledError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? value)
        {
            OrganizationDisabledError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromOrganizationDisabledError(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.MemoryStoreArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? value)
        {
            MemoryStoreArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromMemoryStoreArchivedError(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.SkillNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? value)
        {
            SkillNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromSkillNotFoundError(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.VaultArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? value)
        {
            VaultArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromVaultArchivedError(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.UnknownError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? value)
        {
            UnknownError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromUnknownError(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.SelfHostedResourcesUnsupportedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? value)
        {
            SelfHostedResourcesUnsupportedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromSelfHostedResourcesUnsupportedError(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError value) => new BetaManagedAgentsDeploymentPausedReasonError((global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError?(BetaManagedAgentsDeploymentPausedReasonError @this) => @this.McpEgressBlockedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? value)
        {
            McpEgressBlockedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonError FromMcpEgressBlockedError(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? value) => new BetaManagedAgentsDeploymentPausedReasonError(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReasonError(
            global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? environmentArchivedError,
            global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? agentArchivedError,
            global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? environmentNotFoundError,
            global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? vaultNotFoundError,
            global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? fileNotFoundError,
            global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? sessionResourceNotFoundError,
            global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? workspaceArchivedError,
            global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? organizationDisabledError,
            global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? memoryStoreArchivedError,
            global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? skillNotFoundError,
            global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? vaultArchivedError,
            global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? unknownError,
            global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? selfHostedResourcesUnsupportedError,
            global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? mcpEgressBlockedError
            )
        {
            Type = type;

            EnvironmentArchivedError = environmentArchivedError;
            AgentArchivedError = agentArchivedError;
            EnvironmentNotFoundError = environmentNotFoundError;
            VaultNotFoundError = vaultNotFoundError;
            FileNotFoundError = fileNotFoundError;
            SessionResourceNotFoundError = sessionResourceNotFoundError;
            WorkspaceArchivedError = workspaceArchivedError;
            OrganizationDisabledError = organizationDisabledError;
            MemoryStoreArchivedError = memoryStoreArchivedError;
            SkillNotFoundError = skillNotFoundError;
            VaultArchivedError = vaultArchivedError;
            UnknownError = unknownError;
            SelfHostedResourcesUnsupportedError = selfHostedResourcesUnsupportedError;
            McpEgressBlockedError = mcpEgressBlockedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpEgressBlockedError as object ??
            SelfHostedResourcesUnsupportedError as object ??
            UnknownError as object ??
            VaultArchivedError as object ??
            SkillNotFoundError as object ??
            MemoryStoreArchivedError as object ??
            OrganizationDisabledError as object ??
            WorkspaceArchivedError as object ??
            SessionResourceNotFoundError as object ??
            FileNotFoundError as object ??
            VaultNotFoundError as object ??
            EnvironmentNotFoundError as object ??
            AgentArchivedError as object ??
            EnvironmentArchivedError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EnvironmentArchivedError?.ToString() ??
            AgentArchivedError?.ToString() ??
            EnvironmentNotFoundError?.ToString() ??
            VaultNotFoundError?.ToString() ??
            FileNotFoundError?.ToString() ??
            SessionResourceNotFoundError?.ToString() ??
            WorkspaceArchivedError?.ToString() ??
            OrganizationDisabledError?.ToString() ??
            MemoryStoreArchivedError?.ToString() ??
            SkillNotFoundError?.ToString() ??
            VaultArchivedError?.ToString() ??
            UnknownError?.ToString() ??
            SelfHostedResourcesUnsupportedError?.ToString() ??
            McpEgressBlockedError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsFileNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsVaultArchivedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && IsMcpEgressBlockedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError, TResult>? environmentArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError, TResult>? agentArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError, TResult>? environmentNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError, TResult>? vaultNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError, TResult>? fileNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError, TResult>? sessionResourceNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError, TResult>? workspaceArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError, TResult>? organizationDisabledError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError, TResult>? memoryStoreArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError, TResult>? skillNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError, TResult>? vaultArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError, TResult>? unknownError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError, TResult>? selfHostedResourcesUnsupportedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError, TResult>? mcpEgressBlockedError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentArchivedError && environmentArchivedError != null)
            {
                return environmentArchivedError(EnvironmentArchivedError!);
            }
            else if (IsAgentArchivedError && agentArchivedError != null)
            {
                return agentArchivedError(AgentArchivedError!);
            }
            else if (IsEnvironmentNotFoundError && environmentNotFoundError != null)
            {
                return environmentNotFoundError(EnvironmentNotFoundError!);
            }
            else if (IsVaultNotFoundError && vaultNotFoundError != null)
            {
                return vaultNotFoundError(VaultNotFoundError!);
            }
            else if (IsFileNotFoundError && fileNotFoundError != null)
            {
                return fileNotFoundError(FileNotFoundError!);
            }
            else if (IsSessionResourceNotFoundError && sessionResourceNotFoundError != null)
            {
                return sessionResourceNotFoundError(SessionResourceNotFoundError!);
            }
            else if (IsWorkspaceArchivedError && workspaceArchivedError != null)
            {
                return workspaceArchivedError(WorkspaceArchivedError!);
            }
            else if (IsOrganizationDisabledError && organizationDisabledError != null)
            {
                return organizationDisabledError(OrganizationDisabledError!);
            }
            else if (IsMemoryStoreArchivedError && memoryStoreArchivedError != null)
            {
                return memoryStoreArchivedError(MemoryStoreArchivedError!);
            }
            else if (IsSkillNotFoundError && skillNotFoundError != null)
            {
                return skillNotFoundError(SkillNotFoundError!);
            }
            else if (IsVaultArchivedError && vaultArchivedError != null)
            {
                return vaultArchivedError(VaultArchivedError!);
            }
            else if (IsUnknownError && unknownError != null)
            {
                return unknownError(UnknownError!);
            }
            else if (IsSelfHostedResourcesUnsupportedError && selfHostedResourcesUnsupportedError != null)
            {
                return selfHostedResourcesUnsupportedError(SelfHostedResourcesUnsupportedError!);
            }
            else if (IsMcpEgressBlockedError && mcpEgressBlockedError != null)
            {
                return mcpEgressBlockedError(McpEgressBlockedError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError>? environmentArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError>? agentArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError>? environmentNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError>? vaultNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError>? fileNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError>? sessionResourceNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError>? workspaceArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError>? organizationDisabledError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError>? memoryStoreArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError>? skillNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError>? vaultArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError>? unknownError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError>? selfHostedResourcesUnsupportedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError>? mcpEgressBlockedError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentArchivedError)
            {
                environmentArchivedError?.Invoke(EnvironmentArchivedError!);
            }
            else if (IsAgentArchivedError)
            {
                agentArchivedError?.Invoke(AgentArchivedError!);
            }
            else if (IsEnvironmentNotFoundError)
            {
                environmentNotFoundError?.Invoke(EnvironmentNotFoundError!);
            }
            else if (IsVaultNotFoundError)
            {
                vaultNotFoundError?.Invoke(VaultNotFoundError!);
            }
            else if (IsFileNotFoundError)
            {
                fileNotFoundError?.Invoke(FileNotFoundError!);
            }
            else if (IsSessionResourceNotFoundError)
            {
                sessionResourceNotFoundError?.Invoke(SessionResourceNotFoundError!);
            }
            else if (IsWorkspaceArchivedError)
            {
                workspaceArchivedError?.Invoke(WorkspaceArchivedError!);
            }
            else if (IsOrganizationDisabledError)
            {
                organizationDisabledError?.Invoke(OrganizationDisabledError!);
            }
            else if (IsMemoryStoreArchivedError)
            {
                memoryStoreArchivedError?.Invoke(MemoryStoreArchivedError!);
            }
            else if (IsSkillNotFoundError)
            {
                skillNotFoundError?.Invoke(SkillNotFoundError!);
            }
            else if (IsVaultArchivedError)
            {
                vaultArchivedError?.Invoke(VaultArchivedError!);
            }
            else if (IsUnknownError)
            {
                unknownError?.Invoke(UnknownError!);
            }
            else if (IsSelfHostedResourcesUnsupportedError)
            {
                selfHostedResourcesUnsupportedError?.Invoke(SelfHostedResourcesUnsupportedError!);
            }
            else if (IsMcpEgressBlockedError)
            {
                mcpEgressBlockedError?.Invoke(McpEgressBlockedError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError>? environmentArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError>? agentArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError>? environmentNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError>? vaultNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError>? fileNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError>? sessionResourceNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError>? workspaceArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError>? organizationDisabledError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError>? memoryStoreArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError>? skillNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError>? vaultArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError>? unknownError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError>? selfHostedResourcesUnsupportedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError>? mcpEgressBlockedError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentArchivedError)
            {
                environmentArchivedError?.Invoke(EnvironmentArchivedError!);
            }
            else if (IsAgentArchivedError)
            {
                agentArchivedError?.Invoke(AgentArchivedError!);
            }
            else if (IsEnvironmentNotFoundError)
            {
                environmentNotFoundError?.Invoke(EnvironmentNotFoundError!);
            }
            else if (IsVaultNotFoundError)
            {
                vaultNotFoundError?.Invoke(VaultNotFoundError!);
            }
            else if (IsFileNotFoundError)
            {
                fileNotFoundError?.Invoke(FileNotFoundError!);
            }
            else if (IsSessionResourceNotFoundError)
            {
                sessionResourceNotFoundError?.Invoke(SessionResourceNotFoundError!);
            }
            else if (IsWorkspaceArchivedError)
            {
                workspaceArchivedError?.Invoke(WorkspaceArchivedError!);
            }
            else if (IsOrganizationDisabledError)
            {
                organizationDisabledError?.Invoke(OrganizationDisabledError!);
            }
            else if (IsMemoryStoreArchivedError)
            {
                memoryStoreArchivedError?.Invoke(MemoryStoreArchivedError!);
            }
            else if (IsSkillNotFoundError)
            {
                skillNotFoundError?.Invoke(SkillNotFoundError!);
            }
            else if (IsVaultArchivedError)
            {
                vaultArchivedError?.Invoke(VaultArchivedError!);
            }
            else if (IsUnknownError)
            {
                unknownError?.Invoke(UnknownError!);
            }
            else if (IsSelfHostedResourcesUnsupportedError)
            {
                selfHostedResourcesUnsupportedError?.Invoke(SelfHostedResourcesUnsupportedError!);
            }
            else if (IsMcpEgressBlockedError)
            {
                mcpEgressBlockedError?.Invoke(McpEgressBlockedError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EnvironmentArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError),
                AgentArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError),
                EnvironmentNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError),
                VaultNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError),
                FileNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError),
                SessionResourceNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError),
                WorkspaceArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError),
                OrganizationDisabledError,
                typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError),
                MemoryStoreArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError),
                SkillNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError),
                VaultArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError),
                UnknownError,
                typeof(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError),
                SelfHostedResourcesUnsupportedError,
                typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError),
                McpEgressBlockedError,
                typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError),
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
        public bool Equals(BetaManagedAgentsDeploymentPausedReasonError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError?>.Default.Equals(EnvironmentArchivedError, other.EnvironmentArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError?>.Default.Equals(AgentArchivedError, other.AgentArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError?>.Default.Equals(EnvironmentNotFoundError, other.EnvironmentNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError?>.Default.Equals(VaultNotFoundError, other.VaultNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError?>.Default.Equals(FileNotFoundError, other.FileNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError?>.Default.Equals(SessionResourceNotFoundError, other.SessionResourceNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError?>.Default.Equals(WorkspaceArchivedError, other.WorkspaceArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError?>.Default.Equals(OrganizationDisabledError, other.OrganizationDisabledError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError?>.Default.Equals(MemoryStoreArchivedError, other.MemoryStoreArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError?>.Default.Equals(SkillNotFoundError, other.SkillNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError?>.Default.Equals(VaultArchivedError, other.VaultArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError?>.Default.Equals(UnknownError, other.UnknownError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError?>.Default.Equals(SelfHostedResourcesUnsupportedError, other.SelfHostedResourcesUnsupportedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError?>.Default.Equals(McpEgressBlockedError, other.McpEgressBlockedError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsDeploymentPausedReasonError obj1, BetaManagedAgentsDeploymentPausedReasonError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsDeploymentPausedReasonError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsDeploymentPausedReasonError obj1, BetaManagedAgentsDeploymentPausedReasonError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsDeploymentPausedReasonError o && Equals(o);
        }
    }
}
