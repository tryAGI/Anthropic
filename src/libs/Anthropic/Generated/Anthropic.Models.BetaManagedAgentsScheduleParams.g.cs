#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A recurring schedule. Discriminated union — only cron is supported currently.
    /// </summary>
    public readonly partial struct BetaManagedAgentsScheduleParams : global::System.IEquatable<BetaManagedAgentsScheduleParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// 5-field POSIX cron schedule. Literal wall-clock matching in the configured timezone.<br/>
        /// Example: {"type":"cron","expression":"0 9 * * 1-5","timezone":"America/Los_Angeles"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCronScheduleParams? Cron { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCronScheduleParams? Cron { get; }
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
            out global::Anthropic.BetaManagedAgentsCronScheduleParams? value)
        {
            value = Cron;
            return IsCron;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCronScheduleParams PickCron() => IsCron
            ? Cron!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cron' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsScheduleParams(global::Anthropic.BetaManagedAgentsCronScheduleParams value) => new BetaManagedAgentsScheduleParams((global::Anthropic.BetaManagedAgentsCronScheduleParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCronScheduleParams?(BetaManagedAgentsScheduleParams @this) => @this.Cron;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsScheduleParams(global::Anthropic.BetaManagedAgentsCronScheduleParams? value)
        {
            Cron = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsScheduleParams FromCron(global::Anthropic.BetaManagedAgentsCronScheduleParams? value) => new BetaManagedAgentsScheduleParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsScheduleParams(
            global::Anthropic.BetaManagedAgentsScheduleParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsCronScheduleParams? cron
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
            global::System.Func<global::Anthropic.BetaManagedAgentsCronScheduleParams, TResult>? cron = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsCronScheduleParams>? cron = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsCronScheduleParams>? cron = null,
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
                typeof(global::Anthropic.BetaManagedAgentsCronScheduleParams),
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
        public bool Equals(BetaManagedAgentsScheduleParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCronScheduleParams?>.Default.Equals(Cron, other.Cron) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsScheduleParams obj1, BetaManagedAgentsScheduleParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsScheduleParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsScheduleParams obj1, BetaManagedAgentsScheduleParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsScheduleParams o && Equals(o);
        }
    }
}
