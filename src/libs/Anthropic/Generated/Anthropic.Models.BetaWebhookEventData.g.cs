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
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookSessionUpdatedEventData? SessionUpdated { get; init; }
#else
        public global::Anthropic.BetaWebhookSessionUpdatedEventData? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookSessionUpdatedEventData? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookSessionUpdatedEventData PickSessionUpdated() => IsSessionUpdated
            ? SessionUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookAgentCreatedEventData? AgentCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookAgentCreatedEventData? AgentCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentCreated))]
#endif
        public bool IsAgentCreated => AgentCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookAgentCreatedEventData? value)
        {
            value = AgentCreated;
            return IsAgentCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookAgentCreatedEventData PickAgentCreated() => IsAgentCreated
            ? AgentCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookAgentArchivedEventData? AgentArchived { get; init; }
#else
        public global::Anthropic.BetaWebhookAgentArchivedEventData? AgentArchived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentArchived))]
#endif
        public bool IsAgentArchived => AgentArchived != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookAgentArchivedEventData? value)
        {
            value = AgentArchived;
            return IsAgentArchived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookAgentArchivedEventData PickAgentArchived() => IsAgentArchived
            ? AgentArchived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentArchived' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookAgentDeletedEventData? AgentDeleted { get; init; }
#else
        public global::Anthropic.BetaWebhookAgentDeletedEventData? AgentDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentDeleted))]
#endif
        public bool IsAgentDeleted => AgentDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookAgentDeletedEventData? value)
        {
            value = AgentDeleted;
            return IsAgentDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookAgentDeletedEventData PickAgentDeleted() => IsAgentDeleted
            ? AgentDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentPausedEventData? DeploymentPaused { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentPausedEventData? DeploymentPaused { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentPaused))]
#endif
        public bool IsDeploymentPaused => DeploymentPaused != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentPaused(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentPausedEventData? value)
        {
            value = DeploymentPaused;
            return IsDeploymentPaused;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentPausedEventData PickDeploymentPaused() => IsDeploymentPaused
            ? DeploymentPaused!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentPaused' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData? DeploymentRunFailed { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData? DeploymentRunFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentRunFailed))]
#endif
        public bool IsDeploymentRunFailed => DeploymentRunFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentRunFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentRunFailedEventData? value)
        {
            value = DeploymentRunFailed;
            return IsDeploymentRunFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunFailedEventData PickDeploymentRunFailed() => IsDeploymentRunFailed
            ? DeploymentRunFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentRunFailed' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData? DeploymentCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData? DeploymentCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentCreated))]
#endif
        public bool IsDeploymentCreated => DeploymentCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentCreatedEventData? value)
        {
            value = DeploymentCreated;
            return IsDeploymentCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentCreatedEventData PickDeploymentCreated() => IsDeploymentCreated
            ? DeploymentCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData? DeploymentUpdated { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData? DeploymentUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentUpdated))]
#endif
        public bool IsDeploymentUpdated => DeploymentUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentUpdatedEventData? value)
        {
            value = DeploymentUpdated;
            return IsDeploymentUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUpdatedEventData PickDeploymentUpdated() => IsDeploymentUpdated
            ? DeploymentUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData? DeploymentUnpaused { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData? DeploymentUnpaused { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentUnpaused))]
#endif
        public bool IsDeploymentUnpaused => DeploymentUnpaused != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentUnpaused(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentUnpausedEventData? value)
        {
            value = DeploymentUnpaused;
            return IsDeploymentUnpaused;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentUnpausedEventData PickDeploymentUnpaused() => IsDeploymentUnpaused
            ? DeploymentUnpaused!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentUnpaused' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookAgentUpdatedEventData? AgentUpdated { get; init; }
#else
        public global::Anthropic.BetaWebhookAgentUpdatedEventData? AgentUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentUpdated))]
#endif
        public bool IsAgentUpdated => AgentUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookAgentUpdatedEventData? value)
        {
            value = AgentUpdated;
            return IsAgentUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookAgentUpdatedEventData PickAgentUpdated() => IsAgentUpdated
            ? AgentUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData? DeploymentArchived { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData? DeploymentArchived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentArchived))]
#endif
        public bool IsDeploymentArchived => DeploymentArchived != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentArchivedEventData? value)
        {
            value = DeploymentArchived;
            return IsDeploymentArchived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentArchivedEventData PickDeploymentArchived() => IsDeploymentArchived
            ? DeploymentArchived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentArchived' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData? DeploymentRunStarted { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData? DeploymentRunStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentRunStarted))]
#endif
        public bool IsDeploymentRunStarted => DeploymentRunStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentRunStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentRunStartedEventData? value)
        {
            value = DeploymentRunStarted;
            return IsDeploymentRunStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunStartedEventData PickDeploymentRunStarted() => IsDeploymentRunStarted
            ? DeploymentRunStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentRunStarted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData? DeploymentDeleted { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData? DeploymentDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentDeleted))]
