#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Describes what triggered a deployment run, with trigger-specific metadata.
    /// </summary>
    public readonly partial struct BetaManagedAgentsTriggerContext : global::System.IEquatable<BetaManagedAgentsTriggerContext>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTriggerContextDiscriminatorType? Type { get; }

        /// <summary>
        /// The run was fired by the deployment's cron schedule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext? Schedule { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext? Schedule { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Schedule))]
#endif
        public bool IsSchedule => Schedule != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSchedule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsScheduleTriggerContext? value)
        {
            value = Schedule;
            return IsSchedule;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleTriggerContext PickSchedule() => IsSchedule
            ? Schedule!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Schedule' but the value was {ToString()}.");

        /// <summary>
        /// The run was started manually by creating a session directly against the deployment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsManualTriggerContext? Manual { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsManualTriggerContext? Manual { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Manual))]
#endif
        public bool IsManual => Manual != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickManual(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsManualTriggerContext? value)
        {
            value = Manual;
            return IsManual;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualTriggerContext PickManual() => IsManual
            ? Manual!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Manual' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsTriggerContext(global::Anthropic.BetaManagedAgentsScheduleTriggerContext value) => new BetaManagedAgentsTriggerContext((global::Anthropic.BetaManagedAgentsScheduleTriggerContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsScheduleTriggerContext?(BetaManagedAgentsTriggerContext @this) => @this.Schedule;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsTriggerContext(global::Anthropic.BetaManagedAgentsScheduleTriggerContext? value)
        {
            Schedule = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsTriggerContext FromSchedule(global::Anthropic.BetaManagedAgentsScheduleTriggerContext? value) => new BetaManagedAgentsTriggerContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsTriggerContext(global::Anthropic.BetaManagedAgentsManualTriggerContext value) => new BetaManagedAgentsTriggerContext((global::Anthropic.BetaManagedAgentsManualTriggerContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsManualTriggerContext?(BetaManagedAgentsTriggerContext @this) => @this.Manual;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsTriggerContext(global::Anthropic.BetaManagedAgentsManualTriggerContext? value)
        {
            Manual = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsTriggerContext FromManual(global::Anthropic.BetaManagedAgentsManualTriggerContext? value) => new BetaManagedAgentsTriggerContext(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsTriggerContext(
            global::Anthropic.BetaManagedAgentsTriggerContextDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsScheduleTriggerContext? schedule,
            global::Anthropic.BetaManagedAgentsManualTriggerContext? manual
            )
        {
            Type = type;

            Schedule = schedule;
            Manual = manual;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Manual as object ??
            Schedule as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Schedule?.ToString() ??
            Manual?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSchedule && !IsManual || !IsSchedule && IsManual;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsScheduleTriggerContext, TResult>? schedule = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsManualTriggerContext, TResult>? manual = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule && schedule != null)
            {
                return schedule(Schedule!);
            }
            else if (IsManual && manual != null)
            {
                return manual(Manual!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsScheduleTriggerContext>? schedule = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsManualTriggerContext>? manual = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule)
            {
                schedule?.Invoke(Schedule!);
            }
            else if (IsManual)
            {
                manual?.Invoke(Manual!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsScheduleTriggerContext>? schedule = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsManualTriggerContext>? manual = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchedule)
            {
                schedule?.Invoke(Schedule!);
            }
            else if (IsManual)
            {
                manual?.Invoke(Manual!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Schedule,
                typeof(global::Anthropic.BetaManagedAgentsScheduleTriggerContext),
                Manual,
                typeof(global::Anthropic.BetaManagedAgentsManualTriggerContext),
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
        public bool Equals(BetaManagedAgentsTriggerContext other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsScheduleTriggerContext?>.Default.Equals(Schedule, other.Schedule) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsManualTriggerContext?>.Default.Equals(Manual, other.Manual) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsTriggerContext obj1, BetaManagedAgentsTriggerContext obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsTriggerContext>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsTriggerContext obj1, BetaManagedAgentsTriggerContext obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsTriggerContext o && Equals(o);
        }
    }
}
