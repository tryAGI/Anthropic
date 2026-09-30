#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ProviderConfigVariant12 : global::System.IEquatable<ProviderConfigVariant12>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AwsExternalKeyConfig? Aws { get; init; }
#else
        public global::Anthropic.AwsExternalKeyConfig? Aws { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aws))]
#endif
        public bool IsAws => Aws != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAws(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.AwsExternalKeyConfig? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AwsExternalKeyConfig PickAws() => Aws is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.GcpExternalKeyConfig? Gcp { get; init; }
#else
        public global::Anthropic.GcpExternalKeyConfig? Gcp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gcp))]
#endif
        public bool IsGcp => Gcp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.GcpExternalKeyConfig? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.GcpExternalKeyConfig PickGcp() => Gcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

        /// <summary>
        /// Azure Key Vault provider configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AzureExternalKeyConfigParams? Azure { get; init; }
#else
        public global::Anthropic.AzureExternalKeyConfigParams? Azure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAzure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.AzureExternalKeyConfigParams? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AzureExternalKeyConfigParams PickAzure() => Azure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigVariant12(global::Anthropic.AwsExternalKeyConfig value) => new ProviderConfigVariant12((global::Anthropic.AwsExternalKeyConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.AwsExternalKeyConfig?(ProviderConfigVariant12 @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigVariant12(global::Anthropic.AwsExternalKeyConfig? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigVariant12 FromAws(global::Anthropic.AwsExternalKeyConfig? value) => new ProviderConfigVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigVariant12(global::Anthropic.GcpExternalKeyConfig value) => new ProviderConfigVariant12((global::Anthropic.GcpExternalKeyConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.GcpExternalKeyConfig?(ProviderConfigVariant12 @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigVariant12(global::Anthropic.GcpExternalKeyConfig? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigVariant12 FromGcp(global::Anthropic.GcpExternalKeyConfig? value) => new ProviderConfigVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigVariant12(global::Anthropic.AzureExternalKeyConfigParams value) => new ProviderConfigVariant12((global::Anthropic.AzureExternalKeyConfigParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.AzureExternalKeyConfigParams?(ProviderConfigVariant12 @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigVariant12(global::Anthropic.AzureExternalKeyConfigParams? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigVariant12 FromAzure(global::Anthropic.AzureExternalKeyConfigParams? value) => new ProviderConfigVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigVariant12(
            global::Anthropic.ExternalKeyUpdateParamsProviderConfigVariant1DiscriminatorType? type,
            global::Anthropic.AwsExternalKeyConfig? aws,
            global::Anthropic.GcpExternalKeyConfig? gcp,
            global::Anthropic.AzureExternalKeyConfigParams? azure
            )
        {
            Type = type;

            Aws = aws;
            Gcp = gcp;
            Azure = azure;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Azure as object ??
            Gcp as object ??
            Aws as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Gcp?.ToString() ??
            Azure?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsGcp && !IsAzure || !IsAws && IsGcp && !IsAzure || !IsAws && !IsGcp && IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.AwsExternalKeyConfig, TResult>? aws = null,
            global::System.Func<global::Anthropic.GcpExternalKeyConfig, TResult>? gcp = null,
            global::System.Func<global::Anthropic.AzureExternalKeyConfigParams, TResult>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0 && aws != null)
            {
                return aws(__value0);
            }
            else if (Gcp is { } __value1 && gcp != null)
            {
                return gcp(__value1);
            }
            else if (Azure is { } __value2 && azure != null)
            {
                return azure(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.AwsExternalKeyConfig>? aws = null,

            global::System.Action<global::Anthropic.GcpExternalKeyConfig>? gcp = null,

            global::System.Action<global::Anthropic.AzureExternalKeyConfigParams>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Gcp is { } __value1)
            {
                gcp?.Invoke(__value1);
            }
            else if (Azure is { } __value2)
            {
                azure?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.AwsExternalKeyConfig>? aws = null,
            global::System.Action<global::Anthropic.GcpExternalKeyConfig>? gcp = null,
            global::System.Action<global::Anthropic.AzureExternalKeyConfigParams>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Gcp is { } __value1)
            {
                gcp?.Invoke(__value1);
            }
            else if (Azure is { } __value2)
            {
                azure?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Aws,
                typeof(global::Anthropic.AwsExternalKeyConfig),
                Gcp,
                typeof(global::Anthropic.GcpExternalKeyConfig),
                Azure,
                typeof(global::Anthropic.AzureExternalKeyConfigParams),
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
        public bool Equals(ProviderConfigVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AwsExternalKeyConfig?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.GcpExternalKeyConfig?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AzureExternalKeyConfigParams?>.Default.Equals(Azure, other.Azure)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProviderConfigVariant12 obj1, ProviderConfigVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderConfigVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderConfigVariant12 obj1, ProviderConfigVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderConfigVariant12 o && Equals(o);
        }
    }
}
