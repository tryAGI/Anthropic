#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsEffortParams : global::System.IEquatable<BetaManagedAgentsEffortParams>
    {
        /// <summary>
        /// How hard Claude works on each turn. Higher levels favor reasoning depth over latency. Not all models accept every level; invalid combinations are rejected at create time.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEffortLevel? Level { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEffortLevel? Level { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Level))]
#endif
        public bool IsLevel => Level != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLevel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEffortLevel? value)
        {
            value = Level;
            return IsLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLevel PickLevel() => IsLevel
            ? Level!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Level' but the value was {ToString()}.");

        /// <summary>
        /// How hard Claude works on each turn. Sets `output_config.effort` on every Messages call the session makes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEffort? BetaManagedAgentsEffort { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEffort? BetaManagedAgentsEffort { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsEffort))]
#endif
        public bool IsBetaManagedAgentsEffort => BetaManagedAgentsEffort != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaManagedAgentsEffort(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEffort? value)
        {
            value = BetaManagedAgentsEffort;
            return IsBetaManagedAgentsEffort;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffort PickBetaManagedAgentsEffort() => IsBetaManagedAgentsEffort
            ? BetaManagedAgentsEffort!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsEffort' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEffortParams(global::Anthropic.BetaManagedAgentsEffortLevel value) => new BetaManagedAgentsEffortParams((global::Anthropic.BetaManagedAgentsEffortLevel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEffortLevel?(BetaManagedAgentsEffortParams @this) => @this.Level;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffortParams(global::Anthropic.BetaManagedAgentsEffortLevel? value)
        {
            Level = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEffortParams FromLevel(global::Anthropic.BetaManagedAgentsEffortLevel? value) => new BetaManagedAgentsEffortParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEffortParams(global::Anthropic.BetaManagedAgentsEffort value) => new BetaManagedAgentsEffortParams((global::Anthropic.BetaManagedAgentsEffort?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEffort?(BetaManagedAgentsEffortParams @this) => @this.BetaManagedAgentsEffort;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffortParams(global::Anthropic.BetaManagedAgentsEffort? value)
        {
            BetaManagedAgentsEffort = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEffortParams FromBetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffort? value) => new BetaManagedAgentsEffortParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffortParams(
            global::Anthropic.BetaManagedAgentsEffortLevel? level,
            global::Anthropic.BetaManagedAgentsEffort? betaManagedAgentsEffort
            )
        {
            Level = level;
            BetaManagedAgentsEffort = betaManagedAgentsEffort;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaManagedAgentsEffort as object ??
            Level as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Level?.ToValueString() ??
            BetaManagedAgentsEffort?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLevel && !IsBetaManagedAgentsEffort || !IsLevel && IsBetaManagedAgentsEffort;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsEffortLevel?, TResult>? level = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEffort?, TResult>? betaManagedAgentsEffort = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLevel && level != null)
            {
                return level(Level!);
            }
            else if (IsBetaManagedAgentsEffort && betaManagedAgentsEffort != null)
            {
                return betaManagedAgentsEffort(BetaManagedAgentsEffort!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortLevel?>? level = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEffort?>? betaManagedAgentsEffort = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLevel)
            {
                level?.Invoke(Level!);
            }
            else if (IsBetaManagedAgentsEffort)
            {
                betaManagedAgentsEffort?.Invoke(BetaManagedAgentsEffort!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortLevel?>? level = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEffort?>? betaManagedAgentsEffort = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLevel)
            {
                level?.Invoke(Level!);
            }
            else if (IsBetaManagedAgentsEffort)
            {
                betaManagedAgentsEffort?.Invoke(BetaManagedAgentsEffort!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Level,
                typeof(global::Anthropic.BetaManagedAgentsEffortLevel),
                BetaManagedAgentsEffort,
                typeof(global::Anthropic.BetaManagedAgentsEffort),
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
        public bool Equals(BetaManagedAgentsEffortParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEffortLevel?>.Default.Equals(Level, other.Level) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEffort?>.Default.Equals(BetaManagedAgentsEffort, other.BetaManagedAgentsEffort) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsEffortParams obj1, BetaManagedAgentsEffortParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsEffortParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsEffortParams obj1, BetaManagedAgentsEffortParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsEffortParams o && Equals(o);
        }
    }
}
