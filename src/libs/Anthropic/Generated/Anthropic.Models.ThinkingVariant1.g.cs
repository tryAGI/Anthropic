#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ThinkingVariant1 : global::System.IEquatable<ThinkingVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaFallbackConfigV2ThinkingVariant1DiscriminatorType? Type { get; }

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
        public global::Anthropic.BetaThinkingConfigEnabled PickEnabled() => IsEnabled
            ? Enabled!
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
        public global::Anthropic.BetaThinkingConfigDisabled PickDisabled() => IsDisabled
            ? Disabled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

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
        public global::Anthropic.BetaThinkingConfigAdaptive PickAdaptive() => IsAdaptive
            ? Adaptive!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Adaptive' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingVariant1(global::Anthropic.BetaThinkingConfigEnabled value) => new ThinkingVariant1((global::Anthropic.BetaThinkingConfigEnabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingConfigEnabled?(ThinkingVariant1 @this) => @this.Enabled;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingVariant1(global::Anthropic.BetaThinkingConfigEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ThinkingVariant1 FromEnabled(global::Anthropic.BetaThinkingConfigEnabled? value) => new ThinkingVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingVariant1(global::Anthropic.BetaThinkingConfigDisabled value) => new ThinkingVariant1((global::Anthropic.BetaThinkingConfigDisabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingConfigDisabled?(ThinkingVariant1 @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingVariant1(global::Anthropic.BetaThinkingConfigDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ThinkingVariant1 FromDisabled(global::Anthropic.BetaThinkingConfigDisabled? value) => new ThinkingVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThinkingVariant1(global::Anthropic.BetaThinkingConfigAdaptive value) => new ThinkingVariant1((global::Anthropic.BetaThinkingConfigAdaptive?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingConfigAdaptive?(ThinkingVariant1 @this) => @this.Adaptive;

        /// <summary>
        /// 
        /// </summary>
        public ThinkingVariant1(global::Anthropic.BetaThinkingConfigAdaptive? value)
        {
            Adaptive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ThinkingVariant1 FromAdaptive(global::Anthropic.BetaThinkingConfigAdaptive? value) => new ThinkingVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public ThinkingVariant1(
            global::Anthropic.BetaFallbackConfigV2ThinkingVariant1DiscriminatorType? type,
            global::Anthropic.BetaThinkingConfigEnabled? enabled,
            global::Anthropic.BetaThinkingConfigDisabled? disabled,
            global::Anthropic.BetaThinkingConfigAdaptive? adaptive
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
            global::System.Func<global::Anthropic.BetaThinkingConfigEnabled, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaThinkingConfigDisabled, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaThinkingConfigAdaptive, TResult>? adaptive = null,
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
            global::System.Action<global::Anthropic.BetaThinkingConfigEnabled>? enabled = null,

            global::System.Action<global::Anthropic.BetaThinkingConfigDisabled>? disabled = null,

            global::System.Action<global::Anthropic.BetaThinkingConfigAdaptive>? adaptive = null,
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
        public void Switch(
            global::System.Action<global::Anthropic.BetaThinkingConfigEnabled>? enabled = null,
            global::System.Action<global::Anthropic.BetaThinkingConfigDisabled>? disabled = null,
            global::System.Action<global::Anthropic.BetaThinkingConfigAdaptive>? adaptive = null,
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
                typeof(global::Anthropic.BetaThinkingConfigEnabled),
                Disabled,
                typeof(global::Anthropic.BetaThinkingConfigDisabled),
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
        public bool Equals(ThinkingVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingConfigEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingConfigDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingConfigAdaptive?>.Default.Equals(Adaptive, other.Adaptive) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThinkingVariant1 obj1, ThinkingVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThinkingVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThinkingVariant1 obj1, ThinkingVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThinkingVariant1 o && Equals(o);
        }
    }
}
