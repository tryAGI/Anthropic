#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How hard Claude works on each turn. Sets `output_config.effort` on every Messages call the session makes.
    /// </summary>
    public readonly partial struct BetaManagedAgentsEffort : global::System.IEquatable<BetaManagedAgentsEffort>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortDiscriminatorType? Type { get; }

        /// <summary>
        /// Low effort. Favors latency over reasoning depth.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEffortLow? Low { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEffortLow? Low { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Low))]
#endif
        public bool IsLow => Low != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEffortLow? value)
        {
            value = Low;
            return IsLow;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortLow PickLow() => IsLow
            ? Low!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Low' but the value was {ToString()}.");

        /// <summary>
        /// Medium effort. Balances latency and reasoning depth.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEffortMedium? Medium { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEffortMedium? Medium { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Medium))]
#endif
        public bool IsMedium => Medium != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMedium(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEffortMedium? value)
        {
            value = Medium;
            return IsMedium;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMedium PickMedium() => IsMedium
            ? Medium!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Medium' but the value was {ToString()}.");

        /// <summary>
        /// High effort. Favors reasoning depth.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEffortHigh? High { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEffortHigh? High { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(High))]
#endif
        public bool IsHigh => High != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHigh(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEffortHigh? value)
        {
            value = High;
            return IsHigh;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortHigh PickHigh() => IsHigh
            ? High!
            : throw new global::System.InvalidOperationException($"Expected union variant 'High' but the value was {ToString()}.");

        /// <summary>
        /// Extra-high effort. Not all models accept this level.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEffortXhigh? Xhigh { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEffortXhigh? Xhigh { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Xhigh))]
#endif
        public bool IsXhigh => Xhigh != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickXhigh(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEffortXhigh? value)
        {
            value = Xhigh;
            return IsXhigh;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortXhigh PickXhigh() => IsXhigh
            ? Xhigh!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xhigh' but the value was {ToString()}.");

        /// <summary>
        /// Maximum effort. Favors reasoning depth over latency.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEffortMax? Max { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEffortMax? Max { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Max))]
#endif
        public bool IsMax => Max != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMax(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEffortMax? value)
        {
            value = Max;
            return IsMax;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEffortMax PickMax() => IsMax
            ? Max!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Max' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortLow value) => new BetaManagedAgentsEffort((global::Anthropic.BetaManagedAgentsEffortLow?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEffortLow?(BetaManagedAgentsEffort @this) => @this.Low;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortLow? value)
        {
            Low = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEffort FromLow(global::Anthropic.BetaManagedAgentsEffortLow? value) => new BetaManagedAgentsEffort(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortMedium value) => new BetaManagedAgentsEffort((global::Anthropic.BetaManagedAgentsEffortMedium?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEffortMedium?(BetaManagedAgentsEffort @this) => @this.Medium;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortMedium? value)
        {
            Medium = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEffort FromMedium(global::Anthropic.BetaManagedAgentsEffortMedium? value) => new BetaManagedAgentsEffort(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortHigh value) => new BetaManagedAgentsEffort((global::Anthropic.BetaManagedAgentsEffortHigh?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEffortHigh?(BetaManagedAgentsEffort @this) => @this.High;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortHigh? value)
        {
            High = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEffort FromHigh(global::Anthropic.BetaManagedAgentsEffortHigh? value) => new BetaManagedAgentsEffort(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortXhigh value) => new BetaManagedAgentsEffort((global::Anthropic.BetaManagedAgentsEffortXhigh?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEffortXhigh?(BetaManagedAgentsEffort @this) => @this.Xhigh;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortXhigh? value)
        {
            Xhigh = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEffort FromXhigh(global::Anthropic.BetaManagedAgentsEffortXhigh? value) => new BetaManagedAgentsEffort(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortMax value) => new BetaManagedAgentsEffort((global::Anthropic.BetaManagedAgentsEffortMax?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEffortMax?(BetaManagedAgentsEffort @this) => @this.Max;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffort(global::Anthropic.BetaManagedAgentsEffortMax? value)
        {
            Max = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEffort FromMax(global::Anthropic.BetaManagedAgentsEffortMax? value) => new BetaManagedAgentsEffort(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEffort(
            global::Anthropic.BetaManagedAgentsEffortDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsEffortLow? low,
            global::Anthropic.BetaManagedAgentsEffortMedium? medium,
            global::Anthropic.BetaManagedAgentsEffortHigh? high,
            global::Anthropic.BetaManagedAgentsEffortXhigh? xhigh,
            global::Anthropic.BetaManagedAgentsEffortMax? max
            )
        {
            Type = type;

            Low = low;
            Medium = medium;
            High = high;
            Xhigh = xhigh;
            Max = max;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Max as object ??
            Xhigh as object ??
            High as object ??
            Medium as object ??
            Low as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Low?.ToString() ??
            Medium?.ToString() ??
            High?.ToString() ??
            Xhigh?.ToString() ??
            Max?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLow && !IsMedium && !IsHigh && !IsXhigh && !IsMax || !IsLow && IsMedium && !IsHigh && !IsXhigh && !IsMax || !IsLow && !IsMedium && IsHigh && !IsXhigh && !IsMax || !IsLow && !IsMedium && !IsHigh && IsXhigh && !IsMax || !IsLow && !IsMedium && !IsHigh && !IsXhigh && IsMax;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsEffortLow, TResult>? low = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEffortMedium, TResult>? medium = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEffortHigh, TResult>? high = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEffortXhigh, TResult>? xhigh = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEffortMax, TResult>? max = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLow && low != null)
            {
                return low(Low!);
            }
            else if (IsMedium && medium != null)
            {
                return medium(Medium!);
            }
            else if (IsHigh && high != null)
            {
                return high(High!);
            }
            else if (IsXhigh && xhigh != null)
            {
                return xhigh(Xhigh!);
            }
            else if (IsMax && max != null)
            {
                return max(Max!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortLow>? low = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEffortMedium>? medium = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEffortHigh>? high = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEffortXhigh>? xhigh = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEffortMax>? max = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLow)
            {
                low?.Invoke(Low!);
            }
            else if (IsMedium)
            {
                medium?.Invoke(Medium!);
            }
            else if (IsHigh)
            {
                high?.Invoke(High!);
            }
            else if (IsXhigh)
            {
                xhigh?.Invoke(Xhigh!);
            }
            else if (IsMax)
            {
                max?.Invoke(Max!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortLow>? low = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortMedium>? medium = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortHigh>? high = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortXhigh>? xhigh = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEffortMax>? max = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLow)
            {
                low?.Invoke(Low!);
            }
            else if (IsMedium)
            {
                medium?.Invoke(Medium!);
            }
            else if (IsHigh)
            {
                high?.Invoke(High!);
            }
            else if (IsXhigh)
            {
                xhigh?.Invoke(Xhigh!);
            }
            else if (IsMax)
            {
                max?.Invoke(Max!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Low,
                typeof(global::Anthropic.BetaManagedAgentsEffortLow),
                Medium,
                typeof(global::Anthropic.BetaManagedAgentsEffortMedium),
                High,
                typeof(global::Anthropic.BetaManagedAgentsEffortHigh),
                Xhigh,
                typeof(global::Anthropic.BetaManagedAgentsEffortXhigh),
                Max,
                typeof(global::Anthropic.BetaManagedAgentsEffortMax),
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
        public bool Equals(BetaManagedAgentsEffort other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEffortLow?>.Default.Equals(Low, other.Low) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEffortMedium?>.Default.Equals(Medium, other.Medium) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEffortHigh?>.Default.Equals(High, other.High) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEffortXhigh?>.Default.Equals(Xhigh, other.Xhigh) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEffortMax?>.Default.Equals(Max, other.Max) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsEffort obj1, BetaManagedAgentsEffort obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsEffort>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsEffort obj1, BetaManagedAgentsEffort obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsEffort o && Equals(o);
        }
    }
}
