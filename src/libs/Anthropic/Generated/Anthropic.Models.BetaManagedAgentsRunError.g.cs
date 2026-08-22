#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why the run failed to create a session. The type identifies the failure; message is human-readable detail.
    /// </summary>
    public readonly partial struct BetaManagedAgentsRunError : global::System.IEquatable<BetaManagedAgentsRunError>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// The deployment's environment was archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? EnvironmentArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? EnvironmentArchivedError { get; }
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
            out global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? value)
        {
            value = EnvironmentArchivedError;
            return IsEnvironmentArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError PickEnvironmentArchivedError() => IsEnvironmentArchivedError
            ? EnvironmentArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's agent was archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError? AgentArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError? AgentArchivedError { get; }
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
            out global::Anthropic.BetaManagedAgentsAgentArchivedRunError? value)
        {
            value = AgentArchivedError;
            return IsAgentArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentArchivedRunError PickAgentArchivedError() => IsAgentArchivedError
            ? AgentArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's environment no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? EnvironmentNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? EnvironmentNotFoundError { get; }
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
            out global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? value)
        {
            value = EnvironmentNotFoundError;
            return IsEnvironmentNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError PickEnvironmentNotFoundError() => IsEnvironmentNotFoundError
            ? EnvironmentNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A vault referenced by the deployment no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? VaultNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? VaultNotFoundError { get; }
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
            out global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? value)
        {
            value = VaultNotFoundError;
            return IsVaultNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunError PickVaultNotFoundError() => IsVaultNotFoundError
            ? VaultNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A vault referenced by the deployment is archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError? VaultArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError? VaultArchivedError { get; }
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
            out global::Anthropic.BetaManagedAgentsVaultArchivedRunError? value)
        {
            value = VaultArchivedError;
            return IsVaultArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsVaultArchivedRunError PickVaultArchivedError() => IsVaultArchivedError
            ? VaultArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// A file resource referenced by the deployment no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError? FileNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError? FileNotFoundError { get; }
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
            out global::Anthropic.BetaManagedAgentsFileNotFoundRunError? value)
        {
            value = FileNotFoundError;
            return IsFileNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileNotFoundRunError PickFileNotFoundError() => IsFileNotFoundError
            ? FileNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A memory store referenced by the deployment is archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? MemoryStoreArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? MemoryStoreArchivedError { get; }
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
            out global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? value)
        {
            value = MemoryStoreArchivedError;
            return IsMemoryStoreArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError PickMemoryStoreArchivedError() => IsMemoryStoreArchivedError
            ? MemoryStoreArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStoreArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// A skill referenced by the deployment's agent no longer exists.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? SkillNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? SkillNotFoundError { get; }
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
            out global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? value)
        {
            value = SkillNotFoundError;
            return IsSkillNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillNotFoundRunError PickSkillNotFoundError() => IsSkillNotFoundError
            ? SkillNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// A referenced resource no longer exists and its kind was not reported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? SessionResourceNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? SessionResourceNotFoundError { get; }
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
            out global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? value)
        {
            value = SessionResourceNotFoundError;
            return IsSessionResourceNotFoundError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError PickSessionResourceNotFoundError() => IsSessionResourceNotFoundError
            ? SessionResourceNotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionResourceNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's workspace was archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? WorkspaceArchivedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? WorkspaceArchivedError { get; }
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
            out global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? value)
        {
            value = WorkspaceArchivedError;
            return IsWorkspaceArchivedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError PickWorkspaceArchivedError() => IsWorkspaceArchivedError
            ? WorkspaceArchivedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkspaceArchivedError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment's organization is disabled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? OrganizationDisabledError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? OrganizationDisabledError { get; }
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
            out global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? value)
        {
            value = OrganizationDisabledError;
            return IsOrganizationDisabledError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError PickOrganizationDisabledError() => IsOrganizationDisabledError
            ? OrganizationDisabledError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationDisabledError' but the value was {ToString()}.");

        /// <summary>
        /// Session creation was rejected due to rate limiting. The schedule keeps firing; subsequent runs may succeed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? SessionRateLimitedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? SessionRateLimitedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionRateLimitedError))]
#endif
        public bool IsSessionRateLimitedError => SessionRateLimitedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionRateLimitedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? value)
        {
            value = SessionRateLimitedError;
            return IsSessionRateLimitedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError PickSessionRateLimitedError() => IsSessionRateLimitedError
            ? SessionRateLimitedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionRateLimitedError' but the value was {ToString()}.");

        /// <summary>
        /// The session create request was rejected with a non-retryable validation error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? SessionCreationRejectedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? SessionCreationRejectedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreationRejectedError))]
#endif
        public bool IsSessionCreationRejectedError => SessionCreationRejectedError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionCreationRejectedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? value)
        {
            value = SessionCreationRejectedError;
            return IsSessionCreationRejectedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError PickSessionCreationRejectedError() => IsSessionCreationRejectedError
            ? SessionCreationRejectedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreationRejectedError' but the value was {ToString()}.");

        /// <summary>
        /// An unknown or unexpected error caused the run to fail. A fallback variant; clients that do not recognize a new error type can match on message alone.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUnknownRunError? UnknownError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUnknownRunError? UnknownError { get; }
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
            out global::Anthropic.BetaManagedAgentsUnknownRunError? value)
        {
            value = UnknownError;
            return IsUnknownError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownRunError PickUnknownError() => IsUnknownError
            ? UnknownError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnknownError' but the value was {ToString()}.");

        /// <summary>
        /// The deployment configures resources, but its environment is self-hosted and cannot mount them.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? SelfHostedResourcesUnsupportedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? SelfHostedResourcesUnsupportedError { get; }
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
            out global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? value)
        {
            value = SelfHostedResourcesUnsupportedError;
            return IsSelfHostedResourcesUnsupportedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError PickSelfHostedResourcesUnsupportedError() => IsSelfHostedResourcesUnsupportedError
            ? SelfHostedResourcesUnsupportedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SelfHostedResourcesUnsupportedError' but the value was {ToString()}.");

        /// <summary>
        /// An MCP server host used by the deployment's agent is blocked by the environment's network policy.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? McpEgressBlockedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? McpEgressBlockedError { get; }
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
            out global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? value)
        {
            value = McpEgressBlockedError;
            return IsMcpEgressBlockedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError PickMcpEgressBlockedError() => IsMcpEgressBlockedError
            ? McpEgressBlockedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpEgressBlockedError' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError?(BetaManagedAgentsRunError @this) => @this.EnvironmentArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? value)
        {
            EnvironmentArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromEnvironmentArchivedError(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsAgentArchivedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsAgentArchivedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentArchivedRunError?(BetaManagedAgentsRunError @this) => @this.AgentArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsAgentArchivedRunError? value)
        {
            AgentArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromAgentArchivedError(global::Anthropic.BetaManagedAgentsAgentArchivedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError?(BetaManagedAgentsRunError @this) => @this.EnvironmentNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? value)
        {
            EnvironmentNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromEnvironmentNotFoundError(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsVaultNotFoundRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsVaultNotFoundRunError?(BetaManagedAgentsRunError @this) => @this.VaultNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? value)
        {
            VaultNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromVaultNotFoundError(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsVaultArchivedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsVaultArchivedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsVaultArchivedRunError?(BetaManagedAgentsRunError @this) => @this.VaultArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsVaultArchivedRunError? value)
        {
            VaultArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromVaultArchivedError(global::Anthropic.BetaManagedAgentsVaultArchivedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsFileNotFoundRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsFileNotFoundRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileNotFoundRunError?(BetaManagedAgentsRunError @this) => @this.FileNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsFileNotFoundRunError? value)
        {
            FileNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromFileNotFoundError(global::Anthropic.BetaManagedAgentsFileNotFoundRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError?(BetaManagedAgentsRunError @this) => @this.MemoryStoreArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? value)
        {
            MemoryStoreArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromMemoryStoreArchivedError(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsSkillNotFoundRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSkillNotFoundRunError?(BetaManagedAgentsRunError @this) => @this.SkillNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? value)
        {
            SkillNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromSkillNotFoundError(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError?(BetaManagedAgentsRunError @this) => @this.SessionResourceNotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? value)
        {
            SessionResourceNotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromSessionResourceNotFoundError(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError?(BetaManagedAgentsRunError @this) => @this.WorkspaceArchivedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? value)
        {
            WorkspaceArchivedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromWorkspaceArchivedError(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError?(BetaManagedAgentsRunError @this) => @this.OrganizationDisabledError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? value)
        {
            OrganizationDisabledError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromOrganizationDisabledError(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError?(BetaManagedAgentsRunError @this) => @this.SessionRateLimitedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? value)
        {
            SessionRateLimitedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromSessionRateLimitedError(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError?(BetaManagedAgentsRunError @this) => @this.SessionCreationRejectedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? value)
        {
            SessionCreationRejectedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromSessionCreationRejectedError(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsUnknownRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsUnknownRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUnknownRunError?(BetaManagedAgentsRunError @this) => @this.UnknownError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsUnknownRunError? value)
        {
            UnknownError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromUnknownError(global::Anthropic.BetaManagedAgentsUnknownRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError?(BetaManagedAgentsRunError @this) => @this.SelfHostedResourcesUnsupportedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? value)
        {
            SelfHostedResourcesUnsupportedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromSelfHostedResourcesUnsupportedError(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError value) => new BetaManagedAgentsRunError((global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError?(BetaManagedAgentsRunError @this) => @this.McpEgressBlockedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? value)
        {
            McpEgressBlockedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsRunError FromMcpEgressBlockedError(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? value) => new BetaManagedAgentsRunError(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRunError(
            global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? environmentArchivedError,
            global::Anthropic.BetaManagedAgentsAgentArchivedRunError? agentArchivedError,
            global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? environmentNotFoundError,
            global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? vaultNotFoundError,
            global::Anthropic.BetaManagedAgentsVaultArchivedRunError? vaultArchivedError,
            global::Anthropic.BetaManagedAgentsFileNotFoundRunError? fileNotFoundError,
            global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? memoryStoreArchivedError,
            global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? skillNotFoundError,
            global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? sessionResourceNotFoundError,
            global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? workspaceArchivedError,
            global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? organizationDisabledError,
            global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? sessionRateLimitedError,
            global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? sessionCreationRejectedError,
            global::Anthropic.BetaManagedAgentsUnknownRunError? unknownError,
            global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? selfHostedResourcesUnsupportedError,
            global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? mcpEgressBlockedError
            )
        {
            Type = type;

            EnvironmentArchivedError = environmentArchivedError;
            AgentArchivedError = agentArchivedError;
            EnvironmentNotFoundError = environmentNotFoundError;
            VaultNotFoundError = vaultNotFoundError;
            VaultArchivedError = vaultArchivedError;
            FileNotFoundError = fileNotFoundError;
            MemoryStoreArchivedError = memoryStoreArchivedError;
            SkillNotFoundError = skillNotFoundError;
            SessionResourceNotFoundError = sessionResourceNotFoundError;
            WorkspaceArchivedError = workspaceArchivedError;
            OrganizationDisabledError = organizationDisabledError;
            SessionRateLimitedError = sessionRateLimitedError;
            SessionCreationRejectedError = sessionCreationRejectedError;
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
            SessionCreationRejectedError as object ??
            SessionRateLimitedError as object ??
            OrganizationDisabledError as object ??
            WorkspaceArchivedError as object ??
            SessionResourceNotFoundError as object ??
            SkillNotFoundError as object ??
            MemoryStoreArchivedError as object ??
            FileNotFoundError as object ??
            VaultArchivedError as object ??
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
            VaultArchivedError?.ToString() ??
            FileNotFoundError?.ToString() ??
            MemoryStoreArchivedError?.ToString() ??
            SkillNotFoundError?.ToString() ??
            SessionResourceNotFoundError?.ToString() ??
            WorkspaceArchivedError?.ToString() ??
            OrganizationDisabledError?.ToString() ??
            SessionRateLimitedError?.ToString() ??
            SessionCreationRejectedError?.ToString() ??
            UnknownError?.ToString() ??
            SelfHostedResourcesUnsupportedError?.ToString() ??
            McpEgressBlockedError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && IsUnknownError && !IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && IsSelfHostedResourcesUnsupportedError && !IsMcpEgressBlockedError || !IsEnvironmentArchivedError && !IsAgentArchivedError && !IsEnvironmentNotFoundError && !IsVaultNotFoundError && !IsVaultArchivedError && !IsFileNotFoundError && !IsMemoryStoreArchivedError && !IsSkillNotFoundError && !IsSessionResourceNotFoundError && !IsWorkspaceArchivedError && !IsOrganizationDisabledError && !IsSessionRateLimitedError && !IsSessionCreationRejectedError && !IsUnknownError && !IsSelfHostedResourcesUnsupportedError && IsMcpEgressBlockedError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError, TResult>? environmentArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentArchivedRunError, TResult>? agentArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError, TResult>? environmentNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsVaultNotFoundRunError, TResult>? vaultNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsVaultArchivedRunError, TResult>? vaultArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsFileNotFoundRunError, TResult>? fileNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError, TResult>? memoryStoreArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSkillNotFoundRunError, TResult>? skillNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError, TResult>? sessionResourceNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError, TResult>? workspaceArchivedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError, TResult>? organizationDisabledError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError, TResult>? sessionRateLimitedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError, TResult>? sessionCreationRejectedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUnknownRunError, TResult>? unknownError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError, TResult>? selfHostedResourcesUnsupportedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError, TResult>? mcpEgressBlockedError = null,
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
            else if (IsVaultArchivedError && vaultArchivedError != null)
            {
                return vaultArchivedError(VaultArchivedError!);
            }
            else if (IsFileNotFoundError && fileNotFoundError != null)
            {
                return fileNotFoundError(FileNotFoundError!);
            }
            else if (IsMemoryStoreArchivedError && memoryStoreArchivedError != null)
            {
                return memoryStoreArchivedError(MemoryStoreArchivedError!);
            }
            else if (IsSkillNotFoundError && skillNotFoundError != null)
            {
                return skillNotFoundError(SkillNotFoundError!);
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
            else if (IsSessionRateLimitedError && sessionRateLimitedError != null)
            {
                return sessionRateLimitedError(SessionRateLimitedError!);
            }
            else if (IsSessionCreationRejectedError && sessionCreationRejectedError != null)
            {
                return sessionCreationRejectedError(SessionCreationRejectedError!);
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
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError>? environmentArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentArchivedRunError>? agentArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError>? environmentNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsVaultNotFoundRunError>? vaultNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsVaultArchivedRunError>? vaultArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsFileNotFoundRunError>? fileNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError>? memoryStoreArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSkillNotFoundRunError>? skillNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError>? sessionResourceNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError>? workspaceArchivedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError>? organizationDisabledError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError>? sessionRateLimitedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError>? sessionCreationRejectedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownRunError>? unknownError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError>? selfHostedResourcesUnsupportedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError>? mcpEgressBlockedError = null,
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
            else if (IsVaultArchivedError)
            {
                vaultArchivedError?.Invoke(VaultArchivedError!);
            }
            else if (IsFileNotFoundError)
            {
                fileNotFoundError?.Invoke(FileNotFoundError!);
            }
            else if (IsMemoryStoreArchivedError)
            {
                memoryStoreArchivedError?.Invoke(MemoryStoreArchivedError!);
            }
            else if (IsSkillNotFoundError)
            {
                skillNotFoundError?.Invoke(SkillNotFoundError!);
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
            else if (IsSessionRateLimitedError)
            {
                sessionRateLimitedError?.Invoke(SessionRateLimitedError!);
            }
            else if (IsSessionCreationRejectedError)
            {
                sessionCreationRejectedError?.Invoke(SessionCreationRejectedError!);
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
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError>? environmentArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentArchivedRunError>? agentArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError>? environmentNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsVaultNotFoundRunError>? vaultNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsVaultArchivedRunError>? vaultArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsFileNotFoundRunError>? fileNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError>? memoryStoreArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSkillNotFoundRunError>? skillNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError>? sessionResourceNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError>? workspaceArchivedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError>? organizationDisabledError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError>? sessionRateLimitedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError>? sessionCreationRejectedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownRunError>? unknownError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError>? selfHostedResourcesUnsupportedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError>? mcpEgressBlockedError = null,
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
            else if (IsVaultArchivedError)
            {
                vaultArchivedError?.Invoke(VaultArchivedError!);
            }
            else if (IsFileNotFoundError)
            {
                fileNotFoundError?.Invoke(FileNotFoundError!);
            }
            else if (IsMemoryStoreArchivedError)
            {
                memoryStoreArchivedError?.Invoke(MemoryStoreArchivedError!);
            }
            else if (IsSkillNotFoundError)
            {
                skillNotFoundError?.Invoke(SkillNotFoundError!);
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
            else if (IsSessionRateLimitedError)
            {
                sessionRateLimitedError?.Invoke(SessionRateLimitedError!);
            }
            else if (IsSessionCreationRejectedError)
            {
                sessionCreationRejectedError?.Invoke(SessionCreationRejectedError!);
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
                typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError),
                AgentArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsAgentArchivedRunError),
                EnvironmentNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError),
                VaultNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError),
                VaultArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsVaultArchivedRunError),
                FileNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsFileNotFoundRunError),
                MemoryStoreArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError),
                SkillNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError),
                SessionResourceNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError),
                WorkspaceArchivedError,
                typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError),
                OrganizationDisabledError,
                typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError),
                SessionRateLimitedError,
                typeof(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError),
                SessionCreationRejectedError,
                typeof(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError),
                UnknownError,
                typeof(global::Anthropic.BetaManagedAgentsUnknownRunError),
                SelfHostedResourcesUnsupportedError,
                typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError),
                McpEgressBlockedError,
                typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError),
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
        public bool Equals(BetaManagedAgentsRunError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError?>.Default.Equals(EnvironmentArchivedError, other.EnvironmentArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentArchivedRunError?>.Default.Equals(AgentArchivedError, other.AgentArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError?>.Default.Equals(EnvironmentNotFoundError, other.EnvironmentNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsVaultNotFoundRunError?>.Default.Equals(VaultNotFoundError, other.VaultNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsVaultArchivedRunError?>.Default.Equals(VaultArchivedError, other.VaultArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileNotFoundRunError?>.Default.Equals(FileNotFoundError, other.FileNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError?>.Default.Equals(MemoryStoreArchivedError, other.MemoryStoreArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSkillNotFoundRunError?>.Default.Equals(SkillNotFoundError, other.SkillNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError?>.Default.Equals(SessionResourceNotFoundError, other.SessionResourceNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError?>.Default.Equals(WorkspaceArchivedError, other.WorkspaceArchivedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError?>.Default.Equals(OrganizationDisabledError, other.OrganizationDisabledError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError?>.Default.Equals(SessionRateLimitedError, other.SessionRateLimitedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError?>.Default.Equals(SessionCreationRejectedError, other.SessionCreationRejectedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUnknownRunError?>.Default.Equals(UnknownError, other.UnknownError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError?>.Default.Equals(SelfHostedResourcesUnsupportedError, other.SelfHostedResourcesUnsupportedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError?>.Default.Equals(McpEgressBlockedError, other.McpEgressBlockedError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsRunError obj1, BetaManagedAgentsRunError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsRunError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsRunError obj1, BetaManagedAgentsRunError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsRunError o && Equals(o);
        }
    }
}
