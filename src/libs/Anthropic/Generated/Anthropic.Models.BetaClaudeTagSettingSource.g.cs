#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The settings level a value comes from. More types can be added.
    /// </summary>
    public readonly partial struct BetaClaudeTagSettingSource : global::System.IEquatable<BetaClaudeTagSettingSource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// The value comes from the addressed Slack channel itself.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackChannelSettingSource? SlackChannel { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackChannelSettingSource? SlackChannel { get; }
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
            out global::Anthropic.BetaClaudeTagSlackChannelSettingSource? value)
        {
            value = SlackChannel;
            return IsSlackChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackChannelSettingSource PickSlackChannel() => SlackChannel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackChannel' but the value was {ToString()}.");

        /// <summary>
        /// The value comes from a Slack workspace of the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? SlackWorkspace { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? SlackWorkspace { get; }
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
            out global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? value)
        {
            value = SlackWorkspace;
            return IsSlackWorkspace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource PickSlackWorkspace() => SlackWorkspace is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackWorkspace' but the value was {ToString()}.");

        /// <summary>
        /// The value comes from the channel that a code channel was started from. A parent channel contributes `instructions` and `environment_id` only.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? SlackParentChannel { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? SlackParentChannel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackParentChannel))]
#endif
        public bool IsSlackParentChannel => SlackParentChannel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlackParentChannel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? value)
        {
            value = SlackParentChannel;
            return IsSlackParentChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource PickSlackParentChannel() => SlackParentChannel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackParentChannel' but the value was {ToString()}.");

        /// <summary>
        /// The value comes from the organization's Slack defaults, which have no identifier.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? SlackDefault { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? SlackDefault { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackDefault))]
#endif
        public bool IsSlackDefault => SlackDefault != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlackDefault(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? value)
        {
            value = SlackDefault;
            return IsSlackDefault;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackDefaultSettingSource PickSlackDefault() => SlackDefault is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackDefault' but the value was {ToString()}.");

        /// <summary>
        /// No settings level sets a value, and the built-in default applies.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagDefaultSettingSource? Default { get; init; }
#else
        public global::Anthropic.BetaClaudeTagDefaultSettingSource? Default { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Default))]
