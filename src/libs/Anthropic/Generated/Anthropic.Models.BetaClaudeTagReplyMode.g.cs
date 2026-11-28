#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How Claude takes part in a Slack channel. A channel alone stores one. More types can be added.
    /// </summary>
    public readonly partial struct BetaClaudeTagReplyMode : global::System.IEquatable<BetaClaudeTagReplyMode>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeDiscriminatorType? Type { get; }

        /// <summary>
        /// Claude reads along and joins in when it can help, and pauses on its own in quiet or busy channels.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagReplyModeAutomatic? Automatic { get; init; }
#else
        public global::Anthropic.BetaClaudeTagReplyModeAutomatic? Automatic { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Automatic))]
#endif
        public bool IsAutomatic => Automatic != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutomatic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagReplyModeAutomatic? value)
        {
            value = Automatic;
            return IsAutomatic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeAutomatic PickAutomatic() => Automatic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Automatic' but the value was {ToString()}.");

        /// <summary>
        /// Claude replies only when it is @-mentioned.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagReplyModeMentionOnly? MentionOnly { get; init; }
#else
        public global::Anthropic.BetaClaudeTagReplyModeMentionOnly? MentionOnly { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MentionOnly))]
#endif
        public bool IsMentionOnly => MentionOnly != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMentionOnly(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagReplyModeMentionOnly? value)
        {
            value = MentionOnly;
            return IsMentionOnly;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeMentionOnly PickMentionOnly() => MentionOnly is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MentionOnly' but the value was {ToString()}.");

        /// <summary>
        /// Like `automatic`, but Claude never pauses on its own. Available where it is enabled for the channel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? AlwaysAwake { get; init; }
#else
        public global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? AlwaysAwake { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlwaysAwake))]
#endif
        public bool IsAlwaysAwake => AlwaysAwake != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlwaysAwake(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? value)
        {
            value = AlwaysAwake;
            return IsAlwaysAwake;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake PickAlwaysAwake() => AlwaysAwake is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlwaysAwake' but the value was {ToString()}.");

        /// <summary>
        /// Every new top-level message in the channel gets its own reply from Claude, in a thread under it. Available where it is enabled for the channel, and only once Claude has been used in the channel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagReplyModeThread? Thread { get; init; }
#else
        public global::Anthropic.BetaClaudeTagReplyModeThread? Thread { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thread))]
