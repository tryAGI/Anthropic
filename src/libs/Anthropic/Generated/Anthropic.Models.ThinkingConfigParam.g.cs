#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for enabling Claude's extended thinking.<br/>
    /// When enabled, responses include `thinking` content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your `max_tokens` limit.<br/>
    /// See [extended thinking](https://docs.claude.com/en/docs/build-with-claude/extended-thinking) for details.
    /// </summary>
    public readonly partial struct ThinkingConfigParam : global::System.IEquatable<ThinkingConfigParam>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ThinkingConfigParamDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ThinkingConfigEnabled? Enabled { get; init; }
#else
        public global::Anthropic.ThinkingConfigEnabled? Enabled { get; }
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
#if NET6_0_OR_GREATER
        public global::Anthropic.ThinkingConfigDisabled? Disabled { get; init; }
#else
        public global::Anthropic.ThinkingConfigDisabled? Disabled { get; }
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
#if NET6_0_OR_GREATER
        public global::Anthropic.ThinkingConfigAdaptive? Adaptive { get; init; }
#else
        public global::Anthropic.ThinkingConfigAdaptive? Adaptive { get; }
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
        public static implicit operator ThinkingConfigParam(global::Anthropic.ThinkingConfigEnabled value) => new ThinkingConfigParam((global::Anthropic.ThinkingConfigEnabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ThinkingConfigEnabled?(ThinkingConfigParam @this) => @this.Enabled;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingConfigParam(global::Anthropic.ThinkingConfigEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingConfigParam(global::Anthropic.ThinkingConfigDisabled value) => new ThinkingConfigParam((global::Anthropic.ThinkingConfigDisabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ThinkingConfigDisabled?(ThinkingConfigParam @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingConfigParam(global::Anthropic.ThinkingConfigDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingConfigParam(global::Anthropic.ThinkingConfigAdaptive value) => new ThinkingConfigParam((global::Anthropic.ThinkingConfigAdaptive?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ThinkingConfigAdaptive?(ThinkingConfigParam @this) => @this.Adaptive;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingConfigParam(global::Anthropic.ThinkingConfigAdaptive? value)
        {
            Adaptive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ThinkingConfigParam(
            global::Anthropic.ThinkingConfigParamDiscriminatorType? type,
            global::Anthropic.ThinkingConfigEnabled? enabled,
            global::Anthropic.ThinkingConfigDisabled? disabled,
            global::Anthropic.ThinkingConfigAdaptive? adaptive
            )
        {
            Type = type;

            Enabled = enabled;
            Disabled = disabled;
            Adaptive = adaptive;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Adaptive as object ??
            Disabled as object ??
            Enabled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enabled?.ToString() ??
            Disabled?.ToString() ??
            Adaptive?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnabled && !IsDisabled && !IsAdaptive || !IsEnabled && IsDisabled && !IsAdaptive || !IsEnabled && !IsDisabled && IsAdaptive;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ThinkingConfigEnabled?, TResult>? enabled = null,
            global::System.Func<global::Anthropic.ThinkingConfigDisabled?, TResult>? disabled = null,
            global::System.Func<global::Anthropic.ThinkingConfigAdaptive?, TResult>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnabled && enabled != null)
            {
                return enabled(Enabled!);
            }
            else if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }
            else if (IsAdaptive && adaptive != null)
            {
                return adaptive(Adaptive!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ThinkingConfigEnabled?>? enabled = null,
            global::System.Action<global::Anthropic.ThinkingConfigDisabled?>? disabled = null,
            global::System.Action<global::Anthropic.ThinkingConfigAdaptive?>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnabled)
            {
                enabled?.Invoke(Enabled!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsAdaptive)
            {
                adaptive?.Invoke(Adaptive!);
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
                typeof(global::Anthropic.ThinkingConfigEnabled),
                Disabled,
                typeof(global::Anthropic.ThinkingConfigDisabled),
                Adaptive,
                typeof(global::Anthropic.ThinkingConfigAdaptive),
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
        public bool Equals(ThinkingConfigParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ThinkingConfigEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ThinkingConfigDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ThinkingConfigAdaptive?>.Default.Equals(Adaptive, other.Adaptive) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThinkingConfigParam obj1, ThinkingConfigParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThinkingConfigParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThinkingConfigParam obj1, ThinkingConfigParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThinkingConfigParam o && Equals(o);
        }
    }
}
