#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Names the resolved permission_policy that produced evaluated_permission, and under auto carries the judgement. Open union: clients must tolerate unknown variants.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentToolEvaluation : global::System.IEquatable<BetaManagedAgentsAgentToolEvaluation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminatorType? Type { get; }

        /// <summary>
        /// The resolved permission_policy was always_allow; accompanies evaluated_permission "allow".
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? AlwaysAllow { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? AlwaysAllow { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlwaysAllow))]
#endif
        public bool IsAlwaysAllow => AlwaysAllow != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlwaysAllow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? value)
        {
            value = AlwaysAllow;
            return IsAlwaysAllow;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow PickAlwaysAllow() => IsAlwaysAllow
            ? AlwaysAllow!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlwaysAllow' but the value was {ToString()}.");

        /// <summary>
        /// The resolved permission_policy was always_ask; accompanies evaluated_permission "ask".
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? AlwaysAsk { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? AlwaysAsk { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlwaysAsk))]
#endif
        public bool IsAlwaysAsk => AlwaysAsk != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlwaysAsk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? value)
        {
            value = AlwaysAsk;
            return IsAlwaysAsk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk PickAlwaysAsk() => IsAlwaysAsk
            ? AlwaysAsk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlwaysAsk' but the value was {ToString()}.");

        /// <summary>
        /// The resolved permission_policy was auto: the server judged this invocation individually.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? Auto { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? Auto { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAuto(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? value)
        {
            value = Auto;
            return IsAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto PickAuto() => IsAuto
            ? Auto!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Auto' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolEvaluation(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow value) => new BetaManagedAgentsAgentToolEvaluation((global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow?(BetaManagedAgentsAgentToolEvaluation @this) => @this.AlwaysAllow;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolEvaluation(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? value)
        {
            AlwaysAllow = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolEvaluation FromAlwaysAllow(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? value) => new BetaManagedAgentsAgentToolEvaluation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolEvaluation(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk value) => new BetaManagedAgentsAgentToolEvaluation((global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk?(BetaManagedAgentsAgentToolEvaluation @this) => @this.AlwaysAsk;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolEvaluation(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? value)
        {
            AlwaysAsk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolEvaluation FromAlwaysAsk(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? value) => new BetaManagedAgentsAgentToolEvaluation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolEvaluation(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto value) => new BetaManagedAgentsAgentToolEvaluation((global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto?(BetaManagedAgentsAgentToolEvaluation @this) => @this.Auto;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolEvaluation(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? value)
        {
            Auto = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolEvaluation FromAuto(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? value) => new BetaManagedAgentsAgentToolEvaluation(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolEvaluation(
            global::Anthropic.BetaManagedAgentsAgentToolEvaluationDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow? alwaysAllow,
            global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk? alwaysAsk,
            global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto? auto
            )
        {
            Type = type;

            AlwaysAllow = alwaysAllow;
            AlwaysAsk = alwaysAsk;
            Auto = auto;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Auto as object ??
            AlwaysAsk as object ??
            AlwaysAllow as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AlwaysAllow?.ToString() ??
            AlwaysAsk?.ToString() ??
            Auto?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAlwaysAllow && !IsAlwaysAsk && !IsAuto || !IsAlwaysAllow && IsAlwaysAsk && !IsAuto || !IsAlwaysAllow && !IsAlwaysAsk && IsAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow, TResult>? alwaysAllow = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk, TResult>? alwaysAsk = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto, TResult>? auto = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlwaysAllow && alwaysAllow != null)
            {
                return alwaysAllow(AlwaysAllow!);
            }
            else if (IsAlwaysAsk && alwaysAsk != null)
            {
                return alwaysAsk(AlwaysAsk!);
            }
            else if (IsAuto && auto != null)
            {
                return auto(Auto!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow>? alwaysAllow = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk>? alwaysAsk = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto>? auto = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlwaysAllow)
            {
                alwaysAllow?.Invoke(AlwaysAllow!);
            }
            else if (IsAlwaysAsk)
            {
                alwaysAsk?.Invoke(AlwaysAsk!);
            }
            else if (IsAuto)
            {
                auto?.Invoke(Auto!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow>? alwaysAllow = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk>? alwaysAsk = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto>? auto = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlwaysAllow)
            {
                alwaysAllow?.Invoke(AlwaysAllow!);
            }
            else if (IsAlwaysAsk)
            {
                alwaysAsk?.Invoke(AlwaysAsk!);
            }
            else if (IsAuto)
            {
                auto?.Invoke(Auto!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AlwaysAllow,
                typeof(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow),
                AlwaysAsk,
                typeof(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk),
                Auto,
                typeof(global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto),
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
        public bool Equals(BetaManagedAgentsAgentToolEvaluation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAllow?>.Default.Equals(AlwaysAllow, other.AlwaysAllow) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAlwaysAsk?>.Default.Equals(AlwaysAsk, other.AlwaysAsk) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentToolEvaluationAuto?>.Default.Equals(Auto, other.Auto)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentToolEvaluation obj1, BetaManagedAgentsAgentToolEvaluation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentToolEvaluation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentToolEvaluation obj1, BetaManagedAgentsAgentToolEvaluation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentToolEvaluation o && Equals(o);
        }
    }
}
