#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Environment configuration (either Anthropic Cloud or self-hosted)
    /// </summary>
    public readonly partial struct Config : global::System.IEquatable<Config>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaEnvironmentConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// `cloud` environment configuration.<br/>
        /// Example: {"type":"cloud","networking":{"type":"limited","allowed_hosts":["api.example.com"],"allow_package_managers":true,"allow_mcp_servers":false},"packages":{"type":"packages","pip":["pandas","numpy"],"npm":[],"apt":[],"cargo":[],"gem":[],"go":[]}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCloudConfig? Cloud { get; init; }
#else
        public global::Anthropic.BetaCloudConfig? Cloud { get; }
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
            out global::Anthropic.BetaCloudConfig? value)
        {
            value = Cloud;
            return IsCloud;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCloudConfig PickCloud() => IsCloud
            ? Cloud!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cloud' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for self-hosted environments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaSelfHostedConfig? SelfHosted { get; init; }
#else
        public global::Anthropic.BetaSelfHostedConfig? SelfHosted { get; }
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
            out global::Anthropic.BetaSelfHostedConfig? value)
        {
            value = SelfHosted;
            return IsSelfHosted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaSelfHostedConfig PickSelfHosted() => IsSelfHosted
            ? SelfHosted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SelfHosted' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::Anthropic.BetaCloudConfig value) => new Config((global::Anthropic.BetaCloudConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCloudConfig?(Config @this) => @this.Cloud;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::Anthropic.BetaCloudConfig? value)
        {
            Cloud = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Config FromCloud(global::Anthropic.BetaCloudConfig? value) => new Config(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::Anthropic.BetaSelfHostedConfig value) => new Config((global::Anthropic.BetaSelfHostedConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaSelfHostedConfig?(Config @this) => @this.SelfHosted;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::Anthropic.BetaSelfHostedConfig? value)
        {
            SelfHosted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Config FromSelfHosted(global::Anthropic.BetaSelfHostedConfig? value) => new Config(value);

        /// <summary>
        /// 
        /// </summary>
        public Config(
            global::Anthropic.BetaEnvironmentConfigDiscriminatorType? type,
            global::Anthropic.BetaCloudConfig? cloud,
            global::Anthropic.BetaSelfHostedConfig? selfHosted
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
            global::System.Func<global::Anthropic.BetaCloudConfig, TResult>? cloud = null,
            global::System.Func<global::Anthropic.BetaSelfHostedConfig, TResult>? selfHosted = null,
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
            global::System.Action<global::Anthropic.BetaCloudConfig>? cloud = null,

            global::System.Action<global::Anthropic.BetaSelfHostedConfig>? selfHosted = null,
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
            global::System.Action<global::Anthropic.BetaCloudConfig>? cloud = null,
            global::System.Action<global::Anthropic.BetaSelfHostedConfig>? selfHosted = null,
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
                typeof(global::Anthropic.BetaCloudConfig),
                SelfHosted,
                typeof(global::Anthropic.BetaSelfHostedConfig),
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
        public bool Equals(Config other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCloudConfig?>.Default.Equals(Cloud, other.Cloud) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaSelfHostedConfig?>.Default.Equals(SelfHosted, other.SelfHosted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Config obj1, Config obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Config obj1, Config obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config o && Equals(o);
        }
    }
}
