#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaWebhookEventData : global::System.IEquatable<BetaWebhookEventData>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookEventDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionCreatedEventData? SessionCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionCreatedEventData? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionCreatedEventData? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionCreatedEventData PickSessionCreated() => IsSessionCreated
            ? SessionCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionPendingEventData? SessionPending { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionPendingEventData? SessionPending { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionPending))]
#endif
        public bool IsSessionPending => SessionPending != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionPending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionPendingEventData? value)
        {
            value = SessionPending;
            return IsSessionPending;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionPendingEventData PickSessionPending() => IsSessionPending
            ? SessionPending!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionPending' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionRunningEventData? SessionRunning { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionRunningEventData? SessionRunning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionRunning))]
#endif
        public bool IsSessionRunning => SessionRunning != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionRunning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionRunningEventData? value)
        {
            value = SessionRunning;
            return IsSessionRunning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRunningEventData PickSessionRunning() => IsSessionRunning
            ? SessionRunning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionRunning' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionIdledEventData? SessionIdled { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionIdledEventData? SessionIdled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionIdled))]
#endif
        public bool IsSessionIdled => SessionIdled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionIdled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionIdledEventData? value)
        {
            value = SessionIdled;
            return IsSessionIdled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionIdledEventData PickSessionIdled() => IsSessionIdled
            ? SessionIdled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionIdled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData? SessionRequiresAction { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData? SessionRequiresAction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionRequiresAction))]
#endif
        public bool IsSessionRequiresAction => SessionRequiresAction != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionRequiresAction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionRequiresActionEventData? value)
        {
            value = SessionRequiresAction;
            return IsSessionRequiresAction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionRequiresActionEventData PickSessionRequiresAction() => IsSessionRequiresAction
            ? SessionRequiresAction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionRequiresAction' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionArchivedEventData? SessionArchived { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionArchivedEventData? SessionArchived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionArchived))]
#endif
        public bool IsSessionArchived => SessionArchived != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionArchivedEventData? value)
        {
            value = SessionArchived;
            return IsSessionArchived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionArchivedEventData PickSessionArchived() => IsSessionArchived
            ? SessionArchived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionArchived' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionDeletedEventData? SessionDeleted { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionDeletedEventData? SessionDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionDeleted))]
#endif
        public bool IsSessionDeleted => SessionDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionDeletedEventData? value)
        {
            value = SessionDeleted;
            return IsSessionDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionDeletedEventData PickSessionDeleted() => IsSessionDeleted
            ? SessionDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? SessionStatusRescheduled { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? SessionStatusRescheduled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusRescheduled))]
#endif
        public bool IsSessionStatusRescheduled => SessionStatusRescheduled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionStatusRescheduled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? value)
        {
            value = SessionStatusRescheduled;
            return IsSessionStatusRescheduled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRescheduledEventData PickSessionStatusRescheduled() => IsSessionStatusRescheduled
            ? SessionStatusRescheduled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusRescheduled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? SessionStatusRunStarted { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? SessionStatusRunStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusRunStarted))]
#endif
        public bool IsSessionStatusRunStarted => SessionStatusRunStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionStatusRunStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? value)
        {
            value = SessionStatusRunStarted;
            return IsSessionStatusRunStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusRunStartedEventData PickSessionStatusRunStarted() => IsSessionStatusRunStarted
            ? SessionStatusRunStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusRunStarted' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"type":"session.status_idled","id":"sesn_011CZkZAtmR3yMPDzynEDxu7","organization_id":"org_011CZkZZAe0sMna4vkBdtrfx","workspace_id":"wrkspc_011CZkZaBF1tNoB5wlCeusgy"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData? SessionStatusIdled { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData? SessionStatusIdled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusIdled))]
#endif
        public bool IsSessionStatusIdled => SessionStatusIdled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionStatusIdled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionStatusIdledEventData? value)
        {
            value = SessionStatusIdled;
            return IsSessionStatusIdled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusIdledEventData PickSessionStatusIdled() => IsSessionStatusIdled
            ? SessionStatusIdled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusIdled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? SessionStatusTerminated { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? SessionStatusTerminated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStatusTerminated))]
#endif
        public bool IsSessionStatusTerminated => SessionStatusTerminated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionStatusTerminated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? value)
        {
            value = SessionStatusTerminated;
            return IsSessionStatusTerminated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionStatusTerminatedEventData PickSessionStatusTerminated() => IsSessionStatusTerminated
            ? SessionStatusTerminated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStatusTerminated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData? SessionThreadCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData? SessionThreadCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadCreated))]
