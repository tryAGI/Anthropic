#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaClaudeTagCreateBundleTargetRequestBody : global::System.IEquatable<BetaClaudeTagCreateBundleTargetRequestBody>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType? Type { get; }

        /// <summary>
        /// Attach the Bundle to a Slack channel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? SlackChannel { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? SlackChannel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackChannel))]
#endif
        public bool IsSlackChannel => SlackChannel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlackChannel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? value)
        {
            value = SlackChannel;
            return IsSlackChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate PickSlackChannel() => SlackChannel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackChannel' but the value was {ToString()}.");

        /// <summary>
        /// Attach the Bundle to a Slack workspace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? SlackWorkspace { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? SlackWorkspace { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackWorkspace))]
#endif
        public bool IsSlackWorkspace => SlackWorkspace != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlackWorkspace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? value)
        {
            value = SlackWorkspace;
            return IsSlackWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate PickSlackWorkspace() => SlackWorkspace is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackWorkspace' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagCreateBundleTargetRequestBody(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate value) => new BetaClaudeTagCreateBundleTargetRequestBody((global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate?(BetaClaudeTagCreateBundleTargetRequestBody @this) => @this.SlackChannel;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagCreateBundleTargetRequestBody(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? value)
        {
            SlackChannel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagCreateBundleTargetRequestBody FromSlackChannel(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? value) => new BetaClaudeTagCreateBundleTargetRequestBody(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagCreateBundleTargetRequestBody(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate value) => new BetaClaudeTagCreateBundleTargetRequestBody((global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate?(BetaClaudeTagCreateBundleTargetRequestBody @this) => @this.SlackWorkspace;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagCreateBundleTargetRequestBody(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? value)
        {
            SlackWorkspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagCreateBundleTargetRequestBody FromSlackWorkspace(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? value) => new BetaClaudeTagCreateBundleTargetRequestBody(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagCreateBundleTargetRequestBody(
            global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType? type,
            global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? slackChannel,
            global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? slackWorkspace
            )
        {
            Type = type;

            SlackChannel = slackChannel;
            SlackWorkspace = slackWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SlackWorkspace as object ??
            SlackChannel as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SlackChannel?.ToString() ??
            SlackWorkspace?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSlackChannel && !IsSlackWorkspace || !IsSlackChannel && IsSlackWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate, TResult>? slackChannel = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate, TResult>? slackWorkspace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SlackChannel is { } __value0 && slackChannel != null)
            {
                return slackChannel(__value0);
            }
            else if (SlackWorkspace is { } __value1 && slackWorkspace != null)
            {
                return slackWorkspace(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate>? slackChannel = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate>? slackWorkspace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SlackChannel is { } __value0)
            {
                slackChannel?.Invoke(__value0);
            }
            else if (SlackWorkspace is { } __value1)
            {
                slackWorkspace?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate>? slackChannel = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate>? slackWorkspace = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SlackChannel is { } __value0)
            {
                slackChannel?.Invoke(__value0);
            }
            else if (SlackWorkspace is { } __value1)
            {
                slackWorkspace?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SlackChannel,
                typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate),
                SlackWorkspace,
                typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate),
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
        public bool Equals(BetaClaudeTagCreateBundleTargetRequestBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate?>.Default.Equals(SlackChannel, other.SlackChannel) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate?>.Default.Equals(SlackWorkspace, other.SlackWorkspace)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeTagCreateBundleTargetRequestBody obj1, BetaClaudeTagCreateBundleTargetRequestBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeTagCreateBundleTargetRequestBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeTagCreateBundleTargetRequestBody obj1, BetaClaudeTagCreateBundleTargetRequestBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeTagCreateBundleTargetRequestBody o && Equals(o);
        }
    }
}
