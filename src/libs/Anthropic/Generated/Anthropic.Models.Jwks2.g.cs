#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How signing keys are obtained. Defaults to OIDC discovery.
    /// </summary>
    public readonly partial struct Jwks2 : global::System.IEquatable<Jwks2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminatorType? Type { get; }

        /// <summary>
        /// JWKS via the issuer's OIDC discovery document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaJwksDiscovery? Discovery { get; init; }
#else
        public global::Anthropic.BetaJwksDiscovery? Discovery { get; }
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
            out global::Anthropic.BetaJwksDiscovery? value)
        {
            value = Discovery;
            return IsDiscovery;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksDiscovery PickDiscovery() => IsDiscovery
            ? Discovery!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Discovery' but the value was {ToString()}.");

        /// <summary>
        /// JWKS fetched from a fixed endpoint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaJwksExplicitUrl? ExplicitUrl { get; init; }
#else
        public global::Anthropic.BetaJwksExplicitUrl? ExplicitUrl { get; }
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
            out global::Anthropic.BetaJwksExplicitUrl? value)
        {
            value = ExplicitUrl;
            return IsExplicitUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksExplicitUrl PickExplicitUrl() => IsExplicitUrl
            ? ExplicitUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExplicitUrl' but the value was {ToString()}.");

        /// <summary>
        /// JWKS supplied directly; no network fetch.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaJwksInline? Inline { get; init; }
#else
        public global::Anthropic.BetaJwksInline? Inline { get; }
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
            out global::Anthropic.BetaJwksInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaJwksInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Jwks2(global::Anthropic.BetaJwksDiscovery value) => new Jwks2((global::Anthropic.BetaJwksDiscovery?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaJwksDiscovery?(Jwks2 @this) => @this.Discovery;

        /// <summary>
        ///
        /// </summary>
        public Jwks2(global::Anthropic.BetaJwksDiscovery? value)
        {
            Discovery = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Jwks2 FromDiscovery(global::Anthropic.BetaJwksDiscovery? value) => new Jwks2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Jwks2(global::Anthropic.BetaJwksExplicitUrl value) => new Jwks2((global::Anthropic.BetaJwksExplicitUrl?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaJwksExplicitUrl?(Jwks2 @this) => @this.ExplicitUrl;

        /// <summary>
        ///
        /// </summary>
        public Jwks2(global::Anthropic.BetaJwksExplicitUrl? value)
        {
            ExplicitUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Jwks2 FromExplicitUrl(global::Anthropic.BetaJwksExplicitUrl? value) => new Jwks2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Jwks2(global::Anthropic.BetaJwksInline value) => new Jwks2((global::Anthropic.BetaJwksInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaJwksInline?(Jwks2 @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public Jwks2(global::Anthropic.BetaJwksInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Jwks2 FromInline(global::Anthropic.BetaJwksInline? value) => new Jwks2(value);

        /// <summary>
        ///
        /// </summary>
        public Jwks2(
            global::Anthropic.BetaFederationIssuerCreateParamsJwksDiscriminatorType? type,
            global::Anthropic.BetaJwksDiscovery? discovery,
            global::Anthropic.BetaJwksExplicitUrl? explicitUrl,
            global::Anthropic.BetaJwksInline? inline
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
            global::System.Func<global::Anthropic.BetaJwksDiscovery, TResult>? discovery = null,
            global::System.Func<global::Anthropic.BetaJwksExplicitUrl, TResult>? explicitUrl = null,
            global::System.Func<global::Anthropic.BetaJwksInline, TResult>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDiscovery && discovery != null)
            {
                return discovery(Discovery!);
            }
            else if (IsExplicitUrl && explicitUrl != null)
            {
                return explicitUrl(ExplicitUrl!);
            }
            else if (IsInline && inline != null)
            {
                return inline(Inline!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaJwksDiscovery>? discovery = null,

            global::System.Action<global::Anthropic.BetaJwksExplicitUrl>? explicitUrl = null,

            global::System.Action<global::Anthropic.BetaJwksInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDiscovery)
            {
                discovery?.Invoke(Discovery!);
            }
            else if (IsExplicitUrl)
            {
                explicitUrl?.Invoke(ExplicitUrl!);
            }
            else if (IsInline)
            {
                inline?.Invoke(Inline!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaJwksDiscovery>? discovery = null,
            global::System.Action<global::Anthropic.BetaJwksExplicitUrl>? explicitUrl = null,
            global::System.Action<global::Anthropic.BetaJwksInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDiscovery)
            {
                discovery?.Invoke(Discovery!);
            }
            else if (IsExplicitUrl)
            {
                explicitUrl?.Invoke(ExplicitUrl!);
            }
            else if (IsInline)
            {
                inline?.Invoke(Inline!);
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
                typeof(global::Anthropic.BetaJwksDiscovery),
                ExplicitUrl,
                typeof(global::Anthropic.BetaJwksExplicitUrl),
                Inline,
                typeof(global::Anthropic.BetaJwksInline),
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
        public bool Equals(Jwks2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaJwksDiscovery?>.Default.Equals(Discovery, other.Discovery) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaJwksExplicitUrl?>.Default.Equals(ExplicitUrl, other.ExplicitUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaJwksInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Jwks2 obj1, Jwks2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Jwks2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Jwks2 obj1, Jwks2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Jwks2 o && Equals(o);
        }
    }
}
