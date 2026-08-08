#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaDreamModelParams : global::System.IEquatable<BetaDreamModelParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaDreamModelParamsVariant1 { get; init; }
#else
        public string? BetaDreamModelParamsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaDreamModelParamsVariant1))]
#endif
        public bool IsBetaDreamModelParamsVariant1 => BetaDreamModelParamsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaDreamModelParamsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaDreamModelParamsVariant1;
            return IsBetaDreamModelParamsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickBetaDreamModelParamsVariant1() => IsBetaDreamModelParamsVariant1
            ? BetaDreamModelParamsVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaDreamModelParamsVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Model identifier and configuration applied to every pipeline stage.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaDreamModelConfigParams? Config { get; init; }
#else
        public global::Anthropic.BetaDreamModelConfigParams? Config { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaDreamModelConfigParams? value)
        {
            value = Config;
            return IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaDreamModelConfigParams PickConfig() => IsConfig
            ? Config!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Config' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaDreamModelParams(string value) => new BetaDreamModelParams((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BetaDreamModelParams @this) => @this.BetaDreamModelParamsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamModelParams(string? value)
        {
            BetaDreamModelParamsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaDreamModelParams FromBetaDreamModelParamsVariant1(string? value) => new BetaDreamModelParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaDreamModelParams(global::Anthropic.BetaDreamModelConfigParams value) => new BetaDreamModelParams((global::Anthropic.BetaDreamModelConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaDreamModelConfigParams?(BetaDreamModelParams @this) => @this.Config;

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamModelParams(global::Anthropic.BetaDreamModelConfigParams? value)
        {
            Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaDreamModelParams FromConfig(global::Anthropic.BetaDreamModelConfigParams? value) => new BetaDreamModelParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaDreamModelParams(
            string? betaDreamModelParamsVariant1,
            global::Anthropic.BetaDreamModelConfigParams? config
            )
        {
            BetaDreamModelParamsVariant1 = betaDreamModelParamsVariant1;
            Config = config;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Config as object ??
            BetaDreamModelParamsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BetaDreamModelParamsVariant1?.ToString() ??
            Config?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBetaDreamModelParamsVariant1 && !IsConfig || !IsBetaDreamModelParamsVariant1 && IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaDreamModelParamsVariant1 = null,
            global::System.Func<global::Anthropic.BetaDreamModelConfigParams, TResult>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaDreamModelParamsVariant1 && betaDreamModelParamsVariant1 != null)
            {
                return betaDreamModelParamsVariant1(BetaDreamModelParamsVariant1!);
            }
            else if (IsConfig && config != null)
            {
                return config(Config!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? betaDreamModelParamsVariant1 = null,

            global::System.Action<global::Anthropic.BetaDreamModelConfigParams>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaDreamModelParamsVariant1)
            {
                betaDreamModelParamsVariant1?.Invoke(BetaDreamModelParamsVariant1!);
            }
            else if (IsConfig)
            {
                config?.Invoke(Config!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaDreamModelParamsVariant1 = null,
            global::System.Action<global::Anthropic.BetaDreamModelConfigParams>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaDreamModelParamsVariant1)
            {
                betaDreamModelParamsVariant1?.Invoke(BetaDreamModelParamsVariant1!);
            }
            else if (IsConfig)
            {
                config?.Invoke(Config!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaDreamModelParamsVariant1,
                typeof(string),
                Config,
                typeof(global::Anthropic.BetaDreamModelConfigParams),
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
        public bool Equals(BetaDreamModelParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaDreamModelParamsVariant1, other.BetaDreamModelParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaDreamModelConfigParams?>.Default.Equals(Config, other.Config) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaDreamModelParams obj1, BetaDreamModelParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaDreamModelParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaDreamModelParams obj1, BetaDreamModelParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaDreamModelParams o && Equals(o);
        }
    }
}
