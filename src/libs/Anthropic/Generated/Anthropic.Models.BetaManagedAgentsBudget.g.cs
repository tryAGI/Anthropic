#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An enforced spend ceiling on a session. Discriminated on `type`; `limit` is the only kind currently supported.
    /// </summary>
    public readonly partial struct BetaManagedAgentsBudget : global::System.IEquatable<BetaManagedAgentsBudget>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetDiscriminatorType? Type { get; }

        /// <summary>
        /// A hard spend ceiling. The session stops issuing new model requests once the tracked list cost reaches `max_list_cost`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsBudgetLimit? Limit { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsBudgetLimit? Limit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Limit))]
#endif
        public bool IsLimit => Limit != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLimit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsBudgetLimit? value)
        {
            value = Limit;
            return IsLimit;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBudgetLimit PickLimit() => IsLimit
            ? Limit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Limit' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsBudget(global::Anthropic.BetaManagedAgentsBudgetLimit value) => new BetaManagedAgentsBudget((global::Anthropic.BetaManagedAgentsBudgetLimit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsBudgetLimit?(BetaManagedAgentsBudget @this) => @this.Limit;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsBudget(global::Anthropic.BetaManagedAgentsBudgetLimit? value)
        {
            Limit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsBudget FromLimit(global::Anthropic.BetaManagedAgentsBudgetLimit? value) => new BetaManagedAgentsBudget(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsBudget(
            global::Anthropic.BetaManagedAgentsBudgetDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsBudgetLimit? limit
            )
        {
            Type = type;

            Limit = limit;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Limit as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Limit?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLimit;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsBudgetLimit, TResult>? limit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLimit && limit != null)
            {
                return limit(Limit!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsBudgetLimit>? limit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLimit)
            {
                limit?.Invoke(Limit!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsBudgetLimit>? limit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLimit)
            {
                limit?.Invoke(Limit!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Limit,
                typeof(global::Anthropic.BetaManagedAgentsBudgetLimit),
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
        public bool Equals(BetaManagedAgentsBudget other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBudgetLimit?>.Default.Equals(Limit, other.Limit) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsBudget obj1, BetaManagedAgentsBudget obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsBudget>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsBudget obj1, BetaManagedAgentsBudget obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsBudget o && Equals(o);
        }
    }
}
