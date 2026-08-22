#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionStatusIdleEventStopReason : global::System.IEquatable<BetaManagedAgentsSessionStatusIdleEventStopReason>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? Type { get; }

        /// <summary>
        /// The agent completed its turn naturally and is ready for the next user message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionEndTurn? EndTurn { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionEndTurn? EndTurn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndTurn))]
#endif
        public bool IsEndTurn => EndTurn != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEndTurn(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionEndTurn? value)
        {
            value = EndTurn;
            return IsEndTurn;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionEndTurn PickEndTurn() => IsEndTurn
            ? EndTurn!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndTurn' but the value was {ToString()}.");

        /// <summary>
        /// The agent is idle waiting on one or more blocking user-input events (tool confirmation, custom tool result, etc.). Resolving all of them transitions the session back to running.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction? RequiresAction { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction? RequiresAction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiresAction))]
#endif
        public bool IsRequiresAction => RequiresAction != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRequiresAction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionRequiresAction? value)
        {
            value = RequiresAction;
            return IsRequiresAction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRequiresAction PickRequiresAction() => IsRequiresAction
            ? RequiresAction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiresAction' but the value was {ToString()}.");

        /// <summary>
        /// The turn ended because repeated errors exhausted the retry budget or an error escalated to `retry_status: 'exhausted'`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? RetriesExhausted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? RetriesExhausted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetriesExhausted))]
#endif
        public bool IsRetriesExhausted => RetriesExhausted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRetriesExhausted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? value)
        {
            value = RetriesExhausted;
            return IsRetriesExhausted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionRetriesExhausted PickRetriesExhausted() => IsRetriesExhausted
            ? RetriesExhausted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetriesExhausted' but the value was {ToString()}.");

        /// <summary>
        /// The agent stopped because the session's tracked list cost reached its budget, or because its usage includes a model with no list price (which the budget cannot measure). Raise the budget to continue — or, if raising is rejected because a model has no list price, remove the budget.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached? BudgetReached { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached? BudgetReached { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BudgetReached))]
#endif
        public bool IsBudgetReached => BudgetReached != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBudgetReached(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsSessionBudgetReached? value)
        {
            value = BudgetReached;
            return IsBudgetReached;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionBudgetReached PickBudgetReached() => IsBudgetReached
            ? BudgetReached!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BudgetReached' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionEndTurn value) => new BetaManagedAgentsSessionStatusIdleEventStopReason((global::Anthropic.BetaManagedAgentsSessionEndTurn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionEndTurn?(BetaManagedAgentsSessionStatusIdleEventStopReason @this) => @this.EndTurn;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionEndTurn? value)
        {
            EndTurn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionStatusIdleEventStopReason FromEndTurn(global::Anthropic.BetaManagedAgentsSessionEndTurn? value) => new BetaManagedAgentsSessionStatusIdleEventStopReason(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRequiresAction value) => new BetaManagedAgentsSessionStatusIdleEventStopReason((global::Anthropic.BetaManagedAgentsSessionRequiresAction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionRequiresAction?(BetaManagedAgentsSessionStatusIdleEventStopReason @this) => @this.RequiresAction;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRequiresAction? value)
        {
            RequiresAction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionStatusIdleEventStopReason FromRequiresAction(global::Anthropic.BetaManagedAgentsSessionRequiresAction? value) => new BetaManagedAgentsSessionStatusIdleEventStopReason(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted value) => new BetaManagedAgentsSessionStatusIdleEventStopReason((global::Anthropic.BetaManagedAgentsSessionRetriesExhausted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionRetriesExhausted?(BetaManagedAgentsSessionStatusIdleEventStopReason @this) => @this.RetriesExhausted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? value)
        {
            RetriesExhausted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionStatusIdleEventStopReason FromRetriesExhausted(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? value) => new BetaManagedAgentsSessionStatusIdleEventStopReason(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionBudgetReached value) => new BetaManagedAgentsSessionStatusIdleEventStopReason((global::Anthropic.BetaManagedAgentsSessionBudgetReached?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionBudgetReached?(BetaManagedAgentsSessionStatusIdleEventStopReason @this) => @this.BudgetReached;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionBudgetReached? value)
        {
            BudgetReached = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionStatusIdleEventStopReason FromBudgetReached(global::Anthropic.BetaManagedAgentsSessionBudgetReached? value) => new BetaManagedAgentsSessionStatusIdleEventStopReason(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionStatusIdleEventStopReason(
            global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReasonDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsSessionEndTurn? endTurn,
            global::Anthropic.BetaManagedAgentsSessionRequiresAction? requiresAction,
            global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? retriesExhausted,
            global::Anthropic.BetaManagedAgentsSessionBudgetReached? budgetReached
            )
        {
            Type = type;

            EndTurn = endTurn;
            RequiresAction = requiresAction;
            RetriesExhausted = retriesExhausted;
            BudgetReached = budgetReached;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BudgetReached as object ??
            RetriesExhausted as object ??
            RequiresAction as object ??
            EndTurn as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EndTurn?.ToString() ??
            RequiresAction?.ToString() ??
            RetriesExhausted?.ToString() ??
            BudgetReached?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndTurn && !IsRequiresAction && !IsRetriesExhausted && !IsBudgetReached || !IsEndTurn && IsRequiresAction && !IsRetriesExhausted && !IsBudgetReached || !IsEndTurn && !IsRequiresAction && IsRetriesExhausted && !IsBudgetReached || !IsEndTurn && !IsRequiresAction && !IsRetriesExhausted && IsBudgetReached;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionEndTurn, TResult>? endTurn = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionRequiresAction, TResult>? requiresAction = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted, TResult>? retriesExhausted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionBudgetReached, TResult>? budgetReached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndTurn && endTurn != null)
            {
                return endTurn(EndTurn!);
            }
            else if (IsRequiresAction && requiresAction != null)
            {
                return requiresAction(RequiresAction!);
            }
            else if (IsRetriesExhausted && retriesExhausted != null)
            {
                return retriesExhausted(RetriesExhausted!);
            }
            else if (IsBudgetReached && budgetReached != null)
            {
                return budgetReached(BudgetReached!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionEndTurn>? endTurn = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRequiresAction>? requiresAction = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted>? retriesExhausted = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionBudgetReached>? budgetReached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndTurn)
            {
                endTurn?.Invoke(EndTurn!);
            }
            else if (IsRequiresAction)
            {
                requiresAction?.Invoke(RequiresAction!);
            }
            else if (IsRetriesExhausted)
            {
                retriesExhausted?.Invoke(RetriesExhausted!);
            }
            else if (IsBudgetReached)
            {
                budgetReached?.Invoke(BudgetReached!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionEndTurn>? endTurn = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRequiresAction>? requiresAction = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted>? retriesExhausted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionBudgetReached>? budgetReached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEndTurn)
            {
                endTurn?.Invoke(EndTurn!);
            }
            else if (IsRequiresAction)
            {
                requiresAction?.Invoke(RequiresAction!);
            }
            else if (IsRetriesExhausted)
            {
                retriesExhausted?.Invoke(RetriesExhausted!);
            }
            else if (IsBudgetReached)
            {
                budgetReached?.Invoke(BudgetReached!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EndTurn,
                typeof(global::Anthropic.BetaManagedAgentsSessionEndTurn),
                RequiresAction,
                typeof(global::Anthropic.BetaManagedAgentsSessionRequiresAction),
                RetriesExhausted,
                typeof(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted),
                BudgetReached,
                typeof(global::Anthropic.BetaManagedAgentsSessionBudgetReached),
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
        public bool Equals(BetaManagedAgentsSessionStatusIdleEventStopReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionEndTurn?>.Default.Equals(EndTurn, other.EndTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionRequiresAction?>.Default.Equals(RequiresAction, other.RequiresAction) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted?>.Default.Equals(RetriesExhausted, other.RetriesExhausted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionBudgetReached?>.Default.Equals(BudgetReached, other.BudgetReached) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionStatusIdleEventStopReason obj1, BetaManagedAgentsSessionStatusIdleEventStopReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionStatusIdleEventStopReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionStatusIdleEventStopReason obj1, BetaManagedAgentsSessionStatusIdleEventStopReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionStatusIdleEventStopReason o && Equals(o);
        }
    }
}
