#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How signing keys are obtained. Defaults to OIDC discovery.
    /// </summary>
    public readonly partial struct Jwks4 : global::System.IEquatable<Jwks4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType? Type { get; }

        /// <summary>
        /// JWKS via the issuer's OIDC discovery document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.JwksDiscovery? Discovery { get; init; }
#else
        public global::Anthropic.JwksDiscovery? Discovery { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Discovery))]
#endif
        public bool IsDiscovery => Discovery != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDiscovery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.JwksDiscovery? value)
        {
            value = Discovery;
            return IsDiscovery;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksDiscovery PickDiscovery() => Discovery is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Discovery' but the value was {ToString()}.");

        /// <summary>
        /// JWKS fetched from a fixed endpoint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.JwksExplicitUrl? ExplicitUrl { get; init; }
#else
        public global::Anthropic.JwksExplicitUrl? ExplicitUrl { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExplicitUrl))]
#endif
        public bool IsExplicitUrl => ExplicitUrl != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExplicitUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.JwksExplicitUrl? value)
        {
            value = ExplicitUrl;
            return IsExplicitUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksExplicitUrl PickExplicitUrl() => ExplicitUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExplicitUrl' but the value was {ToString()}.");

        /// <summary>
        /// JWKS supplied directly; no network fetch.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.JwksInline? Inline { get; init; }
#else
        public global::Anthropic.JwksInline? Inline { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inline))]
#endif
        public bool IsInline => Inline != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInline(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.JwksInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.JwksInline PickInline() => Inline is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Jwks4(global::Anthropic.JwksDiscovery value) => new Jwks4((global::Anthropic.JwksDiscovery?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.JwksDiscovery?(Jwks4 @this) => @this.Discovery;

        /// <summary>
        ///
        /// </summary>
        public Jwks4(global::Anthropic.JwksDiscovery? value)
        {
            Discovery = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Jwks4 FromDiscovery(global::Anthropic.JwksDiscovery? value) => new Jwks4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Jwks4(global::Anthropic.JwksExplicitUrl value) => new Jwks4((global::Anthropic.JwksExplicitUrl?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.JwksExplicitUrl?(Jwks4 @this) => @this.ExplicitUrl;

        /// <summary>
        ///
        /// </summary>
        public Jwks4(global::Anthropic.JwksExplicitUrl? value)
        {
            ExplicitUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Jwks4 FromExplicitUrl(global::Anthropic.JwksExplicitUrl? value) => new Jwks4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Jwks4(global::Anthropic.JwksInline value) => new Jwks4((global::Anthropic.JwksInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.JwksInline?(Jwks4 @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public Jwks4(global::Anthropic.JwksInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Jwks4 FromInline(global::Anthropic.JwksInline? value) => new Jwks4(value);

        /// <summary>
        ///
        /// </summary>
        public Jwks4(
            global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType? type,
            global::Anthropic.JwksDiscovery? discovery,
            global::Anthropic.JwksExplicitUrl? explicitUrl,
            global::Anthropic.JwksInline? inline
            )
        {
            Type = type;

            Discovery = discovery;
            ExplicitUrl = explicitUrl;
            Inline = inline;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Inline as object ??
            ExplicitUrl as object ??
            Discovery as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Discovery?.ToString() ??
            ExplicitUrl?.ToString() ??
            Inline?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDiscovery && !IsExplicitUrl && !IsInline || !IsDiscovery && IsExplicitUrl && !IsInline || !IsDiscovery && !IsExplicitUrl && IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.JwksDiscovery, TResult>? discovery = null,
            global::System.Func<global::Anthropic.JwksExplicitUrl, TResult>? explicitUrl = null,
            global::System.Func<global::Anthropic.JwksInline, TResult>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Discovery is { } __value0 && discovery != null)
            {
                return discovery(__value0);
            }
            else if (ExplicitUrl is { } __value1 && explicitUrl != null)
            {
                return explicitUrl(__value1);
            }
            else if (Inline is { } __value2 && inline != null)
            {
                return inline(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.JwksDiscovery>? discovery = null,

            global::System.Action<global::Anthropic.JwksExplicitUrl>? explicitUrl = null,

            global::System.Action<global::Anthropic.JwksInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Discovery is { } __value0)
            {
                discovery?.Invoke(__value0);
            }
            else if (ExplicitUrl is { } __value1)
            {
                explicitUrl?.Invoke(__value1);
            }
            else if (Inline is { } __value2)
            {
                inline?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.JwksDiscovery>? discovery = null,
            global::System.Action<global::Anthropic.JwksExplicitUrl>? explicitUrl = null,
            global::System.Action<global::Anthropic.JwksInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Discovery is { } __value0)
            {
                discovery?.Invoke(__value0);
            }
            else if (ExplicitUrl is { } __value1)
            {
                explicitUrl?.Invoke(__value1);
            }
            else if (Inline is { } __value2)
            {
                inline?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Discovery,
                typeof(global::Anthropic.JwksDiscovery),
                ExplicitUrl,
                typeof(global::Anthropic.JwksExplicitUrl),
                Inline,
                typeof(global::Anthropic.JwksInline),
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
        public bool Equals(Jwks4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.JwksDiscovery?>.Default.Equals(Discovery, other.Discovery) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.JwksExplicitUrl?>.Default.Equals(ExplicitUrl, other.ExplicitUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.JwksInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Jwks4 obj1, Jwks4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Jwks4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Jwks4 obj1, Jwks4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Jwks4 o && Equals(o);
        }
    }
}
