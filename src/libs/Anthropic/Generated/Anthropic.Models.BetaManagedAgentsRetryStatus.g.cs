#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the client should do next in response to this error.
    /// </summary>
    public readonly partial struct BetaManagedAgentsRetryStatus : global::System.IEquatable<BetaManagedAgentsRetryStatus>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// The server is retrying automatically. Client should wait; the same error type may fire again as retrying, then once as exhausted when the retry budget runs out.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRetryStatusRetrying? Retrying { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRetryStatusRetrying? Retrying { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Retrying))]
#endif
        public bool IsRetrying => Retrying != null;

        /// <summary>
        /// This turn is dead; queued inputs are flushed and the session returns to idle. Client may send a new prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRetryStatusExhausted? Exhausted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRetryStatusExhausted? Exhausted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exhausted))]
#endif
        public bool IsExhausted => Exhausted != null;

        /// <summary>
        /// The session encountered a terminal error and will transition to `terminated` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminal? Terminal { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRetryStatusTerminal? Terminal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Terminal))]
#endif
        public bool IsTerminal => Terminal != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRetryStatus(global::Anthropic.BetaManagedAgentsRetryStatusRetrying value) => new BetaManagedAgentsRetryStatus((global::Anthropic.BetaManagedAgentsRetryStatusRetrying?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRetryStatusRetrying?(BetaManagedAgentsRetryStatus @this) => @this.Retrying;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRetryStatus(global::Anthropic.BetaManagedAgentsRetryStatusRetrying? value)
        {
            Retrying = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRetryStatus(global::Anthropic.BetaManagedAgentsRetryStatusExhausted value) => new BetaManagedAgentsRetryStatus((global::Anthropic.BetaManagedAgentsRetryStatusExhausted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRetryStatusExhausted?(BetaManagedAgentsRetryStatus @this) => @this.Exhausted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRetryStatus(global::Anthropic.BetaManagedAgentsRetryStatusExhausted? value)
        {
            Exhausted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRetryStatus(global::Anthropic.BetaManagedAgentsRetryStatusTerminal value) => new BetaManagedAgentsRetryStatus((global::Anthropic.BetaManagedAgentsRetryStatusTerminal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRetryStatusTerminal?(BetaManagedAgentsRetryStatus @this) => @this.Terminal;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRetryStatus(global::Anthropic.BetaManagedAgentsRetryStatusTerminal? value)
        {
            Terminal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRetryStatus(
            global::Anthropic.BetaManagedAgentsRetryStatusDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsRetryStatusRetrying? retrying,
            global::Anthropic.BetaManagedAgentsRetryStatusExhausted? exhausted,
            global::Anthropic.BetaManagedAgentsRetryStatusTerminal? terminal
            )
        {
            Type = type;

            Retrying = retrying;
            Exhausted = exhausted;
            Terminal = terminal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Terminal as object ??
            Exhausted as object ??
            Retrying as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Retrying?.ToString() ??
            Exhausted?.ToString() ??
            Terminal?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRetrying && !IsExhausted && !IsTerminal || !IsRetrying && IsExhausted && !IsTerminal || !IsRetrying && !IsExhausted && IsTerminal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsRetryStatusRetrying?, TResult>? retrying = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRetryStatusExhausted?, TResult>? exhausted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRetryStatusTerminal?, TResult>? terminal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRetrying && retrying != null)
            {
                return retrying(Retrying!);
            }
            else if (IsExhausted && exhausted != null)
            {
                return exhausted(Exhausted!);
            }
            else if (IsTerminal && terminal != null)
            {
                return terminal(Terminal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsRetryStatusRetrying?>? retrying = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRetryStatusExhausted?>? exhausted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRetryStatusTerminal?>? terminal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRetrying)
            {
                retrying?.Invoke(Retrying!);
            }
            else if (IsExhausted)
            {
                exhausted?.Invoke(Exhausted!);
            }
            else if (IsTerminal)
            {
                terminal?.Invoke(Terminal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Retrying,
                typeof(global::Anthropic.BetaManagedAgentsRetryStatusRetrying),
                Exhausted,
                typeof(global::Anthropic.BetaManagedAgentsRetryStatusExhausted),
                Terminal,
                typeof(global::Anthropic.BetaManagedAgentsRetryStatusTerminal),
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
        public bool Equals(BetaManagedAgentsRetryStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRetryStatusRetrying?>.Default.Equals(Retrying, other.Retrying) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRetryStatusExhausted?>.Default.Equals(Exhausted, other.Exhausted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRetryStatusTerminal?>.Default.Equals(Terminal, other.Terminal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsRetryStatus obj1, BetaManagedAgentsRetryStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsRetryStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsRetryStatus obj1, BetaManagedAgentsRetryStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsRetryStatus o && Equals(o);
        }
    }
}
