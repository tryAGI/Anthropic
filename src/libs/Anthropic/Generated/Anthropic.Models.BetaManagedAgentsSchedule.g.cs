#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A recurring schedule with computed runtime timestamps. Discriminated union — only cron is supported currently.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSchedule : global::System.IEquatable<BetaManagedAgentsSchedule>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleDiscriminatorType? Type { get; }

        /// <summary>
        /// 5-field POSIX cron schedule with computed runtime timestamps.<br/>
        /// Example: {"type":"cron","expression":"0 9 * * 1-5","timezone":"America/Los_Angeles","last_run_at":"2026-03-16T16:00:09Z","upcoming_runs_at":["2026-03-17T16:00:00Z","2026-03-18T16:00:00Z"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCronSchedule? Cron { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCronSchedule? Cron { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cron))]
#endif
        public bool IsCron => Cron != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCron(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsCronSchedule? value)
        {
            value = Cron;
            return IsCron;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronSchedule PickCron() => IsCron
            ? Cron!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cron' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSchedule(global::Anthropic.BetaManagedAgentsCronSchedule value) => new BetaManagedAgentsSchedule((global::Anthropic.BetaManagedAgentsCronSchedule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCronSchedule?(BetaManagedAgentsSchedule @this) => @this.Cron;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSchedule(global::Anthropic.BetaManagedAgentsCronSchedule? value)
        {
            Cron = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSchedule FromCron(global::Anthropic.BetaManagedAgentsCronSchedule? value) => new BetaManagedAgentsSchedule(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSchedule(
            global::Anthropic.BetaManagedAgentsScheduleDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsCronSchedule? cron
            )
        {
            Type = type;

            Cron = cron;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Cron as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Cron?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCron;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsCronSchedule, TResult>? cron = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCron && cron != null)
            {
                return cron(Cron!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsCronSchedule>? cron = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCron)
            {
                cron?.Invoke(Cron!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsCronSchedule>? cron = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCron)
            {
                cron?.Invoke(Cron!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Cron,
                typeof(global::Anthropic.BetaManagedAgentsCronSchedule),
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
        public bool Equals(BetaManagedAgentsSchedule other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCronSchedule?>.Default.Equals(Cron, other.Cron) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSchedule obj1, BetaManagedAgentsSchedule obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSchedule>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSchedule obj1, BetaManagedAgentsSchedule obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSchedule o && Equals(o);
        }
    }
}
