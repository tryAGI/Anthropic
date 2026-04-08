#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsModelParams : global::System.IEquatable<BetaManagedAgentsModelParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsModel? BetaManagedAgentsModel { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsModel? BetaManagedAgentsModel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModel))]
#endif
        public bool IsBetaManagedAgentsModel => BetaManagedAgentsModel != null;

        /// <summary>
        /// An object that defines additional configuration control over model use<br/>
        /// Example: {"id":"claude-opus-4-6"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsModelConfigParams? Config { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsModelConfigParams? Config { get; }
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
        public static implicit operator BetaManagedAgentsModelParams(global::Anthropic.BetaManagedAgentsModel value) => new BetaManagedAgentsModelParams((global::Anthropic.BetaManagedAgentsModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsModel?(BetaManagedAgentsModelParams @this) => @this.BetaManagedAgentsModel;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsModelParams(global::Anthropic.BetaManagedAgentsModel? value)
        {
            BetaManagedAgentsModel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsModelParams(global::Anthropic.BetaManagedAgentsModelConfigParams value) => new BetaManagedAgentsModelParams((global::Anthropic.BetaManagedAgentsModelConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsModelConfigParams?(BetaManagedAgentsModelParams @this) => @this.Config;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsModelParams(global::Anthropic.BetaManagedAgentsModelConfigParams? value)
        {
            Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsModelParams(
            global::Anthropic.BetaManagedAgentsModel? betaManagedAgentsModel,
            global::Anthropic.BetaManagedAgentsModelConfigParams? config
            )
        {
            BetaManagedAgentsModel = betaManagedAgentsModel;
            Config = config;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Config as object ??
            BetaManagedAgentsModel as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BetaManagedAgentsModel?.ToString() ??
            Config?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBetaManagedAgentsModel && !IsConfig || !IsBetaManagedAgentsModel && IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsModel?, TResult>? betaManagedAgentsModel = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsModelConfigParams?, TResult>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaManagedAgentsModel && betaManagedAgentsModel != null)
            {
                return betaManagedAgentsModel(BetaManagedAgentsModel!);
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
            global::System.Action<global::Anthropic.BetaManagedAgentsModel?>? betaManagedAgentsModel = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsModelConfigParams?>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaManagedAgentsModel)
            {
                betaManagedAgentsModel?.Invoke(BetaManagedAgentsModel!);
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
                BetaManagedAgentsModel,
                typeof(global::Anthropic.BetaManagedAgentsModel),
                Config,
                typeof(global::Anthropic.BetaManagedAgentsModelConfigParams),
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
        public bool Equals(BetaManagedAgentsModelParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsModel?>.Default.Equals(BetaManagedAgentsModel, other.BetaManagedAgentsModel) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsModelConfigParams?>.Default.Equals(Config, other.Config) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsModelParams obj1, BetaManagedAgentsModelParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsModelParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsModelParams obj1, BetaManagedAgentsModelParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsModelParams o && Equals(o);
        }
    }
}