#endif
        public bool IsDefault => Default != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDefault(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagDefaultSettingSource? value)
        {
            value = Default;
            return IsDefault;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagDefaultSettingSource PickDefault() => Default is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Default' but the value was {ToString()}.");

        /// <summary>
        /// The value comes from the addressed channel as it is set up under another workspace of its Enterprise Grid: a channel shared across the Grid keeps one Slack channel identifier in every workspace that sees it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? SlackGridChannel { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? SlackGridChannel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackGridChannel))]
#endif
        public bool IsSlackGridChannel => SlackGridChannel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlackGridChannel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? value)
        {
            value = SlackGridChannel;
            return IsSlackGridChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource PickSlackGridChannel() => SlackGridChannel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackGridChannel' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackChannelSettingSource value) => new BetaClaudeTagSettingSource((global::Anthropic.BetaClaudeTagSlackChannelSettingSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackChannelSettingSource?(BetaClaudeTagSettingSource @this) => @this.SlackChannel;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackChannelSettingSource? value)
        {
            SlackChannel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagSettingSource FromSlackChannel(global::Anthropic.BetaClaudeTagSlackChannelSettingSource? value) => new BetaClaudeTagSettingSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource value) => new BetaClaudeTagSettingSource((global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource?(BetaClaudeTagSettingSource @this) => @this.SlackWorkspace;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? value)
        {
            SlackWorkspace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagSettingSource FromSlackWorkspace(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? value) => new BetaClaudeTagSettingSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource value) => new BetaClaudeTagSettingSource((global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource?(BetaClaudeTagSettingSource @this) => @this.SlackParentChannel;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? value)
        {
            SlackParentChannel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagSettingSource FromSlackParentChannel(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? value) => new BetaClaudeTagSettingSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource value) => new BetaClaudeTagSettingSource((global::Anthropic.BetaClaudeTagSlackDefaultSettingSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackDefaultSettingSource?(BetaClaudeTagSettingSource @this) => @this.SlackDefault;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? value)
        {
            SlackDefault = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagSettingSource FromSlackDefault(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? value) => new BetaClaudeTagSettingSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagDefaultSettingSource value) => new BetaClaudeTagSettingSource((global::Anthropic.BetaClaudeTagDefaultSettingSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagDefaultSettingSource?(BetaClaudeTagSettingSource @this) => @this.Default;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagDefaultSettingSource? value)
        {
            Default = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagSettingSource FromDefault(global::Anthropic.BetaClaudeTagDefaultSettingSource? value) => new BetaClaudeTagSettingSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource value) => new BetaClaudeTagSettingSource((global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource?(BetaClaudeTagSettingSource @this) => @this.SlackGridChannel;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagSettingSource(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? value)
        {
            SlackGridChannel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagSettingSource FromSlackGridChannel(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? value) => new BetaClaudeTagSettingSource(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagSettingSource(
            global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType? type,
            global::Anthropic.BetaClaudeTagSlackChannelSettingSource? slackChannel,
            global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? slackWorkspace,
            global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? slackParentChannel,
            global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? slackDefault,
            global::Anthropic.BetaClaudeTagDefaultSettingSource? @default,
            global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? slackGridChannel
            )
        {
            Type = type;

            SlackChannel = slackChannel;
            SlackWorkspace = slackWorkspace;
            SlackParentChannel = slackParentChannel;
            SlackDefault = slackDefault;
            Default = @default;
            SlackGridChannel = slackGridChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SlackGridChannel as object ??
            Default as object ??
            SlackDefault as object ??
            SlackParentChannel as object ??
            SlackWorkspace as object ??
            SlackChannel as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SlackChannel?.ToString() ??
            SlackWorkspace?.ToString() ??
            SlackParentChannel?.ToString() ??
            SlackDefault?.ToString() ??
            Default?.ToString() ??
            SlackGridChannel?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSlackChannel && !IsSlackWorkspace && !IsSlackParentChannel && !IsSlackDefault && !IsDefault && !IsSlackGridChannel || !IsSlackChannel && IsSlackWorkspace && !IsSlackParentChannel && !IsSlackDefault && !IsDefault && !IsSlackGridChannel || !IsSlackChannel && !IsSlackWorkspace && IsSlackParentChannel && !IsSlackDefault && !IsDefault && !IsSlackGridChannel || !IsSlackChannel && !IsSlackWorkspace && !IsSlackParentChannel && IsSlackDefault && !IsDefault && !IsSlackGridChannel || !IsSlackChannel && !IsSlackWorkspace && !IsSlackParentChannel && !IsSlackDefault && IsDefault && !IsSlackGridChannel || !IsSlackChannel && !IsSlackWorkspace && !IsSlackParentChannel && !IsSlackDefault && !IsDefault && IsSlackGridChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeTagSlackChannelSettingSource, TResult>? slackChannel = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource, TResult>? slackWorkspace = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource, TResult>? slackParentChannel = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSlackDefaultSettingSource, TResult>? slackDefault = null,
            global::System.Func<global::Anthropic.BetaClaudeTagDefaultSettingSource, TResult>? @default = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource, TResult>? slackGridChannel = null,
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
            else if (SlackParentChannel is { } __value2 && slackParentChannel != null)
            {
                return slackParentChannel(__value2);
            }
            else if (SlackDefault is { } __value3 && slackDefault != null)
            {
                return slackDefault(__value3);
            }
            else if (Default is { } __value4 && @default != null)
            {
                return @default(__value4);
            }
            else if (SlackGridChannel is { } __value5 && slackGridChannel != null)
            {
                return slackGridChannel(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeTagSlackChannelSettingSource>? slackChannel = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource>? slackWorkspace = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource>? slackParentChannel = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSlackDefaultSettingSource>? slackDefault = null,

            global::System.Action<global::Anthropic.BetaClaudeTagDefaultSettingSource>? @default = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource>? slackGridChannel = null,
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
            else if (SlackParentChannel is { } __value2)
            {
                slackParentChannel?.Invoke(__value2);
            }
            else if (SlackDefault is { } __value3)
            {
                slackDefault?.Invoke(__value3);
            }
            else if (Default is { } __value4)
            {
                @default?.Invoke(__value4);
            }
            else if (SlackGridChannel is { } __value5)
            {
                slackGridChannel?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeTagSlackChannelSettingSource>? slackChannel = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource>? slackWorkspace = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource>? slackParentChannel = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSlackDefaultSettingSource>? slackDefault = null,
            global::System.Action<global::Anthropic.BetaClaudeTagDefaultSettingSource>? @default = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource>? slackGridChannel = null,
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
            else if (SlackParentChannel is { } __value2)
            {
                slackParentChannel?.Invoke(__value2);
            }
            else if (SlackDefault is { } __value3)
            {
                slackDefault?.Invoke(__value3);
            }
            else if (Default is { } __value4)
            {
                @default?.Invoke(__value4);
            }
            else if (SlackGridChannel is { } __value5)
            {
                slackGridChannel?.Invoke(__value5);
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
                typeof(global::Anthropic.BetaClaudeTagSlackChannelSettingSource),
                SlackWorkspace,
                typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource),
                SlackParentChannel,
                typeof(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource),
                SlackDefault,
                typeof(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource),
                Default,
                typeof(global::Anthropic.BetaClaudeTagDefaultSettingSource),
                SlackGridChannel,
                typeof(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource),
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
        public bool Equals(BetaClaudeTagSettingSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackChannelSettingSource?>.Default.Equals(SlackChannel, other.SlackChannel) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource?>.Default.Equals(SlackWorkspace, other.SlackWorkspace) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource?>.Default.Equals(SlackParentChannel, other.SlackParentChannel) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackDefaultSettingSource?>.Default.Equals(SlackDefault, other.SlackDefault) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagDefaultSettingSource?>.Default.Equals(Default, other.Default) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource?>.Default.Equals(SlackGridChannel, other.SlackGridChannel)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeTagSettingSource obj1, BetaClaudeTagSettingSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeTagSettingSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeTagSettingSource obj1, BetaClaudeTagSettingSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeTagSettingSource o && Equals(o);
        }
    }
}