#endif
        public bool IsSessionThreadCreated => SessionThreadCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionThreadCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionThreadCreatedEventData? value)
        {
            value = SessionThreadCreated;
            return IsSessionThreadCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadCreatedEventData PickSessionThreadCreated() => IsSessionThreadCreated
            ? SessionThreadCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData? SessionThreadIdled { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData? SessionThreadIdled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadIdled))]
#endif
        public bool IsSessionThreadIdled => SessionThreadIdled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionThreadIdled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionThreadIdledEventData? value)
        {
            value = SessionThreadIdled;
            return IsSessionThreadIdled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadIdledEventData PickSessionThreadIdled() => IsSessionThreadIdled
            ? SessionThreadIdled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadIdled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? SessionThreadTerminated { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? SessionThreadTerminated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionThreadTerminated))]
#endif
        public bool IsSessionThreadTerminated => SessionThreadTerminated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionThreadTerminated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? value)
        {
            value = SessionThreadTerminated;
            return IsSessionThreadTerminated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionThreadTerminatedEventData PickSessionThreadTerminated() => IsSessionThreadTerminated
            ? SessionThreadTerminated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionThreadTerminated' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"type":"session.outcome_evaluation_ended","id":"sesn_011CZkZAtmR3yMPDzynEDxu7","organization_id":"org_011CZkZZAe0sMna4vkBdtrfx","workspace_id":"wrkspc_011CZkZaBF1tNoB5wlCeusgy"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? SessionOutcomeEvaluationEnded { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? SessionOutcomeEvaluationEnded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutcomeEvaluationEnded))]
#endif
        public bool IsSessionOutcomeEvaluationEnded => SessionOutcomeEvaluationEnded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionOutcomeEvaluationEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? value)
        {
            value = SessionOutcomeEvaluationEnded;
            return IsSessionOutcomeEvaluationEnded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData PickSessionOutcomeEvaluationEnded() => IsSessionOutcomeEvaluationEnded
            ? SessionOutcomeEvaluationEnded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionOutcomeEvaluationEnded' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookVaultCreatedEventData? VaultCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookVaultCreatedEventData? VaultCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultCreated))]
#endif
        public bool IsVaultCreated => VaultCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookVaultCreatedEventData? value)
        {
            value = VaultCreated;
            return IsVaultCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCreatedEventData PickVaultCreated() => IsVaultCreated
            ? VaultCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookVaultArchivedEventData? VaultArchived { get; init; }
#else
        public global::Anthropic.BetaWebhookVaultArchivedEventData? VaultArchived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultArchived))]
#endif
        public bool IsVaultArchived => VaultArchived != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookVaultArchivedEventData? value)
        {
            value = VaultArchived;
            return IsVaultArchived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookVaultArchivedEventData PickVaultArchived() => IsVaultArchived
            ? VaultArchived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultArchived' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookVaultDeletedEventData? VaultDeleted { get; init; }
#else
        public global::Anthropic.BetaWebhookVaultDeletedEventData? VaultDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultDeleted))]
#endif
        public bool IsVaultDeleted => VaultDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookVaultDeletedEventData? value)
        {
            value = VaultDeleted;
            return IsVaultDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookVaultDeletedEventData PickVaultDeleted() => IsVaultDeleted
            ? VaultDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? VaultCredentialCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? VaultCredentialCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultCredentialCreated))]
