#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ProviderConfig6 : global::System.IEquatable<ProviderConfig6>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageCreateParamsProviderConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// An Amazon S3 bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAwsExternalStorageConfigParams? Aws { get; init; }
#else
        public global::Anthropic.BetaAwsExternalStorageConfigParams? Aws { get; }
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
            out global::Anthropic.BetaAwsExternalStorageConfigParams? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAwsExternalStorageConfigParams PickAws() => Aws is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        /// A Google Cloud Storage bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGcpExternalStorageConfigParams? Gcp { get; init; }
#else
        public global::Anthropic.BetaGcpExternalStorageConfigParams? Gcp { get; }
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
            out global::Anthropic.BetaGcpExternalStorageConfigParams? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGcpExternalStorageConfigParams PickGcp() => Gcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfig6(global::Anthropic.BetaAwsExternalStorageConfigParams value) => new ProviderConfig6((global::Anthropic.BetaAwsExternalStorageConfigParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAwsExternalStorageConfigParams?(ProviderConfig6 @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfig6(global::Anthropic.BetaAwsExternalStorageConfigParams? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfig6 FromAws(global::Anthropic.BetaAwsExternalStorageConfigParams? value) => new ProviderConfig6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfig6(global::Anthropic.BetaGcpExternalStorageConfigParams value) => new ProviderConfig6((global::Anthropic.BetaGcpExternalStorageConfigParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGcpExternalStorageConfigParams?(ProviderConfig6 @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfig6(global::Anthropic.BetaGcpExternalStorageConfigParams? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfig6 FromGcp(global::Anthropic.BetaGcpExternalStorageConfigParams? value) => new ProviderConfig6(value);

        /// <summary>
        ///
        /// </summary>
        public ProviderConfig6(
            global::Anthropic.BetaExternalStorageCreateParamsProviderConfigDiscriminatorType? type,
            global::Anthropic.BetaAwsExternalStorageConfigParams? aws,
            global::Anthropic.BetaGcpExternalStorageConfigParams? gcp
            )
        {
            Type = type;

            Aws = aws;
            Gcp = gcp;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Gcp as object ??
            Aws as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Gcp?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsGcp || !IsAws && IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaAwsExternalStorageConfigParams, TResult>? aws = null,
            global::System.Func<global::Anthropic.BetaGcpExternalStorageConfigParams, TResult>? gcp = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaAwsExternalStorageConfigParams>? aws = null,

            global::System.Action<global::Anthropic.BetaGcpExternalStorageConfigParams>? gcp = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaAwsExternalStorageConfigParams>? aws = null,
            global::System.Action<global::Anthropic.BetaGcpExternalStorageConfigParams>? gcp = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Aws,
                typeof(global::Anthropic.BetaAwsExternalStorageConfigParams),
                Gcp,
                typeof(global::Anthropic.BetaGcpExternalStorageConfigParams),
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
        public bool Equals(ProviderConfig6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAwsExternalStorageConfigParams?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGcpExternalStorageConfigParams?>.Default.Equals(Gcp, other.Gcp)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProviderConfig6 obj1, ProviderConfig6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderConfig6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderConfig6 obj1, ProviderConfig6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderConfig6 o && Equals(o);
        }
    }
}
