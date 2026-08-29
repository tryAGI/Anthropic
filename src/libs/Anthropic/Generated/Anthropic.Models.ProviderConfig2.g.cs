#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// KMS provider identity and auth coordinates.
    /// </summary>
    public readonly partial struct ProviderConfig2 : global::System.IEquatable<ProviderConfig2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAwsExternalKeyConfig? Aws { get; init; }
#else
        public global::Anthropic.BetaAwsExternalKeyConfig? Aws { get; }
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
            out global::Anthropic.BetaAwsExternalKeyConfig? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalKeyConfig PickAws() => IsAws
            ? Aws!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGcpExternalKeyConfig? Gcp { get; init; }
#else
        public global::Anthropic.BetaGcpExternalKeyConfig? Gcp { get; }
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
            out global::Anthropic.BetaGcpExternalKeyConfig? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalKeyConfig PickGcp() => IsGcp
            ? Gcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

        /// <summary>
        /// Azure Key Vault provider configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAzureExternalKeyConfigParams? Azure { get; init; }
#else
        public global::Anthropic.BetaAzureExternalKeyConfigParams? Azure { get; }
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
            out global::Anthropic.BetaAzureExternalKeyConfigParams? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAzureExternalKeyConfigParams PickAzure() => IsAzure
            ? Azure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfig2(global::Anthropic.BetaAwsExternalKeyConfig value) => new ProviderConfig2((global::Anthropic.BetaAwsExternalKeyConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAwsExternalKeyConfig?(ProviderConfig2 @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfig2(global::Anthropic.BetaAwsExternalKeyConfig? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfig2 FromAws(global::Anthropic.BetaAwsExternalKeyConfig? value) => new ProviderConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfig2(global::Anthropic.BetaGcpExternalKeyConfig value) => new ProviderConfig2((global::Anthropic.BetaGcpExternalKeyConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGcpExternalKeyConfig?(ProviderConfig2 @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfig2(global::Anthropic.BetaGcpExternalKeyConfig? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfig2 FromGcp(global::Anthropic.BetaGcpExternalKeyConfig? value) => new ProviderConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfig2(global::Anthropic.BetaAzureExternalKeyConfigParams value) => new ProviderConfig2((global::Anthropic.BetaAzureExternalKeyConfigParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAzureExternalKeyConfigParams?(ProviderConfig2 @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfig2(global::Anthropic.BetaAzureExternalKeyConfigParams? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfig2 FromAzure(global::Anthropic.BetaAzureExternalKeyConfigParams? value) => new ProviderConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public ProviderConfig2(
            global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType? type,
            global::Anthropic.BetaAwsExternalKeyConfig? aws,
            global::Anthropic.BetaGcpExternalKeyConfig? gcp,
            global::Anthropic.BetaAzureExternalKeyConfigParams? azure
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
            global::System.Func<global::Anthropic.BetaAwsExternalKeyConfig, TResult>? aws = null,
            global::System.Func<global::Anthropic.BetaGcpExternalKeyConfig, TResult>? gcp = null,
            global::System.Func<global::Anthropic.BetaAzureExternalKeyConfigParams, TResult>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws && aws != null)
            {
                return aws(Aws!);
            }
            else if (IsGcp && gcp != null)
            {
                return gcp(Gcp!);
            }
            else if (IsAzure && azure != null)
            {
                return azure(Azure!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaAwsExternalKeyConfig>? aws = null,

            global::System.Action<global::Anthropic.BetaGcpExternalKeyConfig>? gcp = null,

            global::System.Action<global::Anthropic.BetaAzureExternalKeyConfigParams>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws)
            {
                aws?.Invoke(Aws!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaAwsExternalKeyConfig>? aws = null,
            global::System.Action<global::Anthropic.BetaGcpExternalKeyConfig>? gcp = null,
            global::System.Action<global::Anthropic.BetaAzureExternalKeyConfigParams>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws)
            {
                aws?.Invoke(Aws!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
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
                typeof(global::Anthropic.BetaAwsExternalKeyConfig),
                Gcp,
                typeof(global::Anthropic.BetaGcpExternalKeyConfig),
                Azure,
                typeof(global::Anthropic.BetaAzureExternalKeyConfigParams),
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
        public bool Equals(ProviderConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAwsExternalKeyConfig?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGcpExternalKeyConfig?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAzureExternalKeyConfigParams?>.Default.Equals(Azure, other.Azure)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProviderConfig2 obj1, ProviderConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderConfig2 obj1, ProviderConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderConfig2 o && Equals(o);
        }
    }
}
