#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaAnalyticsFederatedActorProvider : global::System.IEquatable<BetaAnalyticsFederatedActorProvider>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? Aws { get; init; }
#else
        public global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? Aws { get; }
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
            out global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAwsProvider PickAws() => Aws is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? Azure { get; init; }
#else
        public global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? Azure { get; }
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
            out global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorAzureProvider PickAzure() => Azure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? Gcp { get; init; }
#else
        public global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? Gcp { get; }
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
            out global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorGcpProvider PickGcp() => Gcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? Oidc { get; init; }
#else
        public global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? Oidc { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oidc))]
#endif
        public bool IsOidc => Oidc != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOidc(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? value)
        {
            value = Oidc;
            return IsOidc;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActorOidcProvider PickOidc() => Oidc is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Oidc' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider value) => new BetaAnalyticsFederatedActorProvider((global::Anthropic.BetaAnalyticsFederatedActorAwsProvider?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsFederatedActorAwsProvider?(BetaAnalyticsFederatedActorProvider @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsFederatedActorProvider FromAws(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? value) => new BetaAnalyticsFederatedActorProvider(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider value) => new BetaAnalyticsFederatedActorProvider((global::Anthropic.BetaAnalyticsFederatedActorAzureProvider?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsFederatedActorAzureProvider?(BetaAnalyticsFederatedActorProvider @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsFederatedActorProvider FromAzure(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? value) => new BetaAnalyticsFederatedActorProvider(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider value) => new BetaAnalyticsFederatedActorProvider((global::Anthropic.BetaAnalyticsFederatedActorGcpProvider?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsFederatedActorGcpProvider?(BetaAnalyticsFederatedActorProvider @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsFederatedActorProvider FromGcp(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? value) => new BetaAnalyticsFederatedActorProvider(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider value) => new BetaAnalyticsFederatedActorProvider((global::Anthropic.BetaAnalyticsFederatedActorOidcProvider?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsFederatedActorOidcProvider?(BetaAnalyticsFederatedActorProvider @this) => @this.Oidc;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsFederatedActorProvider(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? value)
        {
            Oidc = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsFederatedActorProvider FromOidc(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? value) => new BetaAnalyticsFederatedActorProvider(value);

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsFederatedActorProvider(
            global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType? type,
            global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? aws,
            global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? azure,
            global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? gcp,
            global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? oidc
            )
        {
            Type = type;

            Aws = aws;
            Azure = azure;
            Gcp = gcp;
            Oidc = oidc;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Oidc as object ??
            Gcp as object ??
            Azure as object ??
            Aws as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Azure?.ToString() ??
            Gcp?.ToString() ??
            Oidc?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsAzure && !IsGcp && !IsOidc || !IsAws && IsAzure && !IsGcp && !IsOidc || !IsAws && !IsAzure && IsGcp && !IsOidc || !IsAws && !IsAzure && !IsGcp && IsOidc;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaAnalyticsFederatedActorAwsProvider, TResult>? aws = null,
            global::System.Func<global::Anthropic.BetaAnalyticsFederatedActorAzureProvider, TResult>? azure = null,
            global::System.Func<global::Anthropic.BetaAnalyticsFederatedActorGcpProvider, TResult>? gcp = null,
            global::System.Func<global::Anthropic.BetaAnalyticsFederatedActorOidcProvider, TResult>? oidc = null,
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
            else if (Azure is { } __value1 && azure != null)
            {
                return azure(__value1);
            }
            else if (Gcp is { } __value2 && gcp != null)
            {
                return gcp(__value2);
            }
            else if (Oidc is { } __value3 && oidc != null)
            {
                return oidc(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorAwsProvider>? aws = null,

            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorAzureProvider>? azure = null,

            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorGcpProvider>? gcp = null,

            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorOidcProvider>? oidc = null,
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
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
            else if (Gcp is { } __value2)
            {
                gcp?.Invoke(__value2);
            }
            else if (Oidc is { } __value3)
            {
                oidc?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorAwsProvider>? aws = null,
            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorAzureProvider>? azure = null,
            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorGcpProvider>? gcp = null,
            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActorOidcProvider>? oidc = null,
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
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
            else if (Gcp is { } __value2)
            {
                gcp?.Invoke(__value2);
            }
            else if (Oidc is { } __value3)
            {
                oidc?.Invoke(__value3);
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
                typeof(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider),
                Azure,
                typeof(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider),
                Gcp,
                typeof(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider),
                Oidc,
                typeof(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider),
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
        public bool Equals(BetaAnalyticsFederatedActorProvider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsFederatedActorAwsProvider?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsFederatedActorAzureProvider?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsFederatedActorGcpProvider?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsFederatedActorOidcProvider?>.Default.Equals(Oidc, other.Oidc)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaAnalyticsFederatedActorProvider obj1, BetaAnalyticsFederatedActorProvider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaAnalyticsFederatedActorProvider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaAnalyticsFederatedActorProvider obj1, BetaAnalyticsFederatedActorProvider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaAnalyticsFederatedActorProvider o && Equals(o);
        }
    }
}
