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
        public ThinkingConfigParam(
            global::Anthropic.ThinkingConfigParamDiscriminatorType? type,
            global::Anthropic.ThinkingConfigEnabled? enabled,
            global::Anthropic.ThinkingConfigDisabled? disabled
            )
        {
            Type = type;

            Enabled = enabled;
            Disabled = disabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Disabled as object ??
            Enabled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enabled?.ToString() ??
            Disabled?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnabled && !IsDisabled || !IsEnabled && IsDisabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ThinkingConfigEnabled?, TResult>? enabled = null,
            global::System.Func<global::Anthropic.ThinkingConfigDisabled?, TResult>? disabled = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ThinkingConfigEnabled?>? enabled = null,
            global::System.Action<global::Anthropic.ThinkingConfigDisabled?>? disabled = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ThinkingConfigDisabled?>.Default.Equals(Disabled, other.Disabled) 
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
