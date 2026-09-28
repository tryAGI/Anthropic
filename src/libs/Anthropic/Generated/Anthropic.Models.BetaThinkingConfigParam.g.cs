#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for enabling Claude's extended thinking.<br/>
    /// When enabled, responses include `thinking` content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your `max_tokens` limit.<br/>
    /// See [extended thinking](https://platform.claude.com/docs/en/build-with-claude/extended-thinking) for details.
    /// </summary>
    public readonly partial struct BetaThinkingConfigParam : global::System.IEquatable<BetaThinkingConfigParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingConfigEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaThinkingConfigEnabled? Enabled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enabled))]
#endif
        public bool IsEnabled => Enabled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThinkingConfigEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingConfigDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaThinkingConfigDisabled? Disabled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDisabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThinkingConfigDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingConfigBetweenTools? BetweenTools { get; init; }
#else
        public global::Anthropic.BetaThinkingConfigBetweenTools? BetweenTools { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetweenTools))]
#endif
        public bool IsBetweenTools => BetweenTools != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetweenTools(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThinkingConfigBetweenTools? value)
        {
            value = BetweenTools;
            return IsBetweenTools;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigBetweenTools PickBetweenTools() => BetweenTools is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetweenTools' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingConfigAdaptive? Adaptive { get; init; }
#else
        public global::Anthropic.BetaThinkingConfigAdaptive? Adaptive { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Adaptive))]
#endif
        public bool IsAdaptive => Adaptive != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAdaptive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaThinkingConfigAdaptive? value)
        {
            value = Adaptive;
            return IsAdaptive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaThinkingConfigAdaptive PickAdaptive() => Adaptive is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Adaptive' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigEnabled value) => new BetaThinkingConfigParam((global::Anthropic.BetaThinkingConfigEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingConfigEnabled?(BetaThinkingConfigParam @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaThinkingConfigParam FromEnabled(global::Anthropic.BetaThinkingConfigEnabled? value) => new BetaThinkingConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigDisabled value) => new BetaThinkingConfigParam((global::Anthropic.BetaThinkingConfigDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingConfigDisabled?(BetaThinkingConfigParam @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaThinkingConfigParam FromDisabled(global::Anthropic.BetaThinkingConfigDisabled? value) => new BetaThinkingConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigBetweenTools value) => new BetaThinkingConfigParam((global::Anthropic.BetaThinkingConfigBetweenTools?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingConfigBetweenTools?(BetaThinkingConfigParam @this) => @this.BetweenTools;

        /// <summary>
        ///
        /// </summary>
        public BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigBetweenTools? value)
        {
            BetweenTools = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaThinkingConfigParam FromBetweenTools(global::Anthropic.BetaThinkingConfigBetweenTools? value) => new BetaThinkingConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigAdaptive value) => new BetaThinkingConfigParam((global::Anthropic.BetaThinkingConfigAdaptive?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingConfigAdaptive?(BetaThinkingConfigParam @this) => @this.Adaptive;

        /// <summary>
        ///
        /// </summary>
        public BetaThinkingConfigParam(global::Anthropic.BetaThinkingConfigAdaptive? value)
        {
            Adaptive = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaThinkingConfigParam FromAdaptive(global::Anthropic.BetaThinkingConfigAdaptive? value) => new BetaThinkingConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public BetaThinkingConfigParam(
            global::Anthropic.BetaThinkingConfigParamDiscriminatorType? type,
            global::Anthropic.BetaThinkingConfigEnabled? enabled,
            global::Anthropic.BetaThinkingConfigDisabled? disabled,
            global::Anthropic.BetaThinkingConfigBetweenTools? betweenTools,
            global::Anthropic.BetaThinkingConfigAdaptive? adaptive
            )
        {
            Type = type;

            Enabled = enabled;
            Disabled = disabled;
            BetweenTools = betweenTools;
            Adaptive = adaptive;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Adaptive as object ??
            BetweenTools as object ??
            Disabled as object ??
            Enabled as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enabled?.ToString() ??
            Disabled?.ToString() ??
            BetweenTools?.ToString() ??
            Adaptive?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnabled && !IsDisabled && !IsBetweenTools && !IsAdaptive || !IsEnabled && IsDisabled && !IsBetweenTools && !IsAdaptive || !IsEnabled && !IsDisabled && IsBetweenTools && !IsAdaptive || !IsEnabled && !IsDisabled && !IsBetweenTools && IsAdaptive;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaThinkingConfigEnabled, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaThinkingConfigDisabled, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaThinkingConfigBetweenTools, TResult>? betweenTools = null,
            global::System.Func<global::Anthropic.BetaThinkingConfigAdaptive, TResult>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enabled is { } __value0 && enabled != null)
            {
                return enabled(__value0);
            }
            else if (Disabled is { } __value1 && disabled != null)
            {
                return disabled(__value1);
            }
            else if (BetweenTools is { } __value2 && betweenTools != null)
            {
                return betweenTools(__value2);
            }
            else if (Adaptive is { } __value3 && adaptive != null)
            {
                return adaptive(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaThinkingConfigEnabled>? enabled = null,

            global::System.Action<global::Anthropic.BetaThinkingConfigDisabled>? disabled = null,

            global::System.Action<global::Anthropic.BetaThinkingConfigBetweenTools>? betweenTools = null,

            global::System.Action<global::Anthropic.BetaThinkingConfigAdaptive>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enabled is { } __value0)
            {
                enabled?.Invoke(__value0);
            }
            else if (Disabled is { } __value1)
            {
                disabled?.Invoke(__value1);
            }
            else if (BetweenTools is { } __value2)
            {
                betweenTools?.Invoke(__value2);
            }
            else if (Adaptive is { } __value3)
            {
                adaptive?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaThinkingConfigEnabled>? enabled = null,
            global::System.Action<global::Anthropic.BetaThinkingConfigDisabled>? disabled = null,
            global::System.Action<global::Anthropic.BetaThinkingConfigBetweenTools>? betweenTools = null,
            global::System.Action<global::Anthropic.BetaThinkingConfigAdaptive>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enabled is { } __value0)
            {
                enabled?.Invoke(__value0);
            }
            else if (Disabled is { } __value1)
            {
                disabled?.Invoke(__value1);
            }
            else if (BetweenTools is { } __value2)
            {
                betweenTools?.Invoke(__value2);
            }
            else if (Adaptive is { } __value3)
            {
                adaptive?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enabled,
                typeof(global::Anthropic.BetaThinkingConfigEnabled),
                Disabled,
                typeof(global::Anthropic.BetaThinkingConfigDisabled),
                BetweenTools,
                typeof(global::Anthropic.BetaThinkingConfigBetweenTools),
                Adaptive,
                typeof(global::Anthropic.BetaThinkingConfigAdaptive),
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
        public bool Equals(BetaThinkingConfigParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingConfigEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingConfigDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingConfigBetweenTools?>.Default.Equals(BetweenTools, other.BetweenTools) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingConfigAdaptive?>.Default.Equals(Adaptive, other.Adaptive)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaThinkingConfigParam obj1, BetaThinkingConfigParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaThinkingConfigParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaThinkingConfigParam obj1, BetaThinkingConfigParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaThinkingConfigParam o && Equals(o);
        }
    }
}
