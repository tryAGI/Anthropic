#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model that will power your agent.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
    /// </summary>
    public readonly partial struct BetaManagedAgentsModel : global::System.IEquatable<BetaManagedAgentsModel>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant1 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant1))]
#endif
        public bool IsBetaManagedAgentsModelVariant1 => BetaManagedAgentsModelVariant1 != null;

        /// <summary>
        /// Frontier intelligence for long-running agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant2 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant2))]
#endif
        public bool IsBetaManagedAgentsModelVariant2 => BetaManagedAgentsModelVariant2 != null;

        /// <summary>
        /// Most intelligent model for building agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant3 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant3))]
#endif
        public bool IsBetaManagedAgentsModelVariant3 => BetaManagedAgentsModelVariant3 != null;

        /// <summary>
        /// Best combination of speed and intelligence
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant4 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant4))]
#endif
        public bool IsBetaManagedAgentsModelVariant4 => BetaManagedAgentsModelVariant4 != null;

        /// <summary>
        /// Fastest model with near-frontier intelligence
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant5 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant5))]
#endif
        public bool IsBetaManagedAgentsModelVariant5 => BetaManagedAgentsModelVariant5 != null;

        /// <summary>
        /// Fastest model with near-frontier intelligence
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant6 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant6))]
#endif
        public bool IsBetaManagedAgentsModelVariant6 => BetaManagedAgentsModelVariant6 != null;

        /// <summary>
        /// Premium model combining maximum intelligence with practical performance
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant7 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant7))]
#endif
        public bool IsBetaManagedAgentsModelVariant7 => BetaManagedAgentsModelVariant7 != null;

        /// <summary>
        /// Premium model combining maximum intelligence with practical performance
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant8 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant8))]
#endif
        public bool IsBetaManagedAgentsModelVariant8 => BetaManagedAgentsModelVariant8 != null;

        /// <summary>
        /// High-performance model for agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant9 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant9))]
#endif
        public bool IsBetaManagedAgentsModelVariant9 => BetaManagedAgentsModelVariant9 != null;

        /// <summary>
        /// High-performance model for agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant10 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant10))]