#endif
        public bool IsVaultCredentialCreated => VaultCredentialCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultCredentialCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? value)
        {
            value = VaultCredentialCreated;
            return IsVaultCredentialCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialCreatedEventData PickVaultCredentialCreated() => IsVaultCredentialCreated
            ? VaultCredentialCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultCredentialCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? VaultCredentialArchived { get; init; }
#else
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? VaultCredentialArchived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultCredentialArchived))]
#endif
        public bool IsVaultCredentialArchived => VaultCredentialArchived != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultCredentialArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? value)
        {
            value = VaultCredentialArchived;
            return IsVaultCredentialArchived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialArchivedEventData PickVaultCredentialArchived() => IsVaultCredentialArchived
            ? VaultCredentialArchived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultCredentialArchived' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? VaultCredentialDeleted { get; init; }
#else
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? VaultCredentialDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultCredentialDeleted))]
#endif
        public bool IsVaultCredentialDeleted => VaultCredentialDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultCredentialDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? value)
        {
            value = VaultCredentialDeleted;
            return IsVaultCredentialDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialDeletedEventData PickVaultCredentialDeleted() => IsVaultCredentialDeleted
            ? VaultCredentialDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultCredentialDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? VaultCredentialRefreshFailed { get; init; }
#else
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? VaultCredentialRefreshFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultCredentialRefreshFailed))]
#endif
        public bool IsVaultCredentialRefreshFailed => VaultCredentialRefreshFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVaultCredentialRefreshFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? value)
        {
            value = VaultCredentialRefreshFailed;
            return IsVaultCredentialRefreshFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData PickVaultCredentialRefreshFailed() => IsVaultCredentialRefreshFailed
            ? VaultCredentialRefreshFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultCredentialRefreshFailed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionCreatedEventData?(BetaWebhookEventData @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionCreatedEventData? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionCreated(global::Anthropic.BetaWebhookSessionCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionPendingEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionPendingEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionPendingEventData?(BetaWebhookEventData @this) => @this.SessionPending;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionPendingEventData? value)
        {
            SessionPending = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionPending(global::Anthropic.BetaWebhookSessionPendingEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionRunningEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionRunningEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionRunningEventData?(BetaWebhookEventData @this) => @this.SessionRunning;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionRunningEventData? value)
        {
            SessionRunning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionRunning(global::Anthropic.BetaWebhookSessionRunningEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionIdledEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionIdledEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionIdledEventData?(BetaWebhookEventData @this) => @this.SessionIdled;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionIdledEventData? value)
        {
            SessionIdled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionIdled(global::Anthropic.BetaWebhookSessionIdledEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionRequiresActionEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionRequiresActionEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionRequiresActionEventData?(BetaWebhookEventData @this) => @this.SessionRequiresAction;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionRequiresActionEventData? value)
        {
            SessionRequiresAction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionRequiresAction(global::Anthropic.BetaWebhookSessionRequiresActionEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionArchivedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionArchivedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionArchivedEventData?(BetaWebhookEventData @this) => @this.SessionArchived;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionArchivedEventData? value)
        {
            SessionArchived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionArchived(global::Anthropic.BetaWebhookSessionArchivedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionDeletedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionDeletedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionDeletedEventData?(BetaWebhookEventData @this) => @this.SessionDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionDeletedEventData? value)
        {
            SessionDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionDeleted(global::Anthropic.BetaWebhookSessionDeletedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionStatusRescheduledEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionStatusRescheduledEventData?(BetaWebhookEventData @this) => @this.SessionStatusRescheduled;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? value)
        {
            SessionStatusRescheduled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionStatusRescheduled(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionStatusRunStartedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionStatusRunStartedEventData?(BetaWebhookEventData @this) => @this.SessionStatusRunStarted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? value)
        {
            SessionStatusRunStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionStatusRunStarted(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusIdledEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionStatusIdledEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionStatusIdledEventData?(BetaWebhookEventData @this) => @this.SessionStatusIdled;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusIdledEventData? value)
        {
            SessionStatusIdled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionStatusIdled(global::Anthropic.BetaWebhookSessionStatusIdledEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionStatusTerminatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionStatusTerminatedEventData?(BetaWebhookEventData @this) => @this.SessionStatusTerminated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? value)
        {
            SessionStatusTerminated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionStatusTerminated(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionThreadCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionThreadCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionThreadCreatedEventData?(BetaWebhookEventData @this) => @this.SessionThreadCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionThreadCreatedEventData? value)
        {
            SessionThreadCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionThreadCreated(global::Anthropic.BetaWebhookSessionThreadCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionThreadIdledEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionThreadIdledEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionThreadIdledEventData?(BetaWebhookEventData @this) => @this.SessionThreadIdled;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionThreadIdledEventData? value)
        {
            SessionThreadIdled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionThreadIdled(global::Anthropic.BetaWebhookSessionThreadIdledEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionThreadTerminatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionThreadTerminatedEventData?(BetaWebhookEventData @this) => @this.SessionThreadTerminated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? value)
        {
            SessionThreadTerminated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionThreadTerminated(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData?(BetaWebhookEventData @this) => @this.SessionOutcomeEvaluationEnded;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? value)
        {
            SessionOutcomeEvaluationEnded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionOutcomeEvaluationEnded(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookVaultCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookVaultCreatedEventData?(BetaWebhookEventData @this) => @this.VaultCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCreatedEventData? value)
        {
            VaultCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromVaultCreated(global::Anthropic.BetaWebhookVaultCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookVaultArchivedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookVaultArchivedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookVaultArchivedEventData?(BetaWebhookEventData @this) => @this.VaultArchived;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookVaultArchivedEventData? value)
        {
            VaultArchived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromVaultArchived(global::Anthropic.BetaWebhookVaultArchivedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookVaultDeletedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookVaultDeletedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookVaultDeletedEventData?(BetaWebhookEventData @this) => @this.VaultDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookVaultDeletedEventData? value)
        {
            VaultDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromVaultDeleted(global::Anthropic.BetaWebhookVaultDeletedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookVaultCredentialCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookVaultCredentialCreatedEventData?(BetaWebhookEventData @this) => @this.VaultCredentialCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? value)
        {
            VaultCredentialCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromVaultCredentialCreated(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookVaultCredentialArchivedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookVaultCredentialArchivedEventData?(BetaWebhookEventData @this) => @this.VaultCredentialArchived;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? value)
        {
            VaultCredentialArchived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromVaultCredentialArchived(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookVaultCredentialDeletedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookVaultCredentialDeletedEventData?(BetaWebhookEventData @this) => @this.VaultCredentialDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? value)
        {
            VaultCredentialDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromVaultCredentialDeleted(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData?(BetaWebhookEventData @this) => @this.VaultCredentialRefreshFailed;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? value)
        {
            VaultCredentialRefreshFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromVaultCredentialRefreshFailed(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(
            global::Anthropic.BetaWebhookEventDataDiscriminatorType? type,
            global::Anthropic.BetaWebhookSessionCreatedEventData? sessionCreated,
            global::Anthropic.BetaWebhookSessionPendingEventData? sessionPending,
            global::Anthropic.BetaWebhookSessionRunningEventData? sessionRunning,
            global::Anthropic.BetaWebhookSessionIdledEventData? sessionIdled,
            global::Anthropic.BetaWebhookSessionRequiresActionEventData? sessionRequiresAction,
            global::Anthropic.BetaWebhookSessionArchivedEventData? sessionArchived,
            global::Anthropic.BetaWebhookSessionDeletedEventData? sessionDeleted,
            global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? sessionStatusRescheduled,
            global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? sessionStatusRunStarted,
            global::Anthropic.BetaWebhookSessionStatusIdledEventData? sessionStatusIdled,
            global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? sessionStatusTerminated,
            global::Anthropic.BetaWebhookSessionThreadCreatedEventData? sessionThreadCreated,
            global::Anthropic.BetaWebhookSessionThreadIdledEventData? sessionThreadIdled,
            global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? sessionThreadTerminated,
            global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? sessionOutcomeEvaluationEnded,
            global::Anthropic.BetaWebhookVaultCreatedEventData? vaultCreated,
            global::Anthropic.BetaWebhookVaultArchivedEventData? vaultArchived,
            global::Anthropic.BetaWebhookVaultDeletedEventData? vaultDeleted,
            global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? vaultCredentialCreated,
            global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? vaultCredentialArchived,
            global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? vaultCredentialDeleted,
            global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? vaultCredentialRefreshFailed
            )
        {
            Type = type;

            SessionCreated = sessionCreated;
            SessionPending = sessionPending;
            SessionRunning = sessionRunning;
            SessionIdled = sessionIdled;
            SessionRequiresAction = sessionRequiresAction;
            SessionArchived = sessionArchived;
            SessionDeleted = sessionDeleted;
            SessionStatusRescheduled = sessionStatusRescheduled;
            SessionStatusRunStarted = sessionStatusRunStarted;
            SessionStatusIdled = sessionStatusIdled;
            SessionStatusTerminated = sessionStatusTerminated;
            SessionThreadCreated = sessionThreadCreated;
            SessionThreadIdled = sessionThreadIdled;
            SessionThreadTerminated = sessionThreadTerminated;
            SessionOutcomeEvaluationEnded = sessionOutcomeEvaluationEnded;
            VaultCreated = vaultCreated;
            VaultArchived = vaultArchived;
            VaultDeleted = vaultDeleted;
            VaultCredentialCreated = vaultCredentialCreated;
            VaultCredentialArchived = vaultCredentialArchived;
            VaultCredentialDeleted = vaultCredentialDeleted;
            VaultCredentialRefreshFailed = vaultCredentialRefreshFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VaultCredentialRefreshFailed as object ??
            VaultCredentialDeleted as object ??
            VaultCredentialArchived as object ??
            VaultCredentialCreated as object ??
            VaultDeleted as object ??
            VaultArchived as object ??
            VaultCreated as object ??
            SessionOutcomeEvaluationEnded as object ??
            SessionThreadTerminated as object ??
            SessionThreadIdled as object ??
            SessionThreadCreated as object ??
            SessionStatusTerminated as object ??
            SessionStatusIdled as object ??
            SessionStatusRunStarted as object ??
            SessionStatusRescheduled as object ??
            SessionDeleted as object ??
            SessionArchived as object ??
            SessionRequiresAction as object ??
            SessionIdled as object ??
            SessionRunning as object ??
            SessionPending as object ??
            SessionCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionCreated?.ToString() ??
            SessionPending?.ToString() ??
            SessionRunning?.ToString() ??
            SessionIdled?.ToString() ??
            SessionRequiresAction?.ToString() ??
            SessionArchived?.ToString() ??
            SessionDeleted?.ToString() ??
            SessionStatusRescheduled?.ToString() ??
            SessionStatusRunStarted?.ToString() ??
            SessionStatusIdled?.ToString() ??
            SessionStatusTerminated?.ToString() ??
            SessionThreadCreated?.ToString() ??
            SessionThreadIdled?.ToString() ??
            SessionThreadTerminated?.ToString() ??
            SessionOutcomeEvaluationEnded?.ToString() ??
            VaultCreated?.ToString() ??
            VaultArchived?.ToString() ??
            VaultDeleted?.ToString() ??
            VaultCredentialCreated?.ToString() ??
            VaultCredentialArchived?.ToString() ??
            VaultCredentialDeleted?.ToString() ??
            VaultCredentialRefreshFailed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && IsVaultCredentialRefreshFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaWebhookSessionCreatedEventData, TResult>? sessionCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionPendingEventData, TResult>? sessionPending = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionRunningEventData, TResult>? sessionRunning = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionIdledEventData, TResult>? sessionIdled = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionRequiresActionEventData, TResult>? sessionRequiresAction = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionArchivedEventData, TResult>? sessionArchived = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionDeletedEventData, TResult>? sessionDeleted = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionStatusRescheduledEventData, TResult>? sessionStatusRescheduled = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionStatusRunStartedEventData, TResult>? sessionStatusRunStarted = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionStatusIdledEventData, TResult>? sessionStatusIdled = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionStatusTerminatedEventData, TResult>? sessionStatusTerminated = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionThreadCreatedEventData, TResult>? sessionThreadCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionThreadIdledEventData, TResult>? sessionThreadIdled = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionThreadTerminatedEventData, TResult>? sessionThreadTerminated = null,
            global::System.Func<global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData, TResult>? sessionOutcomeEvaluationEnded = null,
            global::System.Func<global::Anthropic.BetaWebhookVaultCreatedEventData, TResult>? vaultCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookVaultArchivedEventData, TResult>? vaultArchived = null,
            global::System.Func<global::Anthropic.BetaWebhookVaultDeletedEventData, TResult>? vaultDeleted = null,
            global::System.Func<global::Anthropic.BetaWebhookVaultCredentialCreatedEventData, TResult>? vaultCredentialCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookVaultCredentialArchivedEventData, TResult>? vaultCredentialArchived = null,
            global::System.Func<global::Anthropic.BetaWebhookVaultCredentialDeletedEventData, TResult>? vaultCredentialDeleted = null,
            global::System.Func<global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData, TResult>? vaultCredentialRefreshFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionPending && sessionPending != null)
            {
                return sessionPending(SessionPending!);
            }
            else if (IsSessionRunning && sessionRunning != null)
            {
                return sessionRunning(SessionRunning!);
            }
            else if (IsSessionIdled && sessionIdled != null)
            {
                return sessionIdled(SessionIdled!);
            }
            else if (IsSessionRequiresAction && sessionRequiresAction != null)
            {
                return sessionRequiresAction(SessionRequiresAction!);
            }
            else if (IsSessionArchived && sessionArchived != null)
            {
                return sessionArchived(SessionArchived!);
            }
            else if (IsSessionDeleted && sessionDeleted != null)
            {
                return sessionDeleted(SessionDeleted!);
            }
            else if (IsSessionStatusRescheduled && sessionStatusRescheduled != null)
            {
                return sessionStatusRescheduled(SessionStatusRescheduled!);
            }
            else if (IsSessionStatusRunStarted && sessionStatusRunStarted != null)
            {
                return sessionStatusRunStarted(SessionStatusRunStarted!);
            }
            else if (IsSessionStatusIdled && sessionStatusIdled != null)
            {
                return sessionStatusIdled(SessionStatusIdled!);
            }
            else if (IsSessionStatusTerminated && sessionStatusTerminated != null)
            {
                return sessionStatusTerminated(SessionStatusTerminated!);
            }
            else if (IsSessionThreadCreated && sessionThreadCreated != null)
            {
                return sessionThreadCreated(SessionThreadCreated!);
            }
            else if (IsSessionThreadIdled && sessionThreadIdled != null)
            {
                return sessionThreadIdled(SessionThreadIdled!);
            }
            else if (IsSessionThreadTerminated && sessionThreadTerminated != null)
            {
                return sessionThreadTerminated(SessionThreadTerminated!);
            }
            else if (IsSessionOutcomeEvaluationEnded && sessionOutcomeEvaluationEnded != null)
            {
                return sessionOutcomeEvaluationEnded(SessionOutcomeEvaluationEnded!);
            }
            else if (IsVaultCreated && vaultCreated != null)
            {
                return vaultCreated(VaultCreated!);
            }
            else if (IsVaultArchived && vaultArchived != null)
            {
                return vaultArchived(VaultArchived!);
            }
            else if (IsVaultDeleted && vaultDeleted != null)
            {
                return vaultDeleted(VaultDeleted!);
            }
            else if (IsVaultCredentialCreated && vaultCredentialCreated != null)
            {
                return vaultCredentialCreated(VaultCredentialCreated!);
            }
            else if (IsVaultCredentialArchived && vaultCredentialArchived != null)
            {
                return vaultCredentialArchived(VaultCredentialArchived!);
            }
            else if (IsVaultCredentialDeleted && vaultCredentialDeleted != null)
            {
                return vaultCredentialDeleted(VaultCredentialDeleted!);
            }
            else if (IsVaultCredentialRefreshFailed && vaultCredentialRefreshFailed != null)
            {
                return vaultCredentialRefreshFailed(VaultCredentialRefreshFailed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaWebhookSessionCreatedEventData>? sessionCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionPendingEventData>? sessionPending = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionRunningEventData>? sessionRunning = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionIdledEventData>? sessionIdled = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionRequiresActionEventData>? sessionRequiresAction = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionArchivedEventData>? sessionArchived = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionDeletedEventData>? sessionDeleted = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionStatusRescheduledEventData>? sessionStatusRescheduled = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionStatusRunStartedEventData>? sessionStatusRunStarted = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionStatusIdledEventData>? sessionStatusIdled = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionStatusTerminatedEventData>? sessionStatusTerminated = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionThreadCreatedEventData>? sessionThreadCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionThreadIdledEventData>? sessionThreadIdled = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionThreadTerminatedEventData>? sessionThreadTerminated = null,

            global::System.Action<global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData>? sessionOutcomeEvaluationEnded = null,

            global::System.Action<global::Anthropic.BetaWebhookVaultCreatedEventData>? vaultCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookVaultArchivedEventData>? vaultArchived = null,

            global::System.Action<global::Anthropic.BetaWebhookVaultDeletedEventData>? vaultDeleted = null,

            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialCreatedEventData>? vaultCredentialCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialArchivedEventData>? vaultCredentialArchived = null,

            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialDeletedEventData>? vaultCredentialDeleted = null,

            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData>? vaultCredentialRefreshFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionPending)
            {
                sessionPending?.Invoke(SessionPending!);
            }
            else if (IsSessionRunning)
            {
                sessionRunning?.Invoke(SessionRunning!);
            }
            else if (IsSessionIdled)
            {
                sessionIdled?.Invoke(SessionIdled!);
            }
            else if (IsSessionRequiresAction)
            {
                sessionRequiresAction?.Invoke(SessionRequiresAction!);
            }
            else if (IsSessionArchived)
            {
                sessionArchived?.Invoke(SessionArchived!);
            }
            else if (IsSessionDeleted)
            {
                sessionDeleted?.Invoke(SessionDeleted!);
            }
            else if (IsSessionStatusRescheduled)
            {
                sessionStatusRescheduled?.Invoke(SessionStatusRescheduled!);
            }
            else if (IsSessionStatusRunStarted)
            {
                sessionStatusRunStarted?.Invoke(SessionStatusRunStarted!);
            }
            else if (IsSessionStatusIdled)
            {
                sessionStatusIdled?.Invoke(SessionStatusIdled!);
            }
            else if (IsSessionStatusTerminated)
            {
                sessionStatusTerminated?.Invoke(SessionStatusTerminated!);
            }
            else if (IsSessionThreadCreated)
            {
                sessionThreadCreated?.Invoke(SessionThreadCreated!);
            }
            else if (IsSessionThreadIdled)
            {
                sessionThreadIdled?.Invoke(SessionThreadIdled!);
            }
            else if (IsSessionThreadTerminated)
            {
                sessionThreadTerminated?.Invoke(SessionThreadTerminated!);
            }
            else if (IsSessionOutcomeEvaluationEnded)
            {
                sessionOutcomeEvaluationEnded?.Invoke(SessionOutcomeEvaluationEnded!);
            }
            else if (IsVaultCreated)
            {
                vaultCreated?.Invoke(VaultCreated!);
            }
            else if (IsVaultArchived)
            {
                vaultArchived?.Invoke(VaultArchived!);
            }
            else if (IsVaultDeleted)
            {
                vaultDeleted?.Invoke(VaultDeleted!);
            }
            else if (IsVaultCredentialCreated)
            {
                vaultCredentialCreated?.Invoke(VaultCredentialCreated!);
            }
            else if (IsVaultCredentialArchived)
            {
                vaultCredentialArchived?.Invoke(VaultCredentialArchived!);
            }
            else if (IsVaultCredentialDeleted)
            {
                vaultCredentialDeleted?.Invoke(VaultCredentialDeleted!);
            }
            else if (IsVaultCredentialRefreshFailed)
            {
                vaultCredentialRefreshFailed?.Invoke(VaultCredentialRefreshFailed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaWebhookSessionCreatedEventData>? sessionCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionPendingEventData>? sessionPending = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionRunningEventData>? sessionRunning = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionIdledEventData>? sessionIdled = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionRequiresActionEventData>? sessionRequiresAction = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionArchivedEventData>? sessionArchived = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionDeletedEventData>? sessionDeleted = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionStatusRescheduledEventData>? sessionStatusRescheduled = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionStatusRunStartedEventData>? sessionStatusRunStarted = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionStatusIdledEventData>? sessionStatusIdled = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionStatusTerminatedEventData>? sessionStatusTerminated = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionThreadCreatedEventData>? sessionThreadCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionThreadIdledEventData>? sessionThreadIdled = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionThreadTerminatedEventData>? sessionThreadTerminated = null,
            global::System.Action<global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData>? sessionOutcomeEvaluationEnded = null,
            global::System.Action<global::Anthropic.BetaWebhookVaultCreatedEventData>? vaultCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookVaultArchivedEventData>? vaultArchived = null,
            global::System.Action<global::Anthropic.BetaWebhookVaultDeletedEventData>? vaultDeleted = null,
            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialCreatedEventData>? vaultCredentialCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialArchivedEventData>? vaultCredentialArchived = null,
            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialDeletedEventData>? vaultCredentialDeleted = null,
            global::System.Action<global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData>? vaultCredentialRefreshFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionPending)
            {
                sessionPending?.Invoke(SessionPending!);
            }
            else if (IsSessionRunning)
            {
                sessionRunning?.Invoke(SessionRunning!);
            }
            else if (IsSessionIdled)
            {
                sessionIdled?.Invoke(SessionIdled!);
            }
            else if (IsSessionRequiresAction)
            {
                sessionRequiresAction?.Invoke(SessionRequiresAction!);
            }
            else if (IsSessionArchived)
            {
                sessionArchived?.Invoke(SessionArchived!);
            }
            else if (IsSessionDeleted)
            {
                sessionDeleted?.Invoke(SessionDeleted!);
            }
            else if (IsSessionStatusRescheduled)
            {
                sessionStatusRescheduled?.Invoke(SessionStatusRescheduled!);
            }
            else if (IsSessionStatusRunStarted)
            {
                sessionStatusRunStarted?.Invoke(SessionStatusRunStarted!);
            }
            else if (IsSessionStatusIdled)
            {
                sessionStatusIdled?.Invoke(SessionStatusIdled!);
            }
            else if (IsSessionStatusTerminated)
            {
                sessionStatusTerminated?.Invoke(SessionStatusTerminated!);
            }
            else if (IsSessionThreadCreated)
            {
                sessionThreadCreated?.Invoke(SessionThreadCreated!);
            }
            else if (IsSessionThreadIdled)
            {
                sessionThreadIdled?.Invoke(SessionThreadIdled!);
            }
            else if (IsSessionThreadTerminated)
            {
                sessionThreadTerminated?.Invoke(SessionThreadTerminated!);
            }
            else if (IsSessionOutcomeEvaluationEnded)
            {
                sessionOutcomeEvaluationEnded?.Invoke(SessionOutcomeEvaluationEnded!);
            }
            else if (IsVaultCreated)
            {
                vaultCreated?.Invoke(VaultCreated!);
            }
            else if (IsVaultArchived)
            {
                vaultArchived?.Invoke(VaultArchived!);
            }
            else if (IsVaultDeleted)
            {
                vaultDeleted?.Invoke(VaultDeleted!);
            }
            else if (IsVaultCredentialCreated)
            {
                vaultCredentialCreated?.Invoke(VaultCredentialCreated!);
            }
            else if (IsVaultCredentialArchived)
            {
                vaultCredentialArchived?.Invoke(VaultCredentialArchived!);
            }
            else if (IsVaultCredentialDeleted)
            {
                vaultCredentialDeleted?.Invoke(VaultCredentialDeleted!);
            }
            else if (IsVaultCredentialRefreshFailed)
            {
                vaultCredentialRefreshFailed?.Invoke(VaultCredentialRefreshFailed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionCreated,
                typeof(global::Anthropic.BetaWebhookSessionCreatedEventData),
                SessionPending,
                typeof(global::Anthropic.BetaWebhookSessionPendingEventData),
                SessionRunning,
                typeof(global::Anthropic.BetaWebhookSessionRunningEventData),
                SessionIdled,
                typeof(global::Anthropic.BetaWebhookSessionIdledEventData),
                SessionRequiresAction,
                typeof(global::Anthropic.BetaWebhookSessionRequiresActionEventData),
                SessionArchived,
                typeof(global::Anthropic.BetaWebhookSessionArchivedEventData),
                SessionDeleted,
                typeof(global::Anthropic.BetaWebhookSessionDeletedEventData),
                SessionStatusRescheduled,
                typeof(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData),
                SessionStatusRunStarted,
                typeof(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData),
                SessionStatusIdled,
                typeof(global::Anthropic.BetaWebhookSessionStatusIdledEventData),
                SessionStatusTerminated,
                typeof(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData),
                SessionThreadCreated,
                typeof(global::Anthropic.BetaWebhookSessionThreadCreatedEventData),
                SessionThreadIdled,
                typeof(global::Anthropic.BetaWebhookSessionThreadIdledEventData),
                SessionThreadTerminated,
                typeof(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData),
                SessionOutcomeEvaluationEnded,
                typeof(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData),
                VaultCreated,
                typeof(global::Anthropic.BetaWebhookVaultCreatedEventData),
                VaultArchived,
                typeof(global::Anthropic.BetaWebhookVaultArchivedEventData),
                VaultDeleted,
                typeof(global::Anthropic.BetaWebhookVaultDeletedEventData),
                VaultCredentialCreated,
                typeof(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData),
                VaultCredentialArchived,
                typeof(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData),
                VaultCredentialDeleted,
                typeof(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData),
                VaultCredentialRefreshFailed,
                typeof(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData),
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
        public bool Equals(BetaWebhookEventData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionCreatedEventData?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionPendingEventData?>.Default.Equals(SessionPending, other.SessionPending) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionRunningEventData?>.Default.Equals(SessionRunning, other.SessionRunning) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionIdledEventData?>.Default.Equals(SessionIdled, other.SessionIdled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionRequiresActionEventData?>.Default.Equals(SessionRequiresAction, other.SessionRequiresAction) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionArchivedEventData?>.Default.Equals(SessionArchived, other.SessionArchived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionDeletedEventData?>.Default.Equals(SessionDeleted, other.SessionDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionStatusRescheduledEventData?>.Default.Equals(SessionStatusRescheduled, other.SessionStatusRescheduled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionStatusRunStartedEventData?>.Default.Equals(SessionStatusRunStarted, other.SessionStatusRunStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionStatusIdledEventData?>.Default.Equals(SessionStatusIdled, other.SessionStatusIdled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionStatusTerminatedEventData?>.Default.Equals(SessionStatusTerminated, other.SessionStatusTerminated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionThreadCreatedEventData?>.Default.Equals(SessionThreadCreated, other.SessionThreadCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionThreadIdledEventData?>.Default.Equals(SessionThreadIdled, other.SessionThreadIdled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionThreadTerminatedEventData?>.Default.Equals(SessionThreadTerminated, other.SessionThreadTerminated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData?>.Default.Equals(SessionOutcomeEvaluationEnded, other.SessionOutcomeEvaluationEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultCreatedEventData?>.Default.Equals(VaultCreated, other.VaultCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultArchivedEventData?>.Default.Equals(VaultArchived, other.VaultArchived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultDeletedEventData?>.Default.Equals(VaultDeleted, other.VaultDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultCredentialCreatedEventData?>.Default.Equals(VaultCredentialCreated, other.VaultCredentialCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultCredentialArchivedEventData?>.Default.Equals(VaultCredentialArchived, other.VaultCredentialArchived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultCredentialDeletedEventData?>.Default.Equals(VaultCredentialDeleted, other.VaultCredentialDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData?>.Default.Equals(VaultCredentialRefreshFailed, other.VaultCredentialRefreshFailed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaWebhookEventData obj1, BetaWebhookEventData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaWebhookEventData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaWebhookEventData obj1, BetaWebhookEventData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaWebhookEventData o && Equals(o);
        }
    }
}
