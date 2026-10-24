#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What Claude does in a channel while a Slack guest is in it, for everyone in the channel. It changes nothing in a channel without Slack guests. More types can be added.
    /// </summary>
    public readonly partial struct BetaClaudeTagGuestPolicy : global::System.IEquatable<BetaClaudeTagGuestPolicy>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyDiscriminatorType? Type { get; }

        /// <summary>
        /// Claude answers in the channel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagGuestPolicyAllow? Allow { get; init; }
#else
        public global::Anthropic.BetaClaudeTagGuestPolicyAllow? Allow { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Allow))]
#endif
        public bool IsAllow => Allow != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAllow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagGuestPolicyAllow? value)
        {
            value = Allow;
            return IsAllow;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyAllow PickAllow() => Allow is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Allow' but the value was {ToString()}.");

        /// <summary>
        /// Claude does not answer in the channel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagGuestPolicyRestrict? Restrict { get; init; }
#else
        public global::Anthropic.BetaClaudeTagGuestPolicyRestrict? Restrict { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Restrict))]
#endif
        public bool IsRestrict => Restrict != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRestrict(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagGuestPolicyRestrict? value)
        {
            value = Restrict;
            return IsRestrict;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyRestrict PickRestrict() => Restrict is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Restrict' but the value was {ToString()}.");

        /// <summary>
        /// Claude answers with only the Bundles attached to the channel itself.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? ChannelOnly { get; init; }
#else
        public global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? ChannelOnly { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChannelOnly))]
#endif
        public bool IsChannelOnly => ChannelOnly != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChannelOnly(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? value)
        {
            value = ChannelOnly;
            return IsChannelOnly;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly PickChannelOnly() => ChannelOnly is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChannelOnly' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagGuestPolicy(global::Anthropic.BetaClaudeTagGuestPolicyAllow value) => new BetaClaudeTagGuestPolicy((global::Anthropic.BetaClaudeTagGuestPolicyAllow?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagGuestPolicyAllow?(BetaClaudeTagGuestPolicy @this) => @this.Allow;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagGuestPolicy(global::Anthropic.BetaClaudeTagGuestPolicyAllow? value)
        {
            Allow = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagGuestPolicy FromAllow(global::Anthropic.BetaClaudeTagGuestPolicyAllow? value) => new BetaClaudeTagGuestPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagGuestPolicy(global::Anthropic.BetaClaudeTagGuestPolicyRestrict value) => new BetaClaudeTagGuestPolicy((global::Anthropic.BetaClaudeTagGuestPolicyRestrict?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagGuestPolicyRestrict?(BetaClaudeTagGuestPolicy @this) => @this.Restrict;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagGuestPolicy(global::Anthropic.BetaClaudeTagGuestPolicyRestrict? value)
        {
            Restrict = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagGuestPolicy FromRestrict(global::Anthropic.BetaClaudeTagGuestPolicyRestrict? value) => new BetaClaudeTagGuestPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagGuestPolicy(global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly value) => new BetaClaudeTagGuestPolicy((global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly?(BetaClaudeTagGuestPolicy @this) => @this.ChannelOnly;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagGuestPolicy(global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? value)
        {
            ChannelOnly = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagGuestPolicy FromChannelOnly(global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? value) => new BetaClaudeTagGuestPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagGuestPolicy(
            global::Anthropic.BetaClaudeTagGuestPolicyDiscriminatorType? type,
            global::Anthropic.BetaClaudeTagGuestPolicyAllow? allow,
            global::Anthropic.BetaClaudeTagGuestPolicyRestrict? restrict,
            global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly? channelOnly
            )
        {
            Type = type;

            Allow = allow;
            Restrict = restrict;
            ChannelOnly = channelOnly;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ChannelOnly as object ??
            Restrict as object ??
            Allow as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Allow?.ToString() ??
            Restrict?.ToString() ??
            ChannelOnly?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAllow && !IsRestrict && !IsChannelOnly || !IsAllow && IsRestrict && !IsChannelOnly || !IsAllow && !IsRestrict && IsChannelOnly;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeTagGuestPolicyAllow, TResult>? allow = null,
            global::System.Func<global::Anthropic.BetaClaudeTagGuestPolicyRestrict, TResult>? restrict = null,
            global::System.Func<global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly, TResult>? channelOnly = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Allow is { } __value0 && allow != null)
            {
                return allow(__value0);
            }
            else if (Restrict is { } __value1 && restrict != null)
            {
                return restrict(__value1);
            }
            else if (ChannelOnly is { } __value2 && channelOnly != null)
            {
                return channelOnly(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeTagGuestPolicyAllow>? allow = null,

            global::System.Action<global::Anthropic.BetaClaudeTagGuestPolicyRestrict>? restrict = null,

            global::System.Action<global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly>? channelOnly = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Allow is { } __value0)
            {
                allow?.Invoke(__value0);
            }
            else if (Restrict is { } __value1)
            {
                restrict?.Invoke(__value1);
            }
            else if (ChannelOnly is { } __value2)
            {
                channelOnly?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeTagGuestPolicyAllow>? allow = null,
            global::System.Action<global::Anthropic.BetaClaudeTagGuestPolicyRestrict>? restrict = null,
            global::System.Action<global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly>? channelOnly = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Allow is { } __value0)
            {
                allow?.Invoke(__value0);
            }
            else if (Restrict is { } __value1)
            {
                restrict?.Invoke(__value1);
            }
            else if (ChannelOnly is { } __value2)
            {
                channelOnly?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Allow,
                typeof(global::Anthropic.BetaClaudeTagGuestPolicyAllow),
                Restrict,
                typeof(global::Anthropic.BetaClaudeTagGuestPolicyRestrict),
                ChannelOnly,
                typeof(global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly),
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
        public bool Equals(BetaClaudeTagGuestPolicy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagGuestPolicyAllow?>.Default.Equals(Allow, other.Allow) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagGuestPolicyRestrict?>.Default.Equals(Restrict, other.Restrict) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagGuestPolicyChannelOnly?>.Default.Equals(ChannelOnly, other.ChannelOnly)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeTagGuestPolicy obj1, BetaClaudeTagGuestPolicy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeTagGuestPolicy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeTagGuestPolicy obj1, BetaClaudeTagGuestPolicy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeTagGuestPolicy o && Equals(o);
        }
    }
}
