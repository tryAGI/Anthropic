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
        public ConfigVariant1(
            global::Anthropic.BetaPublicEnvironmentCreateRequestConfigVariant1DiscriminatorType? type,
            global::Anthropic.BetaCloudConfigParams? cloud
            )
        {
            Type = type;

            Cloud = cloud;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Cloud as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Cloud?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCloud;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaCloudConfigParams?, TResult>? cloud = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaCloudConfigParams?>? cloud = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCloudConfigParams?>.Default.Equals(Cloud, other.Cloud) 
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
