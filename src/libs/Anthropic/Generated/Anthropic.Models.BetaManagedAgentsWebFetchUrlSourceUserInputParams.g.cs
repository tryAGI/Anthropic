#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether URLs in the text of user messages may be fetched. Accepts the string "all" or "none", or the object {"type": "all"} or {"type": "none"}. Responses use the object form.
    /// </summary>
    public readonly partial struct BetaManagedAgentsWebFetchUrlSourceUserInputParams : global::System.IEquatable<BetaManagedAgentsWebFetchUrlSourceUserInputParams>
    {
        /// <summary>
        /// String form of a url_sources value that has no field other than its type: "all" means {"type": "all"} and "none" means {"type": "none"}.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Shorthand { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? Shorthand { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shorthand))]
#endif
        public bool IsShorthand => Shorthand != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShorthand(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? value)
        {
            value = Shorthand;
            return IsShorthand;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand PickShorthand() => Shorthand is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shorthand' but the value was {ToString()}.");

        /// <summary>
        /// Whether URLs in the text of user messages may be fetched.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? BetaManagedAgentsWebFetchUrlSourceUserInput { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? BetaManagedAgentsWebFetchUrlSourceUserInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsWebFetchUrlSourceUserInput))]
#endif
        public bool IsBetaManagedAgentsWebFetchUrlSourceUserInput => BetaManagedAgentsWebFetchUrlSourceUserInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsWebFetchUrlSourceUserInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? value)
        {
            value = BetaManagedAgentsWebFetchUrlSourceUserInput;
            return IsBetaManagedAgentsWebFetchUrlSourceUserInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput PickBetaManagedAgentsWebFetchUrlSourceUserInput() => BetaManagedAgentsWebFetchUrlSourceUserInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsWebFetchUrlSourceUserInput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceUserInputParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand value) => new BetaManagedAgentsWebFetchUrlSourceUserInputParams((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?(BetaManagedAgentsWebFetchUrlSourceUserInputParams @this) => @this.Shorthand;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceUserInputParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? value)
        {
            Shorthand = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceUserInputParams FromShorthand(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? value) => new BetaManagedAgentsWebFetchUrlSourceUserInputParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceUserInputParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput value) => new BetaManagedAgentsWebFetchUrlSourceUserInputParams((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput?(BetaManagedAgentsWebFetchUrlSourceUserInputParams @this) => @this.BetaManagedAgentsWebFetchUrlSourceUserInput;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceUserInputParams(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? value)
        {
            BetaManagedAgentsWebFetchUrlSourceUserInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceUserInputParams FromBetaManagedAgentsWebFetchUrlSourceUserInput(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? value) => new BetaManagedAgentsWebFetchUrlSourceUserInputParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceUserInputParams(
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand? shorthand,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput? betaManagedAgentsWebFetchUrlSourceUserInput
            )
        {
            Shorthand = shorthand;
            BetaManagedAgentsWebFetchUrlSourceUserInput = betaManagedAgentsWebFetchUrlSourceUserInput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaManagedAgentsWebFetchUrlSourceUserInput as object ??
            Shorthand as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shorthand?.ToValueString() ??
            BetaManagedAgentsWebFetchUrlSourceUserInput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShorthand && !IsBetaManagedAgentsWebFetchUrlSourceUserInput || !IsShorthand && IsBetaManagedAgentsWebFetchUrlSourceUserInput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?, TResult>? shorthand = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput?, TResult>? betaManagedAgentsWebFetchUrlSourceUserInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shorthand is { } __value0 && shorthand != null)
            {
                return shorthand(__value0);
            }
            else if (BetaManagedAgentsWebFetchUrlSourceUserInput is { } __value1 && betaManagedAgentsWebFetchUrlSourceUserInput != null)
            {
                return betaManagedAgentsWebFetchUrlSourceUserInput(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?>? shorthand = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput?>? betaManagedAgentsWebFetchUrlSourceUserInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shorthand is { } __value0)
            {
                shorthand?.Invoke(__value0);
            }
            else if (BetaManagedAgentsWebFetchUrlSourceUserInput is { } __value1)
            {
                betaManagedAgentsWebFetchUrlSourceUserInput?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?>? shorthand = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput?>? betaManagedAgentsWebFetchUrlSourceUserInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shorthand is { } __value0)
            {
                shorthand?.Invoke(__value0);
            }
            else if (BetaManagedAgentsWebFetchUrlSourceUserInput is { } __value1)
            {
                betaManagedAgentsWebFetchUrlSourceUserInput?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shorthand,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand),
                BetaManagedAgentsWebFetchUrlSourceUserInput,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput),
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
        public bool Equals(BetaManagedAgentsWebFetchUrlSourceUserInputParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceShorthand?>.Default.Equals(Shorthand, other.Shorthand) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInput?>.Default.Equals(BetaManagedAgentsWebFetchUrlSourceUserInput, other.BetaManagedAgentsWebFetchUrlSourceUserInput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsWebFetchUrlSourceUserInputParams obj1, BetaManagedAgentsWebFetchUrlSourceUserInputParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsWebFetchUrlSourceUserInputParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsWebFetchUrlSourceUserInputParams obj1, BetaManagedAgentsWebFetchUrlSourceUserInputParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsWebFetchUrlSourceUserInputParams o && Equals(o);
        }
    }
}