#endif
        public bool IsBetaManagedAgentsModelVariant10 => BetaManagedAgentsModelVariant10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsModel(string value) => new BetaManagedAgentsModel((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BetaManagedAgentsModel @this) => @this.BetaManagedAgentsModelVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsModel(string? value)
        {
            BetaManagedAgentsModelVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsModel(
            string? betaManagedAgentsModelVariant1,
            string? betaManagedAgentsModelVariant2,
            string? betaManagedAgentsModelVariant3,
            string? betaManagedAgentsModelVariant4,
            string? betaManagedAgentsModelVariant5,
            string? betaManagedAgentsModelVariant6,
            string? betaManagedAgentsModelVariant7,
            string? betaManagedAgentsModelVariant8,
            string? betaManagedAgentsModelVariant9,
            string? betaManagedAgentsModelVariant10
            )
        {
            BetaManagedAgentsModelVariant1 = betaManagedAgentsModelVariant1;
            BetaManagedAgentsModelVariant2 = betaManagedAgentsModelVariant2;
            BetaManagedAgentsModelVariant3 = betaManagedAgentsModelVariant3;
            BetaManagedAgentsModelVariant4 = betaManagedAgentsModelVariant4;
            BetaManagedAgentsModelVariant5 = betaManagedAgentsModelVariant5;
            BetaManagedAgentsModelVariant6 = betaManagedAgentsModelVariant6;
            BetaManagedAgentsModelVariant7 = betaManagedAgentsModelVariant7;
            BetaManagedAgentsModelVariant8 = betaManagedAgentsModelVariant8;
            BetaManagedAgentsModelVariant9 = betaManagedAgentsModelVariant9;
            BetaManagedAgentsModelVariant10 = betaManagedAgentsModelVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaManagedAgentsModelVariant10 as object ??
            BetaManagedAgentsModelVariant9 as object ??
            BetaManagedAgentsModelVariant8 as object ??
            BetaManagedAgentsModelVariant7 as object ??
            BetaManagedAgentsModelVariant6 as object ??
            BetaManagedAgentsModelVariant5 as object ??
            BetaManagedAgentsModelVariant4 as object ??
            BetaManagedAgentsModelVariant3 as object ??
            BetaManagedAgentsModelVariant2 as object ??
            BetaManagedAgentsModelVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BetaManagedAgentsModelVariant1?.ToString() ??
            BetaManagedAgentsModelVariant2?.ToString() ??
            BetaManagedAgentsModelVariant3?.ToString() ??
            BetaManagedAgentsModelVariant4?.ToString() ??
            BetaManagedAgentsModelVariant5?.ToString() ??
            BetaManagedAgentsModelVariant6?.ToString() ??
            BetaManagedAgentsModelVariant7?.ToString() ??
            BetaManagedAgentsModelVariant8?.ToString() ??
            BetaManagedAgentsModelVariant9?.ToString() ??
            BetaManagedAgentsModelVariant10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBetaManagedAgentsModelVariant1 || IsBetaManagedAgentsModelVariant2 || IsBetaManagedAgentsModelVariant3 || IsBetaManagedAgentsModelVariant4 || IsBetaManagedAgentsModelVariant5 || IsBetaManagedAgentsModelVariant6 || IsBetaManagedAgentsModelVariant7 || IsBetaManagedAgentsModelVariant8 || IsBetaManagedAgentsModelVariant9 || IsBetaManagedAgentsModelVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant1 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant2 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant3 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant4 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant5 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant6 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant7 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant8 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant9 = null,
            global::System.Func<string?, TResult>? betaManagedAgentsModelVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaManagedAgentsModelVariant1 && betaManagedAgentsModelVariant1 != null)
            {
                return betaManagedAgentsModelVariant1(BetaManagedAgentsModelVariant1!);
            }
            else if (IsBetaManagedAgentsModelVariant2 && betaManagedAgentsModelVariant2 != null)
            {
                return betaManagedAgentsModelVariant2(BetaManagedAgentsModelVariant2!);
            }
            else if (IsBetaManagedAgentsModelVariant3 && betaManagedAgentsModelVariant3 != null)
            {
                return betaManagedAgentsModelVariant3(BetaManagedAgentsModelVariant3!);
            }
            else if (IsBetaManagedAgentsModelVariant4 && betaManagedAgentsModelVariant4 != null)
            {
                return betaManagedAgentsModelVariant4(BetaManagedAgentsModelVariant4!);
            }
            else if (IsBetaManagedAgentsModelVariant5 && betaManagedAgentsModelVariant5 != null)
            {
                return betaManagedAgentsModelVariant5(BetaManagedAgentsModelVariant5!);
            }
            else if (IsBetaManagedAgentsModelVariant6 && betaManagedAgentsModelVariant6 != null)
            {
                return betaManagedAgentsModelVariant6(BetaManagedAgentsModelVariant6!);
            }
            else if (IsBetaManagedAgentsModelVariant7 && betaManagedAgentsModelVariant7 != null)
            {
                return betaManagedAgentsModelVariant7(BetaManagedAgentsModelVariant7!);
            }
            else if (IsBetaManagedAgentsModelVariant8 && betaManagedAgentsModelVariant8 != null)
            {
                return betaManagedAgentsModelVariant8(BetaManagedAgentsModelVariant8!);
            }
            else if (IsBetaManagedAgentsModelVariant9 && betaManagedAgentsModelVariant9 != null)
            {
                return betaManagedAgentsModelVariant9(BetaManagedAgentsModelVariant9!);
            }
            else if (IsBetaManagedAgentsModelVariant10 && betaManagedAgentsModelVariant10 != null)
            {
                return betaManagedAgentsModelVariant10(BetaManagedAgentsModelVariant10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? betaManagedAgentsModelVariant1 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant2 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant3 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant4 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant5 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant6 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant7 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant8 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant9 = null,
            global::System.Action<string?>? betaManagedAgentsModelVariant10 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaManagedAgentsModelVariant1)
            {
                betaManagedAgentsModelVariant1?.Invoke(BetaManagedAgentsModelVariant1!);
            }
            else if (IsBetaManagedAgentsModelVariant2)
            {
                betaManagedAgentsModelVariant2?.Invoke(BetaManagedAgentsModelVariant2!);
            }
            else if (IsBetaManagedAgentsModelVariant3)
            {
                betaManagedAgentsModelVariant3?.Invoke(BetaManagedAgentsModelVariant3!);
            }
            else if (IsBetaManagedAgentsModelVariant4)
            {
                betaManagedAgentsModelVariant4?.Invoke(BetaManagedAgentsModelVariant4!);
            }
            else if (IsBetaManagedAgentsModelVariant5)
            {
                betaManagedAgentsModelVariant5?.Invoke(BetaManagedAgentsModelVariant5!);
            }
            else if (IsBetaManagedAgentsModelVariant6)
            {
                betaManagedAgentsModelVariant6?.Invoke(BetaManagedAgentsModelVariant6!);
            }
            else if (IsBetaManagedAgentsModelVariant7)
            {
                betaManagedAgentsModelVariant7?.Invoke(BetaManagedAgentsModelVariant7!);
            }
            else if (IsBetaManagedAgentsModelVariant8)
            {
                betaManagedAgentsModelVariant8?.Invoke(BetaManagedAgentsModelVariant8!);
            }
            else if (IsBetaManagedAgentsModelVariant9)
            {
                betaManagedAgentsModelVariant9?.Invoke(BetaManagedAgentsModelVariant9!);
            }
            else if (IsBetaManagedAgentsModelVariant10)
            {
                betaManagedAgentsModelVariant10?.Invoke(BetaManagedAgentsModelVariant10!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaManagedAgentsModelVariant1,
                typeof(string),
                BetaManagedAgentsModelVariant2,
                typeof(string),
                BetaManagedAgentsModelVariant3,
                typeof(string),
                BetaManagedAgentsModelVariant4,
                typeof(string),
                BetaManagedAgentsModelVariant5,
                typeof(string),
                BetaManagedAgentsModelVariant6,
                typeof(string),
                BetaManagedAgentsModelVariant7,
                typeof(string),
                BetaManagedAgentsModelVariant8,
                typeof(string),
                BetaManagedAgentsModelVariant9,
                typeof(string),
                BetaManagedAgentsModelVariant10,
                typeof(string),
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
        public bool Equals(BetaManagedAgentsModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant1, other.BetaManagedAgentsModelVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant2, other.BetaManagedAgentsModelVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant3, other.BetaManagedAgentsModelVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant4, other.BetaManagedAgentsModelVariant4) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant5, other.BetaManagedAgentsModelVariant5) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant6, other.BetaManagedAgentsModelVariant6) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant7, other.BetaManagedAgentsModelVariant7) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant8, other.BetaManagedAgentsModelVariant8) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant9, other.BetaManagedAgentsModelVariant9) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant10, other.BetaManagedAgentsModelVariant10) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsModel obj1, BetaManagedAgentsModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsModel obj1, BetaManagedAgentsModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsModel o && Equals(o);
        }
    }
}