#endif
        public bool IsDeploymentDeleted => DeploymentDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentDeletedEventData? value)
        {
            value = DeploymentDeleted;
            return IsDeploymentDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentDeletedEventData PickDeploymentDeleted() => IsDeploymentDeleted
            ? DeploymentDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? DeploymentRunSucceeded { get; init; }
#else
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? DeploymentRunSucceeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentRunSucceeded))]
#endif
        public bool IsDeploymentRunSucceeded => DeploymentRunSucceeded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeploymentRunSucceeded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? value)
        {
            value = DeploymentRunSucceeded;
            return IsDeploymentRunSucceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookDeploymentRunSucceededEventData PickDeploymentRunSucceeded() => IsDeploymentRunSucceeded
            ? DeploymentRunSucceeded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeploymentRunSucceeded' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData? EnvironmentCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData? EnvironmentCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentCreated))]
#endif
        public bool IsEnvironmentCreated => EnvironmentCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookEnvironmentCreatedEventData? value)
        {
            value = EnvironmentCreated;
            return IsEnvironmentCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentCreatedEventData PickEnvironmentCreated() => IsEnvironmentCreated
            ? EnvironmentCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? EnvironmentUpdated { get; init; }
#else
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? EnvironmentUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentUpdated))]
#endif
        public bool IsEnvironmentUpdated => EnvironmentUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? value)
        {
            value = EnvironmentUpdated;
            return IsEnvironmentUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentUpdatedEventData PickEnvironmentUpdated() => IsEnvironmentUpdated
            ? EnvironmentUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData? EnvironmentArchived { get; init; }
#else
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData? EnvironmentArchived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentArchived))]
#endif
        public bool IsEnvironmentArchived => EnvironmentArchived != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookEnvironmentArchivedEventData? value)
        {
            value = EnvironmentArchived;
            return IsEnvironmentArchived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentArchivedEventData PickEnvironmentArchived() => IsEnvironmentArchived
            ? EnvironmentArchived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentArchived' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData? EnvironmentDeleted { get; init; }
#else
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData? EnvironmentDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentDeleted))]
#endif
        public bool IsEnvironmentDeleted => EnvironmentDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookEnvironmentDeletedEventData? value)
        {
            value = EnvironmentDeleted;
            return IsEnvironmentDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookEnvironmentDeletedEventData PickEnvironmentDeleted() => IsEnvironmentDeleted
            ? EnvironmentDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentDeleted' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? MemoryStoreCreated { get; init; }
#else
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? MemoryStoreCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryStoreCreated))]
#endif
        public bool IsMemoryStoreCreated => MemoryStoreCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMemoryStoreCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? value)
        {
            value = MemoryStoreCreated;
            return IsMemoryStoreCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreCreatedEventData PickMemoryStoreCreated() => IsMemoryStoreCreated
            ? MemoryStoreCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStoreCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? MemoryStoreArchived { get; init; }
#else
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? MemoryStoreArchived { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryStoreArchived))]
#endif
        public bool IsMemoryStoreArchived => MemoryStoreArchived != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMemoryStoreArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? value)
        {
            value = MemoryStoreArchived;
            return IsMemoryStoreArchived;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreArchivedEventData PickMemoryStoreArchived() => IsMemoryStoreArchived
            ? MemoryStoreArchived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStoreArchived' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? MemoryStoreDeleted { get; init; }
#else
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? MemoryStoreDeleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryStoreDeleted))]
#endif
        public bool IsMemoryStoreDeleted => MemoryStoreDeleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMemoryStoreDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? value)
        {
            value = MemoryStoreDeleted;
            return IsMemoryStoreDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaWebhookMemoryStoreDeletedEventData PickMemoryStoreDeleted() => IsMemoryStoreDeleted
            ? MemoryStoreDeleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStoreDeleted' but the value was {ToString()}.");
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
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookSessionUpdatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookSessionUpdatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookSessionUpdatedEventData?(BetaWebhookEventData @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookSessionUpdatedEventData? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromSessionUpdated(global::Anthropic.BetaWebhookSessionUpdatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookAgentCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookAgentCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookAgentCreatedEventData?(BetaWebhookEventData @this) => @this.AgentCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookAgentCreatedEventData? value)
        {
            AgentCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromAgentCreated(global::Anthropic.BetaWebhookAgentCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookAgentArchivedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookAgentArchivedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookAgentArchivedEventData?(BetaWebhookEventData @this) => @this.AgentArchived;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookAgentArchivedEventData? value)
        {
            AgentArchived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromAgentArchived(global::Anthropic.BetaWebhookAgentArchivedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookAgentDeletedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookAgentDeletedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookAgentDeletedEventData?(BetaWebhookEventData @this) => @this.AgentDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookAgentDeletedEventData? value)
        {
            AgentDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromAgentDeleted(global::Anthropic.BetaWebhookAgentDeletedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentPausedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentPausedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentPausedEventData?(BetaWebhookEventData @this) => @this.DeploymentPaused;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentPausedEventData? value)
        {
            DeploymentPaused = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentPaused(global::Anthropic.BetaWebhookDeploymentPausedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentRunFailedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentRunFailedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentRunFailedEventData?(BetaWebhookEventData @this) => @this.DeploymentRunFailed;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentRunFailedEventData? value)
        {
            DeploymentRunFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentRunFailed(global::Anthropic.BetaWebhookDeploymentRunFailedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentCreatedEventData?(BetaWebhookEventData @this) => @this.DeploymentCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentCreatedEventData? value)
        {
            DeploymentCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentCreated(global::Anthropic.BetaWebhookDeploymentCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentUpdatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentUpdatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentUpdatedEventData?(BetaWebhookEventData @this) => @this.DeploymentUpdated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentUpdatedEventData? value)
        {
            DeploymentUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentUpdated(global::Anthropic.BetaWebhookDeploymentUpdatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentUnpausedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentUnpausedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentUnpausedEventData?(BetaWebhookEventData @this) => @this.DeploymentUnpaused;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentUnpausedEventData? value)
        {
            DeploymentUnpaused = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentUnpaused(global::Anthropic.BetaWebhookDeploymentUnpausedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookAgentUpdatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookAgentUpdatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookAgentUpdatedEventData?(BetaWebhookEventData @this) => @this.AgentUpdated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookAgentUpdatedEventData? value)
        {
            AgentUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromAgentUpdated(global::Anthropic.BetaWebhookAgentUpdatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentArchivedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentArchivedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentArchivedEventData?(BetaWebhookEventData @this) => @this.DeploymentArchived;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentArchivedEventData? value)
        {
            DeploymentArchived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentArchived(global::Anthropic.BetaWebhookDeploymentArchivedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentRunStartedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentRunStartedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentRunStartedEventData?(BetaWebhookEventData @this) => @this.DeploymentRunStarted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentRunStartedEventData? value)
        {
            DeploymentRunStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentRunStarted(global::Anthropic.BetaWebhookDeploymentRunStartedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentDeletedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentDeletedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentDeletedEventData?(BetaWebhookEventData @this) => @this.DeploymentDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentDeletedEventData? value)
        {
            DeploymentDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentDeleted(global::Anthropic.BetaWebhookDeploymentDeletedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookDeploymentRunSucceededEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookDeploymentRunSucceededEventData?(BetaWebhookEventData @this) => @this.DeploymentRunSucceeded;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? value)
        {
            DeploymentRunSucceeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromDeploymentRunSucceeded(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookEnvironmentCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookEnvironmentCreatedEventData?(BetaWebhookEventData @this) => @this.EnvironmentCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentCreatedEventData? value)
        {
            EnvironmentCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromEnvironmentCreated(global::Anthropic.BetaWebhookEnvironmentCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookEnvironmentUpdatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookEnvironmentUpdatedEventData?(BetaWebhookEventData @this) => @this.EnvironmentUpdated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? value)
        {
            EnvironmentUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromEnvironmentUpdated(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentArchivedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookEnvironmentArchivedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookEnvironmentArchivedEventData?(BetaWebhookEventData @this) => @this.EnvironmentArchived;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentArchivedEventData? value)
        {
            EnvironmentArchived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromEnvironmentArchived(global::Anthropic.BetaWebhookEnvironmentArchivedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentDeletedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookEnvironmentDeletedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookEnvironmentDeletedEventData?(BetaWebhookEventData @this) => @this.EnvironmentDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookEnvironmentDeletedEventData? value)
        {
            EnvironmentDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromEnvironmentDeleted(global::Anthropic.BetaWebhookEnvironmentDeletedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookMemoryStoreCreatedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookMemoryStoreCreatedEventData?(BetaWebhookEventData @this) => @this.MemoryStoreCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? value)
        {
            MemoryStoreCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromMemoryStoreCreated(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookMemoryStoreArchivedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookMemoryStoreArchivedEventData?(BetaWebhookEventData @this) => @this.MemoryStoreArchived;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? value)
        {
            MemoryStoreArchived = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromMemoryStoreArchived(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? value) => new BetaWebhookEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaWebhookEventData(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData value) => new BetaWebhookEventData((global::Anthropic.BetaWebhookMemoryStoreDeletedEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebhookMemoryStoreDeletedEventData?(BetaWebhookEventData @this) => @this.MemoryStoreDeleted;

        /// <summary>
        /// 
        /// </summary>
        public BetaWebhookEventData(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? value)
        {
            MemoryStoreDeleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaWebhookEventData FromMemoryStoreDeleted(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? value) => new BetaWebhookEventData(value);

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
            global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? vaultCredentialRefreshFailed,
            global::Anthropic.BetaWebhookSessionUpdatedEventData? sessionUpdated,
            global::Anthropic.BetaWebhookAgentCreatedEventData? agentCreated,
            global::Anthropic.BetaWebhookAgentArchivedEventData? agentArchived,
            global::Anthropic.BetaWebhookAgentDeletedEventData? agentDeleted,
            global::Anthropic.BetaWebhookDeploymentPausedEventData? deploymentPaused,
            global::Anthropic.BetaWebhookDeploymentRunFailedEventData? deploymentRunFailed,
            global::Anthropic.BetaWebhookDeploymentCreatedEventData? deploymentCreated,
            global::Anthropic.BetaWebhookDeploymentUpdatedEventData? deploymentUpdated,
            global::Anthropic.BetaWebhookDeploymentUnpausedEventData? deploymentUnpaused,
            global::Anthropic.BetaWebhookAgentUpdatedEventData? agentUpdated,
            global::Anthropic.BetaWebhookDeploymentArchivedEventData? deploymentArchived,
            global::Anthropic.BetaWebhookDeploymentRunStartedEventData? deploymentRunStarted,
            global::Anthropic.BetaWebhookDeploymentDeletedEventData? deploymentDeleted,
            global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? deploymentRunSucceeded,
            global::Anthropic.BetaWebhookEnvironmentCreatedEventData? environmentCreated,
            global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? environmentUpdated,
            global::Anthropic.BetaWebhookEnvironmentArchivedEventData? environmentArchived,
            global::Anthropic.BetaWebhookEnvironmentDeletedEventData? environmentDeleted,
            global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? memoryStoreCreated,
            global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? memoryStoreArchived,
            global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? memoryStoreDeleted
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
            SessionUpdated = sessionUpdated;
            AgentCreated = agentCreated;
            AgentArchived = agentArchived;
            AgentDeleted = agentDeleted;
            DeploymentPaused = deploymentPaused;
            DeploymentRunFailed = deploymentRunFailed;
            DeploymentCreated = deploymentCreated;
            DeploymentUpdated = deploymentUpdated;
            DeploymentUnpaused = deploymentUnpaused;
            AgentUpdated = agentUpdated;
            DeploymentArchived = deploymentArchived;
            DeploymentRunStarted = deploymentRunStarted;
            DeploymentDeleted = deploymentDeleted;
            DeploymentRunSucceeded = deploymentRunSucceeded;
            EnvironmentCreated = environmentCreated;
            EnvironmentUpdated = environmentUpdated;
            EnvironmentArchived = environmentArchived;
            EnvironmentDeleted = environmentDeleted;
            MemoryStoreCreated = memoryStoreCreated;
            MemoryStoreArchived = memoryStoreArchived;
            MemoryStoreDeleted = memoryStoreDeleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MemoryStoreDeleted as object ??
            MemoryStoreArchived as object ??
            MemoryStoreCreated as object ??
            EnvironmentDeleted as object ??
            EnvironmentArchived as object ??
            EnvironmentUpdated as object ??
            EnvironmentCreated as object ??
            DeploymentRunSucceeded as object ??
            DeploymentDeleted as object ??
            DeploymentRunStarted as object ??
            DeploymentArchived as object ??
            AgentUpdated as object ??
            DeploymentUnpaused as object ??
            DeploymentUpdated as object ??
            DeploymentCreated as object ??
            DeploymentRunFailed as object ??
            DeploymentPaused as object ??
            AgentDeleted as object ??
            AgentArchived as object ??
            AgentCreated as object ??
            SessionUpdated as object ??
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
            VaultCredentialRefreshFailed?.ToString() ??
            SessionUpdated?.ToString() ??
            AgentCreated?.ToString() ??
            AgentArchived?.ToString() ??
            AgentDeleted?.ToString() ??
            DeploymentPaused?.ToString() ??
            DeploymentRunFailed?.ToString() ??
            DeploymentCreated?.ToString() ??
            DeploymentUpdated?.ToString() ??
            DeploymentUnpaused?.ToString() ??
            AgentUpdated?.ToString() ??
            DeploymentArchived?.ToString() ??
            DeploymentRunStarted?.ToString() ??
            DeploymentDeleted?.ToString() ??
            DeploymentRunSucceeded?.ToString() ??
            EnvironmentCreated?.ToString() ??
            EnvironmentUpdated?.ToString() ??
            EnvironmentArchived?.ToString() ??
            EnvironmentDeleted?.ToString() ??
            MemoryStoreCreated?.ToString() ??
            MemoryStoreArchived?.ToString() ??
            MemoryStoreDeleted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && IsMemoryStoreCreated && !IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && IsMemoryStoreArchived && !IsMemoryStoreDeleted || !IsSessionCreated && !IsSessionPending && !IsSessionRunning && !IsSessionIdled && !IsSessionRequiresAction && !IsSessionArchived && !IsSessionDeleted && !IsSessionStatusRescheduled && !IsSessionStatusRunStarted && !IsSessionStatusIdled && !IsSessionStatusTerminated && !IsSessionThreadCreated && !IsSessionThreadIdled && !IsSessionThreadTerminated && !IsSessionOutcomeEvaluationEnded && !IsVaultCreated && !IsVaultArchived && !IsVaultDeleted && !IsVaultCredentialCreated && !IsVaultCredentialArchived && !IsVaultCredentialDeleted && !IsVaultCredentialRefreshFailed && !IsSessionUpdated && !IsAgentCreated && !IsAgentArchived && !IsAgentDeleted && !IsDeploymentPaused && !IsDeploymentRunFailed && !IsDeploymentCreated && !IsDeploymentUpdated && !IsDeploymentUnpaused && !IsAgentUpdated && !IsDeploymentArchived && !IsDeploymentRunStarted && !IsDeploymentDeleted && !IsDeploymentRunSucceeded && !IsEnvironmentCreated && !IsEnvironmentUpdated && !IsEnvironmentArchived && !IsEnvironmentDeleted && !IsMemoryStoreCreated && !IsMemoryStoreArchived && IsMemoryStoreDeleted;
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
            global::System.Func<global::Anthropic.BetaWebhookSessionUpdatedEventData, TResult>? sessionUpdated = null,
            global::System.Func<global::Anthropic.BetaWebhookAgentCreatedEventData, TResult>? agentCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookAgentArchivedEventData, TResult>? agentArchived = null,
            global::System.Func<global::Anthropic.BetaWebhookAgentDeletedEventData, TResult>? agentDeleted = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentPausedEventData, TResult>? deploymentPaused = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentRunFailedEventData, TResult>? deploymentRunFailed = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentCreatedEventData, TResult>? deploymentCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentUpdatedEventData, TResult>? deploymentUpdated = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentUnpausedEventData, TResult>? deploymentUnpaused = null,
            global::System.Func<global::Anthropic.BetaWebhookAgentUpdatedEventData, TResult>? agentUpdated = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentArchivedEventData, TResult>? deploymentArchived = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentRunStartedEventData, TResult>? deploymentRunStarted = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentDeletedEventData, TResult>? deploymentDeleted = null,
            global::System.Func<global::Anthropic.BetaWebhookDeploymentRunSucceededEventData, TResult>? deploymentRunSucceeded = null,
            global::System.Func<global::Anthropic.BetaWebhookEnvironmentCreatedEventData, TResult>? environmentCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookEnvironmentUpdatedEventData, TResult>? environmentUpdated = null,
            global::System.Func<global::Anthropic.BetaWebhookEnvironmentArchivedEventData, TResult>? environmentArchived = null,
            global::System.Func<global::Anthropic.BetaWebhookEnvironmentDeletedEventData, TResult>? environmentDeleted = null,
            global::System.Func<global::Anthropic.BetaWebhookMemoryStoreCreatedEventData, TResult>? memoryStoreCreated = null,
            global::System.Func<global::Anthropic.BetaWebhookMemoryStoreArchivedEventData, TResult>? memoryStoreArchived = null,
            global::System.Func<global::Anthropic.BetaWebhookMemoryStoreDeletedEventData, TResult>? memoryStoreDeleted = null,
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
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsAgentCreated && agentCreated != null)
            {
                return agentCreated(AgentCreated!);
            }
            else if (IsAgentArchived && agentArchived != null)
            {
                return agentArchived(AgentArchived!);
            }
            else if (IsAgentDeleted && agentDeleted != null)
            {
                return agentDeleted(AgentDeleted!);
            }
            else if (IsDeploymentPaused && deploymentPaused != null)
            {
                return deploymentPaused(DeploymentPaused!);
            }
            else if (IsDeploymentRunFailed && deploymentRunFailed != null)
            {
                return deploymentRunFailed(DeploymentRunFailed!);
            }
            else if (IsDeploymentCreated && deploymentCreated != null)
            {
                return deploymentCreated(DeploymentCreated!);
            }
            else if (IsDeploymentUpdated && deploymentUpdated != null)
            {
                return deploymentUpdated(DeploymentUpdated!);
            }
            else if (IsDeploymentUnpaused && deploymentUnpaused != null)
            {
                return deploymentUnpaused(DeploymentUnpaused!);
            }
            else if (IsAgentUpdated && agentUpdated != null)
            {
                return agentUpdated(AgentUpdated!);
            }
            else if (IsDeploymentArchived && deploymentArchived != null)
            {
                return deploymentArchived(DeploymentArchived!);
            }
            else if (IsDeploymentRunStarted && deploymentRunStarted != null)
            {
                return deploymentRunStarted(DeploymentRunStarted!);
            }
            else if (IsDeploymentDeleted && deploymentDeleted != null)
            {
                return deploymentDeleted(DeploymentDeleted!);
            }
            else if (IsDeploymentRunSucceeded && deploymentRunSucceeded != null)
            {
                return deploymentRunSucceeded(DeploymentRunSucceeded!);
            }
            else if (IsEnvironmentCreated && environmentCreated != null)
            {
                return environmentCreated(EnvironmentCreated!);
            }
            else if (IsEnvironmentUpdated && environmentUpdated != null)
            {
                return environmentUpdated(EnvironmentUpdated!);
            }
            else if (IsEnvironmentArchived && environmentArchived != null)
            {
                return environmentArchived(EnvironmentArchived!);
            }
            else if (IsEnvironmentDeleted && environmentDeleted != null)
            {
                return environmentDeleted(EnvironmentDeleted!);
            }
            else if (IsMemoryStoreCreated && memoryStoreCreated != null)
            {
                return memoryStoreCreated(MemoryStoreCreated!);
            }
            else if (IsMemoryStoreArchived && memoryStoreArchived != null)
            {
                return memoryStoreArchived(MemoryStoreArchived!);
            }
            else if (IsMemoryStoreDeleted && memoryStoreDeleted != null)
            {
                return memoryStoreDeleted(MemoryStoreDeleted!);
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

            global::System.Action<global::Anthropic.BetaWebhookSessionUpdatedEventData>? sessionUpdated = null,

            global::System.Action<global::Anthropic.BetaWebhookAgentCreatedEventData>? agentCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookAgentArchivedEventData>? agentArchived = null,

            global::System.Action<global::Anthropic.BetaWebhookAgentDeletedEventData>? agentDeleted = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentPausedEventData>? deploymentPaused = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentRunFailedEventData>? deploymentRunFailed = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentCreatedEventData>? deploymentCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentUpdatedEventData>? deploymentUpdated = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentUnpausedEventData>? deploymentUnpaused = null,

            global::System.Action<global::Anthropic.BetaWebhookAgentUpdatedEventData>? agentUpdated = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentArchivedEventData>? deploymentArchived = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentRunStartedEventData>? deploymentRunStarted = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentDeletedEventData>? deploymentDeleted = null,

            global::System.Action<global::Anthropic.BetaWebhookDeploymentRunSucceededEventData>? deploymentRunSucceeded = null,

            global::System.Action<global::Anthropic.BetaWebhookEnvironmentCreatedEventData>? environmentCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookEnvironmentUpdatedEventData>? environmentUpdated = null,

            global::System.Action<global::Anthropic.BetaWebhookEnvironmentArchivedEventData>? environmentArchived = null,

            global::System.Action<global::Anthropic.BetaWebhookEnvironmentDeletedEventData>? environmentDeleted = null,

            global::System.Action<global::Anthropic.BetaWebhookMemoryStoreCreatedEventData>? memoryStoreCreated = null,

            global::System.Action<global::Anthropic.BetaWebhookMemoryStoreArchivedEventData>? memoryStoreArchived = null,

            global::System.Action<global::Anthropic.BetaWebhookMemoryStoreDeletedEventData>? memoryStoreDeleted = null,
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
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsAgentCreated)
            {
                agentCreated?.Invoke(AgentCreated!);
            }
            else if (IsAgentArchived)
            {
                agentArchived?.Invoke(AgentArchived!);
            }
            else if (IsAgentDeleted)
            {
                agentDeleted?.Invoke(AgentDeleted!);
            }
            else if (IsDeploymentPaused)
            {
                deploymentPaused?.Invoke(DeploymentPaused!);
            }
            else if (IsDeploymentRunFailed)
            {
                deploymentRunFailed?.Invoke(DeploymentRunFailed!);
            }
            else if (IsDeploymentCreated)
            {
                deploymentCreated?.Invoke(DeploymentCreated!);
            }
            else if (IsDeploymentUpdated)
            {
                deploymentUpdated?.Invoke(DeploymentUpdated!);
            }
            else if (IsDeploymentUnpaused)
            {
                deploymentUnpaused?.Invoke(DeploymentUnpaused!);
            }
            else if (IsAgentUpdated)
            {
                agentUpdated?.Invoke(AgentUpdated!);
            }
            else if (IsDeploymentArchived)
            {
                deploymentArchived?.Invoke(DeploymentArchived!);
            }
            else if (IsDeploymentRunStarted)
            {
                deploymentRunStarted?.Invoke(DeploymentRunStarted!);
            }
            else if (IsDeploymentDeleted)
            {
                deploymentDeleted?.Invoke(DeploymentDeleted!);
            }
            else if (IsDeploymentRunSucceeded)
            {
                deploymentRunSucceeded?.Invoke(DeploymentRunSucceeded!);
            }
            else if (IsEnvironmentCreated)
            {
                environmentCreated?.Invoke(EnvironmentCreated!);
            }
            else if (IsEnvironmentUpdated)
            {
                environmentUpdated?.Invoke(EnvironmentUpdated!);
            }
            else if (IsEnvironmentArchived)
            {
                environmentArchived?.Invoke(EnvironmentArchived!);
            }
            else if (IsEnvironmentDeleted)
            {
                environmentDeleted?.Invoke(EnvironmentDeleted!);
            }
            else if (IsMemoryStoreCreated)
            {
                memoryStoreCreated?.Invoke(MemoryStoreCreated!);
            }
            else if (IsMemoryStoreArchived)
            {
                memoryStoreArchived?.Invoke(MemoryStoreArchived!);
            }
            else if (IsMemoryStoreDeleted)
            {
                memoryStoreDeleted?.Invoke(MemoryStoreDeleted!);
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
            global::System.Action<global::Anthropic.BetaWebhookSessionUpdatedEventData>? sessionUpdated = null,
            global::System.Action<global::Anthropic.BetaWebhookAgentCreatedEventData>? agentCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookAgentArchivedEventData>? agentArchived = null,
            global::System.Action<global::Anthropic.BetaWebhookAgentDeletedEventData>? agentDeleted = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentPausedEventData>? deploymentPaused = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentRunFailedEventData>? deploymentRunFailed = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentCreatedEventData>? deploymentCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentUpdatedEventData>? deploymentUpdated = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentUnpausedEventData>? deploymentUnpaused = null,
            global::System.Action<global::Anthropic.BetaWebhookAgentUpdatedEventData>? agentUpdated = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentArchivedEventData>? deploymentArchived = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentRunStartedEventData>? deploymentRunStarted = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentDeletedEventData>? deploymentDeleted = null,
            global::System.Action<global::Anthropic.BetaWebhookDeploymentRunSucceededEventData>? deploymentRunSucceeded = null,
            global::System.Action<global::Anthropic.BetaWebhookEnvironmentCreatedEventData>? environmentCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookEnvironmentUpdatedEventData>? environmentUpdated = null,
            global::System.Action<global::Anthropic.BetaWebhookEnvironmentArchivedEventData>? environmentArchived = null,
            global::System.Action<global::Anthropic.BetaWebhookEnvironmentDeletedEventData>? environmentDeleted = null,
            global::System.Action<global::Anthropic.BetaWebhookMemoryStoreCreatedEventData>? memoryStoreCreated = null,
            global::System.Action<global::Anthropic.BetaWebhookMemoryStoreArchivedEventData>? memoryStoreArchived = null,
            global::System.Action<global::Anthropic.BetaWebhookMemoryStoreDeletedEventData>? memoryStoreDeleted = null,
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
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsAgentCreated)
            {
                agentCreated?.Invoke(AgentCreated!);
            }
            else if (IsAgentArchived)
            {
                agentArchived?.Invoke(AgentArchived!);
            }
            else if (IsAgentDeleted)
            {
                agentDeleted?.Invoke(AgentDeleted!);
            }
            else if (IsDeploymentPaused)
            {
                deploymentPaused?.Invoke(DeploymentPaused!);
            }
            else if (IsDeploymentRunFailed)
            {
                deploymentRunFailed?.Invoke(DeploymentRunFailed!);
            }
            else if (IsDeploymentCreated)
            {
                deploymentCreated?.Invoke(DeploymentCreated!);
            }
            else if (IsDeploymentUpdated)
            {
                deploymentUpdated?.Invoke(DeploymentUpdated!);
            }
            else if (IsDeploymentUnpaused)
            {
                deploymentUnpaused?.Invoke(DeploymentUnpaused!);
            }
            else if (IsAgentUpdated)
            {
                agentUpdated?.Invoke(AgentUpdated!);
            }
            else if (IsDeploymentArchived)
            {
                deploymentArchived?.Invoke(DeploymentArchived!);
            }
            else if (IsDeploymentRunStarted)
            {
                deploymentRunStarted?.Invoke(DeploymentRunStarted!);
            }
            else if (IsDeploymentDeleted)
            {
                deploymentDeleted?.Invoke(DeploymentDeleted!);
            }
            else if (IsDeploymentRunSucceeded)
            {
                deploymentRunSucceeded?.Invoke(DeploymentRunSucceeded!);
            }
            else if (IsEnvironmentCreated)
            {
                environmentCreated?.Invoke(EnvironmentCreated!);
            }
            else if (IsEnvironmentUpdated)
            {
                environmentUpdated?.Invoke(EnvironmentUpdated!);
            }
            else if (IsEnvironmentArchived)
            {
                environmentArchived?.Invoke(EnvironmentArchived!);
            }
            else if (IsEnvironmentDeleted)
            {
                environmentDeleted?.Invoke(EnvironmentDeleted!);
            }
            else if (IsMemoryStoreCreated)
            {
                memoryStoreCreated?.Invoke(MemoryStoreCreated!);
            }
            else if (IsMemoryStoreArchived)
            {
                memoryStoreArchived?.Invoke(MemoryStoreArchived!);
            }
            else if (IsMemoryStoreDeleted)
            {
                memoryStoreDeleted?.Invoke(MemoryStoreDeleted!);
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
                SessionUpdated,
                typeof(global::Anthropic.BetaWebhookSessionUpdatedEventData),
                AgentCreated,
                typeof(global::Anthropic.BetaWebhookAgentCreatedEventData),
                AgentArchived,
                typeof(global::Anthropic.BetaWebhookAgentArchivedEventData),
                AgentDeleted,
                typeof(global::Anthropic.BetaWebhookAgentDeletedEventData),
                DeploymentPaused,
                typeof(global::Anthropic.BetaWebhookDeploymentPausedEventData),
                DeploymentRunFailed,
                typeof(global::Anthropic.BetaWebhookDeploymentRunFailedEventData),
                DeploymentCreated,
                typeof(global::Anthropic.BetaWebhookDeploymentCreatedEventData),
                DeploymentUpdated,
                typeof(global::Anthropic.BetaWebhookDeploymentUpdatedEventData),
                DeploymentUnpaused,
                typeof(global::Anthropic.BetaWebhookDeploymentUnpausedEventData),
                AgentUpdated,
                typeof(global::Anthropic.BetaWebhookAgentUpdatedEventData),
                DeploymentArchived,
                typeof(global::Anthropic.BetaWebhookDeploymentArchivedEventData),
                DeploymentRunStarted,
                typeof(global::Anthropic.BetaWebhookDeploymentRunStartedEventData),
                DeploymentDeleted,
                typeof(global::Anthropic.BetaWebhookDeploymentDeletedEventData),
                DeploymentRunSucceeded,
                typeof(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData),
                EnvironmentCreated,
                typeof(global::Anthropic.BetaWebhookEnvironmentCreatedEventData),
                EnvironmentUpdated,
                typeof(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData),
                EnvironmentArchived,
                typeof(global::Anthropic.BetaWebhookEnvironmentArchivedEventData),
                EnvironmentDeleted,
                typeof(global::Anthropic.BetaWebhookEnvironmentDeletedEventData),
                MemoryStoreCreated,
                typeof(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData),
                MemoryStoreArchived,
                typeof(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData),
                MemoryStoreDeleted,
                typeof(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData?>.Default.Equals(VaultCredentialRefreshFailed, other.VaultCredentialRefreshFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookSessionUpdatedEventData?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookAgentCreatedEventData?>.Default.Equals(AgentCreated, other.AgentCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookAgentArchivedEventData?>.Default.Equals(AgentArchived, other.AgentArchived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookAgentDeletedEventData?>.Default.Equals(AgentDeleted, other.AgentDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentPausedEventData?>.Default.Equals(DeploymentPaused, other.DeploymentPaused) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentRunFailedEventData?>.Default.Equals(DeploymentRunFailed, other.DeploymentRunFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentCreatedEventData?>.Default.Equals(DeploymentCreated, other.DeploymentCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentUpdatedEventData?>.Default.Equals(DeploymentUpdated, other.DeploymentUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentUnpausedEventData?>.Default.Equals(DeploymentUnpaused, other.DeploymentUnpaused) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookAgentUpdatedEventData?>.Default.Equals(AgentUpdated, other.AgentUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentArchivedEventData?>.Default.Equals(DeploymentArchived, other.DeploymentArchived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentRunStartedEventData?>.Default.Equals(DeploymentRunStarted, other.DeploymentRunStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentDeletedEventData?>.Default.Equals(DeploymentDeleted, other.DeploymentDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookDeploymentRunSucceededEventData?>.Default.Equals(DeploymentRunSucceeded, other.DeploymentRunSucceeded) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookEnvironmentCreatedEventData?>.Default.Equals(EnvironmentCreated, other.EnvironmentCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookEnvironmentUpdatedEventData?>.Default.Equals(EnvironmentUpdated, other.EnvironmentUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookEnvironmentArchivedEventData?>.Default.Equals(EnvironmentArchived, other.EnvironmentArchived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookEnvironmentDeletedEventData?>.Default.Equals(EnvironmentDeleted, other.EnvironmentDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookMemoryStoreCreatedEventData?>.Default.Equals(MemoryStoreCreated, other.MemoryStoreCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookMemoryStoreArchivedEventData?>.Default.Equals(MemoryStoreArchived, other.MemoryStoreArchived) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebhookMemoryStoreDeletedEventData?>.Default.Equals(MemoryStoreDeleted, other.MemoryStoreDeleted) 
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
