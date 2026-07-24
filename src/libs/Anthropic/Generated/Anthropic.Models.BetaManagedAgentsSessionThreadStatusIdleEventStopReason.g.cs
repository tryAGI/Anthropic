#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionThreadStatusIdleEventStopReason : global::System.IEquatable<BetaManagedAgentsSessionThreadStatusIdleEventStopReason>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? Type { get; }

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
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionThreadStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionEndTurn value) => new BetaManagedAgentsSessionThreadStatusIdleEventStopReason((global::Anthropic.BetaManagedAgentsSessionEndTurn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionEndTurn?(BetaManagedAgentsSessionThreadStatusIdleEventStopReason @this) => @this.EndTurn;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionThreadStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionEndTurn? value)
        {
            EndTurn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusIdleEventStopReason FromEndTurn(global::Anthropic.BetaManagedAgentsSessionEndTurn? value) => new BetaManagedAgentsSessionThreadStatusIdleEventStopReason(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionThreadStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRequiresAction value) => new BetaManagedAgentsSessionThreadStatusIdleEventStopReason((global::Anthropic.BetaManagedAgentsSessionRequiresAction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionRequiresAction?(BetaManagedAgentsSessionThreadStatusIdleEventStopReason @this) => @this.RequiresAction;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionThreadStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRequiresAction? value)
        {
            RequiresAction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusIdleEventStopReason FromRequiresAction(global::Anthropic.BetaManagedAgentsSessionRequiresAction? value) => new BetaManagedAgentsSessionThreadStatusIdleEventStopReason(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionThreadStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted value) => new BetaManagedAgentsSessionThreadStatusIdleEventStopReason((global::Anthropic.BetaManagedAgentsSessionRetriesExhausted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionRetriesExhausted?(BetaManagedAgentsSessionThreadStatusIdleEventStopReason @this) => @this.RetriesExhausted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionThreadStatusIdleEventStopReason(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? value)
        {
            RetriesExhausted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionThreadStatusIdleEventStopReason FromRetriesExhausted(global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? value) => new BetaManagedAgentsSessionThreadStatusIdleEventStopReason(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionThreadStatusIdleEventStopReason(
            global::Anthropic.BetaManagedAgentsSessionThreadStatusIdleEventStopReasonDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsSessionEndTurn? endTurn,
            global::Anthropic.BetaManagedAgentsSessionRequiresAction? requiresAction,
            global::Anthropic.BetaManagedAgentsSessionRetriesExhausted? retriesExhausted
            )
        {
            Type = type;

            EndTurn = endTurn;
            RequiresAction = requiresAction;
            RetriesExhausted = retriesExhausted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            RetriesExhausted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEndTurn && !IsRequiresAction && !IsRetriesExhausted || !IsEndTurn && IsRequiresAction && !IsRetriesExhausted || !IsEndTurn && !IsRequiresAction && IsRetriesExhausted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionEndTurn, TResult>? endTurn = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionRequiresAction, TResult>? requiresAction = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted, TResult>? retriesExhausted = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionEndTurn>? endTurn = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRequiresAction>? requiresAction = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted>? retriesExhausted = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionEndTurn>? endTurn = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRequiresAction>? requiresAction = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted>? retriesExhausted = null,
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
        public bool Equals(BetaManagedAgentsSessionThreadStatusIdleEventStopReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionEndTurn?>.Default.Equals(EndTurn, other.EndTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionRequiresAction?>.Default.Equals(RequiresAction, other.RequiresAction) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionRetriesExhausted?>.Default.Equals(RetriesExhausted, other.RetriesExhausted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionThreadStatusIdleEventStopReason obj1, BetaManagedAgentsSessionThreadStatusIdleEventStopReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionThreadStatusIdleEventStopReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionThreadStatusIdleEventStopReason obj1, BetaManagedAgentsSessionThreadStatusIdleEventStopReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionThreadStatusIdleEventStopReason o && Equals(o);
        }
    }
}
