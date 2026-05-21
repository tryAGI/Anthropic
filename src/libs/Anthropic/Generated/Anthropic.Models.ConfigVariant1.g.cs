#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConfigVariant1 : global::System.IEquatable<ConfigVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Request params for `cloud` environment configuration.<br/>
        /// Fields default to null; on update, omitted fields preserve the<br/>
        /// existing value.<br/>
        /// Example: {"type":"cloud","networking":{"type":"limited","allowed_hosts":["api.example.com"],"allow_package_managers":true},"packages":{"pip":["pandas","numpy"]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCloudConfigParams? Cloud { get; init; }
#else
        public global::Anthropic.BetaCloudConfigParams? Cloud { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cloud))]
#endif
        public bool IsCloud => Cloud != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCloud(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaCloudConfigParams? value)
        {
            value = Cloud;
            return IsCloud;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCloudConfigParams PickCloud() => IsCloud
            ? Cloud!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cloud' but the value was {ToString()}.");

        /// <summary>
        /// Request params for `self_hosted` environment configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaSelfHostedConfigParams? SelfHosted { get; init; }
#else
        public global::Anthropic.BetaSelfHostedConfigParams? SelfHosted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelfHosted))]
#endif
        public bool IsSelfHosted => SelfHosted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSelfHosted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaSelfHostedConfigParams? value)
        {
            value = SelfHosted;
            return IsSelfHosted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfigParams PickSelfHosted() => IsSelfHosted
            ? SelfHosted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SelfHosted' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConfigVariant1(global::Anthropic.BetaCloudConfigParams value) => new ConfigVariant1((global::Anthropic.BetaCloudConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCloudConfigParams?(ConfigVariant1 @this) => @this.Cloud;

        /// <summary>
        /// 
        /// </summary>
        public ConfigVariant1(global::Anthropic.BetaCloudConfigParams? value)
        {
            Cloud = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConfigVariant1 FromCloud(global::Anthropic.BetaCloudConfigParams? value) => new ConfigVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConfigVariant1(global::Anthropic.BetaSelfHostedConfigParams value) => new ConfigVariant1((global::Anthropic.BetaSelfHostedConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaSelfHostedConfigParams?(ConfigVariant1 @this) => @this.SelfHosted;

        /// <summary>
        /// 
        /// </summary>
        public ConfigVariant1(global::Anthropic.BetaSelfHostedConfigParams? value)
        {
            SelfHosted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConfigVariant1 FromSelfHosted(global::Anthropic.BetaSelfHostedConfigParams? value) => new ConfigVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public ConfigVariant1(
            global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? type,
            global::Anthropic.BetaCloudConfigParams? cloud,
            global::Anthropic.BetaSelfHostedConfigParams? selfHosted
            )
        {
            Type = type;

            Cloud = cloud;
            SelfHosted = selfHosted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SelfHosted as object ??
            Cloud as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Cloud?.ToString() ??
            SelfHosted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCloud && !IsSelfHosted || !IsCloud && IsSelfHosted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaCloudConfigParams, TResult>? cloud = null,
            global::System.Func<global::Anthropic.BetaSelfHostedConfigParams, TResult>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCloud && cloud != null)
            {
                return cloud(Cloud!);
            }
            else if (IsSelfHosted && selfHosted != null)
            {
                return selfHosted(SelfHosted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaCloudConfigParams>? cloud = null,

            global::System.Action<global::Anthropic.BetaSelfHostedConfigParams>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCloud)
            {
                cloud?.Invoke(Cloud!);
            }
            else if (IsSelfHosted)
            {
                selfHosted?.Invoke(SelfHosted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaCloudConfigParams>? cloud = null,
            global::System.Action<global::Anthropic.BetaSelfHostedConfigParams>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCloud)
            {
                cloud?.Invoke(Cloud!);
            }
            else if (IsSelfHosted)
            {
                selfHosted?.Invoke(SelfHosted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Cloud,
                typeof(global::Anthropic.BetaCloudConfigParams),
                SelfHosted,
                typeof(global::Anthropic.BetaSelfHostedConfigParams),
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
        public bool Equals(ConfigVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCloudConfigParams?>.Default.Equals(Cloud, other.Cloud) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaSelfHostedConfigParams?>.Default.Equals(SelfHosted, other.SelfHosted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConfigVariant1 obj1, ConfigVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConfigVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConfigVariant1 obj1, ConfigVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConfigVariant1 o && Equals(o);
        }
    }
}
