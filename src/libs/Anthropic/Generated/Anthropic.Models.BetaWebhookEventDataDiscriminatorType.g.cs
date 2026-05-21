
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebhookEventDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionArchived,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionDeleted,
        /// <summary>
        /// 
        /// </summary>
        SessionIdled,
        /// <summary>
        /// 
        /// </summary>
        SessionOutcomeEvaluationEnded,
        /// <summary>
        /// 
        /// </summary>
        SessionPending,
        /// <summary>
        /// 
        /// </summary>
        SessionRequiresAction,
        /// <summary>
        /// 
        /// </summary>
        SessionRunning,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusIdled,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusRescheduled,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusRunStarted,
        /// <summary>
        /// 
        /// </summary>
        SessionStatusTerminated,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadIdled,
        /// <summary>
        /// 
        /// </summary>
        SessionThreadTerminated,
        /// <summary>
        /// 
        /// </summary>
        VaultArchived,
        /// <summary>
        /// 
        /// </summary>
        VaultCreated,
        /// <summary>
        /// 
        /// </summary>
        VaultDeleted,
        /// <summary>
        /// 
        /// </summary>
        VaultCredentialArchived,
        /// <summary>
        /// 
        /// </summary>
        VaultCredentialCreated,
        /// <summary>
        /// 
        /// </summary>
        VaultCredentialDeleted,
        /// <summary>
        /// 
        /// </summary>
        VaultCredentialRefreshFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebhookEventDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebhookEventDataDiscriminatorType value)
        {
            return value switch
            {
                BetaWebhookEventDataDiscriminatorType.SessionArchived => "session.archived",
                BetaWebhookEventDataDiscriminatorType.SessionCreated => "session.created",
                BetaWebhookEventDataDiscriminatorType.SessionDeleted => "session.deleted",
                BetaWebhookEventDataDiscriminatorType.SessionIdled => "session.idled",
                BetaWebhookEventDataDiscriminatorType.SessionOutcomeEvaluationEnded => "session.outcome_evaluation_ended",
                BetaWebhookEventDataDiscriminatorType.SessionPending => "session.pending",
                BetaWebhookEventDataDiscriminatorType.SessionRequiresAction => "session.requires_action",
                BetaWebhookEventDataDiscriminatorType.SessionRunning => "session.running",
                BetaWebhookEventDataDiscriminatorType.SessionStatusIdled => "session.status_idled",
                BetaWebhookEventDataDiscriminatorType.SessionStatusRescheduled => "session.status_rescheduled",
                BetaWebhookEventDataDiscriminatorType.SessionStatusRunStarted => "session.status_run_started",
                BetaWebhookEventDataDiscriminatorType.SessionStatusTerminated => "session.status_terminated",
                BetaWebhookEventDataDiscriminatorType.SessionThreadCreated => "session.thread_created",
                BetaWebhookEventDataDiscriminatorType.SessionThreadIdled => "session.thread_idled",
                BetaWebhookEventDataDiscriminatorType.SessionThreadTerminated => "session.thread_terminated",
                BetaWebhookEventDataDiscriminatorType.VaultArchived => "vault.archived",
                BetaWebhookEventDataDiscriminatorType.VaultCreated => "vault.created",
                BetaWebhookEventDataDiscriminatorType.VaultDeleted => "vault.deleted",
                BetaWebhookEventDataDiscriminatorType.VaultCredentialArchived => "vault_credential.archived",
                BetaWebhookEventDataDiscriminatorType.VaultCredentialCreated => "vault_credential.created",
                BetaWebhookEventDataDiscriminatorType.VaultCredentialDeleted => "vault_credential.deleted",
                BetaWebhookEventDataDiscriminatorType.VaultCredentialRefreshFailed => "vault_credential.refresh_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebhookEventDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "session.archived" => BetaWebhookEventDataDiscriminatorType.SessionArchived,
                "session.created" => BetaWebhookEventDataDiscriminatorType.SessionCreated,
                "session.deleted" => BetaWebhookEventDataDiscriminatorType.SessionDeleted,
                "session.idled" => BetaWebhookEventDataDiscriminatorType.SessionIdled,
                "session.outcome_evaluation_ended" => BetaWebhookEventDataDiscriminatorType.SessionOutcomeEvaluationEnded,
                "session.pending" => BetaWebhookEventDataDiscriminatorType.SessionPending,
                "session.requires_action" => BetaWebhookEventDataDiscriminatorType.SessionRequiresAction,
                "session.running" => BetaWebhookEventDataDiscriminatorType.SessionRunning,
                "session.status_idled" => BetaWebhookEventDataDiscriminatorType.SessionStatusIdled,
                "session.status_rescheduled" => BetaWebhookEventDataDiscriminatorType.SessionStatusRescheduled,
                "session.status_run_started" => BetaWebhookEventDataDiscriminatorType.SessionStatusRunStarted,
                "session.status_terminated" => BetaWebhookEventDataDiscriminatorType.SessionStatusTerminated,
                "session.thread_created" => BetaWebhookEventDataDiscriminatorType.SessionThreadCreated,
                "session.thread_idled" => BetaWebhookEventDataDiscriminatorType.SessionThreadIdled,
                "session.thread_terminated" => BetaWebhookEventDataDiscriminatorType.SessionThreadTerminated,
                "vault.archived" => BetaWebhookEventDataDiscriminatorType.VaultArchived,
                "vault.created" => BetaWebhookEventDataDiscriminatorType.VaultCreated,
                "vault.deleted" => BetaWebhookEventDataDiscriminatorType.VaultDeleted,
                "vault_credential.archived" => BetaWebhookEventDataDiscriminatorType.VaultCredentialArchived,
                "vault_credential.created" => BetaWebhookEventDataDiscriminatorType.VaultCredentialCreated,
                "vault_credential.deleted" => BetaWebhookEventDataDiscriminatorType.VaultCredentialDeleted,
                "vault_credential.refresh_failed" => BetaWebhookEventDataDiscriminatorType.VaultCredentialRefreshFailed,
                _ => null,
            };
        }
    }
}