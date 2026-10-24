#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One Bundle attached to one Slack channel or one Slack workspace. More types of target can be added.
    /// </summary>
    public readonly partial struct BetaClaudeTagBundleTarget : global::System.IEquatable<BetaClaudeTagBundleTarget>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagBundleTargetDiscriminatorType? Type { get; }

        /// <summary>
        /// One Bundle attached to one Slack channel. The Bundle can be used in that channel only.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? SlackChannel { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? SlackChannel { get; }
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
            out global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? value)
        {
            value = SlackChannel;
            return IsSlackChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelBundleTarget PickSlackChannel() => SlackChannel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackChannel' but the value was {ToString()}.");

        /// <summary>
        /// One Bundle attached to one Slack workspace. The Bundle can be used in the workspace and in every channel in it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? SlackWorkspace { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? SlackWorkspace { get; }
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
            out global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? value)
        {
            value = SlackWorkspace;
            return IsSlackWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget PickSlackWorkspace() => SlackWorkspace is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackWorkspace' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagBundleTarget(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget value) => new BetaClaudeTagBundleTarget((global::Anthropic.BetaClaudeTagSlackChannelBundleTarget?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackChannelBundleTarget?(BetaClaudeTagBundleTarget @this) => @this.SlackChannel;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagBundleTarget(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? value)
        {
            SlackChannel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagBundleTarget FromSlackChannel(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? value) => new BetaClaudeTagBundleTarget(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagBundleTarget(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget value) => new BetaClaudeTagBundleTarget((global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget?(BetaClaudeTagBundleTarget @this) => @this.SlackWorkspace;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagBundleTarget(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? value)
        {
            SlackWorkspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagBundleTarget FromSlackWorkspace(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? value) => new BetaClaudeTagBundleTarget(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagBundleTarget(
            global::Anthropic.BetaClaudeTagBundleTargetDiscriminatorType? type,
            global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? slackChannel,
            global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? slackWorkspace
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
            global::System.Func<global::Anthropic.BetaClaudeTagSlackChannelBundleTarget, TResult>? slackChannel = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget, TResult>? slackWorkspace = null,
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
            global::System.Action<global::Anthropic.BetaClaudeTagSlackChannelBundleTarget>? slackChannel = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget>? slackWorkspace = null,
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
            global::System.Action<global::Anthropic.BetaClaudeTagSlackChannelBundleTarget>? slackChannel = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget>? slackWorkspace = null,
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
                typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget),
                SlackWorkspace,
                typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget),
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
        public bool Equals(BetaClaudeTagBundleTarget other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackChannelBundleTarget?>.Default.Equals(SlackChannel, other.SlackChannel) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget?>.Default.Equals(SlackWorkspace, other.SlackWorkspace)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeTagBundleTarget obj1, BetaClaudeTagBundleTarget obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeTagBundleTarget>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeTagBundleTarget obj1, BetaClaudeTagBundleTarget obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeTagBundleTarget o && Equals(o);
        }
    }
}
