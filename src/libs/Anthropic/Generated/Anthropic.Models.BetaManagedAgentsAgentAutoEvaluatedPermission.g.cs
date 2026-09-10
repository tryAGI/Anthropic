#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The server's per-invocation judgement under the auto permission policy. Its type always equals the event's top-level evaluated_permission. Open union: clients must tolerate unknown variants.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentAutoEvaluatedPermission : global::System.IEquatable<BetaManagedAgentsAgentAutoEvaluatedPermission>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? Type { get; }

        /// <summary>
        /// The server judged the invocation safe to execute without client approval.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? Allow { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? Allow { get; }
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
            out global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? value)
        {
            value = Allow;
            return IsAllow;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow PickAllow() => IsAllow
            ? Allow!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Allow' but the value was {ToString()}.");

        /// <summary>
        /// The server reached no judgement; the invocation is held for client approval.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? Ask { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? Ask { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ask))]
#endif
        public bool IsAsk => Ask != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? value)
        {
            value = Ask;
            return IsAsk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk PickAsk() => IsAsk
            ? Ask!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ask' but the value was {ToString()}.");

        /// <summary>
        /// The server judged the invocation high-risk; it does not execute and a synthetic error tool result is appended.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? Deny { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? Deny { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deny))]
#endif
        public bool IsDeny => Deny != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeny(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? value)
        {
            value = Deny;
            return IsDeny;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny PickDeny() => IsDeny
            ? Deny!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deny' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentAutoEvaluatedPermission(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow value) => new BetaManagedAgentsAgentAutoEvaluatedPermission((global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow?(BetaManagedAgentsAgentAutoEvaluatedPermission @this) => @this.Allow;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentAutoEvaluatedPermission(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? value)
        {
            Allow = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentAutoEvaluatedPermission FromAllow(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? value) => new BetaManagedAgentsAgentAutoEvaluatedPermission(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentAutoEvaluatedPermission(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk value) => new BetaManagedAgentsAgentAutoEvaluatedPermission((global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk?(BetaManagedAgentsAgentAutoEvaluatedPermission @this) => @this.Ask;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentAutoEvaluatedPermission(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? value)
        {
            Ask = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentAutoEvaluatedPermission FromAsk(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? value) => new BetaManagedAgentsAgentAutoEvaluatedPermission(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentAutoEvaluatedPermission(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny value) => new BetaManagedAgentsAgentAutoEvaluatedPermission((global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny?(BetaManagedAgentsAgentAutoEvaluatedPermission @this) => @this.Deny;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentAutoEvaluatedPermission(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? value)
        {
            Deny = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentAutoEvaluatedPermission FromDeny(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? value) => new BetaManagedAgentsAgentAutoEvaluatedPermission(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentAutoEvaluatedPermission(
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? allow,
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? ask,
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? deny
            )
        {
            Type = type;

            Allow = allow;
            Ask = ask;
            Deny = deny;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Deny as object ??
            Ask as object ??
            Allow as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Allow?.ToString() ??
            Ask?.ToString() ??
            Deny?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAllow && !IsAsk && !IsDeny || !IsAllow && IsAsk && !IsDeny || !IsAllow && !IsAsk && IsDeny;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow, TResult>? allow = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk, TResult>? ask = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny, TResult>? deny = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllow && allow != null)
            {
                return allow(Allow!);
            }
            else if (IsAsk && ask != null)
            {
                return ask(Ask!);
            }
            else if (IsDeny && deny != null)
            {
                return deny(Deny!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow>? allow = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk>? ask = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny>? deny = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllow)
            {
                allow?.Invoke(Allow!);
            }
            else if (IsAsk)
            {
                ask?.Invoke(Ask!);
            }
            else if (IsDeny)
            {
                deny?.Invoke(Deny!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow>? allow = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk>? ask = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny>? deny = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllow)
            {
                allow?.Invoke(Allow!);
            }
            else if (IsAsk)
            {
                ask?.Invoke(Ask!);
            }
            else if (IsDeny)
            {
                deny?.Invoke(Deny!);
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
                typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow),
                Ask,
                typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk),
                Deny,
                typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny),
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
        public bool Equals(BetaManagedAgentsAgentAutoEvaluatedPermission other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow?>.Default.Equals(Allow, other.Allow) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk?>.Default.Equals(Ask, other.Ask) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny?>.Default.Equals(Deny, other.Deny)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentAutoEvaluatedPermission obj1, BetaManagedAgentsAgentAutoEvaluatedPermission obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentAutoEvaluatedPermission>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentAutoEvaluatedPermission obj1, BetaManagedAgentsAgentAutoEvaluatedPermission obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentAutoEvaluatedPermission o && Equals(o);
        }
    }
}
