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
        public global::Anthropic.BetaManagedAgentsEffortLevel PickLevel() => Level is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Level' but the value was {ToString()}.");

        /// <summary>
        /// How hard Claude works on each turn. Sets `output_config.effort` on every Messages call the session makes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>? BetaManagedAgentsEffortParamsVariant2 { get; init; }
#else
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>? BetaManagedAgentsEffortParamsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsEffortParamsVariant2))]
#endif
        public bool IsBetaManagedAgentsEffortParamsVariant2 => BetaManagedAgentsEffortParamsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsEffortParamsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>? value)
        {
            value = BetaManagedAgentsEffortParamsVariant2;
            return IsBetaManagedAgentsEffortParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax> PickBetaManagedAgentsEffortParamsVariant2() => BetaManagedAgentsEffortParamsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsEffortParamsVariant2' but the value was {ToString()}.");
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
        public static implicit operator BetaManagedAgentsEffortParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax> value) => new BetaManagedAgentsEffortParams((global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>?(BetaManagedAgentsEffortParams @this) => @this.BetaManagedAgentsEffortParamsVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsEffortParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>? value)
        {
            BetaManagedAgentsEffortParamsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsEffortParams FromBetaManagedAgentsEffortParamsVariant2(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>? value) => new BetaManagedAgentsEffortParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsEffortParams(
            global::Anthropic.BetaManagedAgentsEffortLevel? level,
            global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>? betaManagedAgentsEffortParamsVariant2
            )
        {
            Level = level;
            BetaManagedAgentsEffortParamsVariant2 = betaManagedAgentsEffortParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaManagedAgentsEffortParamsVariant2 as object ??
            Level as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Level?.ToValueString() ??
            BetaManagedAgentsEffortParamsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLevel && !IsBetaManagedAgentsEffortParamsVariant2 || !IsLevel && IsBetaManagedAgentsEffortParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsEffortLevel?, TResult>? level = null,
            global::System.Func<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>?, TResult>? betaManagedAgentsEffortParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Level is { } __value0 && level != null)
            {
                return level(__value0);
            }
            else if (BetaManagedAgentsEffortParamsVariant2 is { } __value1 && betaManagedAgentsEffortParamsVariant2 != null)
            {
                return betaManagedAgentsEffortParamsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortLevel?>? level = null,

            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>?>? betaManagedAgentsEffortParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Level is { } __value0)
            {
                level?.Invoke(__value0);
            }
            else if (BetaManagedAgentsEffortParamsVariant2 is { } __value1)
            {
                betaManagedAgentsEffortParamsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortLevel?>? level = null,
            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>?>? betaManagedAgentsEffortParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Level is { } __value0)
            {
                level?.Invoke(__value0);
            }
            else if (BetaManagedAgentsEffortParamsVariant2 is { } __value1)
            {
                betaManagedAgentsEffortParamsVariant2?.Invoke(__value1);
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
                BetaManagedAgentsEffortParamsVariant2,
                typeof(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>?>.Default.Equals(BetaManagedAgentsEffortParamsVariant2, other.BetaManagedAgentsEffortParamsVariant2)
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
