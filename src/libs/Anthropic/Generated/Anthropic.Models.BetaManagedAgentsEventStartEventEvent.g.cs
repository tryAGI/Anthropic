#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsEventStartEventEvent : global::System.IEquatable<BetaManagedAgentsEventStartEventEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? AgentMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? AgentMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessage))]
#endif
        public bool IsAgentMessage => AgentMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? value)
        {
            value = AgentMessage;
            return IsAgentMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview PickAgentMessage() => IsAgentMessage
            ? AgentMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessage' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? AgentThinking { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? AgentThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinking))]
#endif
        public bool IsAgentThinking => AgentThinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? value)
        {
            value = AgentThinking;
            return IsAgentThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview PickAgentThinking() => IsAgentThinking
            ? AgentThinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentThinking' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEventStartEventEvent(global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview value) => new BetaManagedAgentsEventStartEventEvent((global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview?(BetaManagedAgentsEventStartEventEvent @this) => @this.AgentMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventStartEventEvent(global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? value)
        {
            AgentMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventStartEventEvent FromAgentMessage(global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? value) => new BetaManagedAgentsEventStartEventEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEventStartEventEvent(global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview value) => new BetaManagedAgentsEventStartEventEvent((global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview?(BetaManagedAgentsEventStartEventEvent @this) => @this.AgentThinking;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventStartEventEvent(global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? value)
        {
            AgentThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventStartEventEvent FromAgentThinking(global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? value) => new BetaManagedAgentsEventStartEventEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventStartEventEvent(
            global::Anthropic.BetaManagedAgentsEventStartEventEventDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview? agentMessage,
            global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview? agentThinking
            )
        {
            Type = type;

            AgentMessage = agentMessage;
            AgentThinking = agentThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentThinking as object ??
            AgentMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentMessage?.ToString() ??
            AgentThinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentMessage && !IsAgentThinking || !IsAgentMessage && IsAgentThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview, TResult>? agentMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview, TResult>? agentThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentMessage && agentMessage != null)
            {
                return agentMessage(AgentMessage!);
            }
            else if (IsAgentThinking && agentThinking != null)
            {
                return agentThinking(AgentThinking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview>? agentMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview>? agentThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsAgentThinking)
            {
                agentThinking?.Invoke(AgentThinking!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview>? agentMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview>? agentThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsAgentThinking)
            {
                agentThinking?.Invoke(AgentThinking!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentMessage,
                typeof(global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview),
                AgentThinking,
                typeof(global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview),
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
        public bool Equals(BetaManagedAgentsEventStartEventEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEventStartEventAgentMessagePreview?>.Default.Equals(AgentMessage, other.AgentMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEventStartEventAgentThinkingPreview?>.Default.Equals(AgentThinking, other.AgentThinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsEventStartEventEvent obj1, BetaManagedAgentsEventStartEventEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsEventStartEventEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsEventStartEventEvent obj1, BetaManagedAgentsEventStartEventEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsEventStartEventEvent o && Equals(o);
        }
    }
}