#endif
        public bool IsThread => Thread != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThread(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagReplyModeThread? value)
        {
            value = Thread;
            return IsThread;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagReplyModeThread PickThread() => Thread is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thread' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeAutomatic value) => new BetaClaudeTagReplyMode((global::Anthropic.BetaClaudeTagReplyModeAutomatic?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagReplyModeAutomatic?(BetaClaudeTagReplyMode @this) => @this.Automatic;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeAutomatic? value)
        {
            Automatic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagReplyMode FromAutomatic(global::Anthropic.BetaClaudeTagReplyModeAutomatic? value) => new BetaClaudeTagReplyMode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeMentionOnly value) => new BetaClaudeTagReplyMode((global::Anthropic.BetaClaudeTagReplyModeMentionOnly?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagReplyModeMentionOnly?(BetaClaudeTagReplyMode @this) => @this.MentionOnly;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeMentionOnly? value)
        {
            MentionOnly = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagReplyMode FromMentionOnly(global::Anthropic.BetaClaudeTagReplyModeMentionOnly? value) => new BetaClaudeTagReplyMode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake value) => new BetaClaudeTagReplyMode((global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake?(BetaClaudeTagReplyMode @this) => @this.AlwaysAwake;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? value)
        {
            AlwaysAwake = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagReplyMode FromAlwaysAwake(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? value) => new BetaClaudeTagReplyMode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeThread value) => new BetaClaudeTagReplyMode((global::Anthropic.BetaClaudeTagReplyModeThread?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagReplyModeThread?(BetaClaudeTagReplyMode @this) => @this.Thread;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagReplyMode(global::Anthropic.BetaClaudeTagReplyModeThread? value)
        {
            Thread = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagReplyMode FromThread(global::Anthropic.BetaClaudeTagReplyModeThread? value) => new BetaClaudeTagReplyMode(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagReplyMode(
            global::Anthropic.BetaClaudeTagReplyModeDiscriminatorType? type,
            global::Anthropic.BetaClaudeTagReplyModeAutomatic? automatic,
            global::Anthropic.BetaClaudeTagReplyModeMentionOnly? mentionOnly,
            global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? alwaysAwake,
            global::Anthropic.BetaClaudeTagReplyModeThread? thread
            )
        {
            Type = type;

            Automatic = automatic;
            MentionOnly = mentionOnly;
            AlwaysAwake = alwaysAwake;
            Thread = thread;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Thread as object ??
            AlwaysAwake as object ??
            MentionOnly as object ??
            Automatic as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Automatic?.ToString() ??
            MentionOnly?.ToString() ??
            AlwaysAwake?.ToString() ??
            Thread?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutomatic && !IsMentionOnly && !IsAlwaysAwake && !IsThread || !IsAutomatic && IsMentionOnly && !IsAlwaysAwake && !IsThread || !IsAutomatic && !IsMentionOnly && IsAlwaysAwake && !IsThread || !IsAutomatic && !IsMentionOnly && !IsAlwaysAwake && IsThread;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeTagReplyModeAutomatic, TResult>? automatic = null,
            global::System.Func<global::Anthropic.BetaClaudeTagReplyModeMentionOnly, TResult>? mentionOnly = null,
            global::System.Func<global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake, TResult>? alwaysAwake = null,
            global::System.Func<global::Anthropic.BetaClaudeTagReplyModeThread, TResult>? thread = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Automatic is { } __value0 && automatic != null)
            {
                return automatic(__value0);
            }
            else if (MentionOnly is { } __value1 && mentionOnly != null)
            {
                return mentionOnly(__value1);
            }
            else if (AlwaysAwake is { } __value2 && alwaysAwake != null)
            {
                return alwaysAwake(__value2);
            }
            else if (Thread is { } __value3 && thread != null)
            {
                return thread(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeAutomatic>? automatic = null,

            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeMentionOnly>? mentionOnly = null,

            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake>? alwaysAwake = null,

            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeThread>? thread = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Automatic is { } __value0)
            {
                automatic?.Invoke(__value0);
            }
            else if (MentionOnly is { } __value1)
            {
                mentionOnly?.Invoke(__value1);
            }
            else if (AlwaysAwake is { } __value2)
            {
                alwaysAwake?.Invoke(__value2);
            }
            else if (Thread is { } __value3)
            {
                thread?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeAutomatic>? automatic = null,
            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeMentionOnly>? mentionOnly = null,
            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake>? alwaysAwake = null,
            global::System.Action<global::Anthropic.BetaClaudeTagReplyModeThread>? thread = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Automatic is { } __value0)
            {
                automatic?.Invoke(__value0);
            }
            else if (MentionOnly is { } __value1)
            {
                mentionOnly?.Invoke(__value1);
            }
            else if (AlwaysAwake is { } __value2)
            {
                alwaysAwake?.Invoke(__value2);
            }
            else if (Thread is { } __value3)
            {
                thread?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Automatic,
                typeof(global::Anthropic.BetaClaudeTagReplyModeAutomatic),
                MentionOnly,
                typeof(global::Anthropic.BetaClaudeTagReplyModeMentionOnly),
                AlwaysAwake,
                typeof(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake),
                Thread,
                typeof(global::Anthropic.BetaClaudeTagReplyModeThread),
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
        public bool Equals(BetaClaudeTagReplyMode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagReplyModeAutomatic?>.Default.Equals(Automatic, other.Automatic) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagReplyModeMentionOnly?>.Default.Equals(MentionOnly, other.MentionOnly) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake?>.Default.Equals(AlwaysAwake, other.AlwaysAwake) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagReplyModeThread?>.Default.Equals(Thread, other.Thread)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeTagReplyMode obj1, BetaClaudeTagReplyMode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeTagReplyMode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeTagReplyMode obj1, BetaClaudeTagReplyMode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeTagReplyMode o && Equals(o);
        }
    }
}
