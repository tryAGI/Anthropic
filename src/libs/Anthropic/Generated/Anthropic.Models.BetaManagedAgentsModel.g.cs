#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model that will power your agent.<br/>
    /// See [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
    /// </summary>
    public readonly partial struct BetaManagedAgentsModel : global::System.IEquatable<BetaManagedAgentsModel>
    {
        /// <summary>
        /// Efficient model for coding and agents
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant1;
            return IsBetaManagedAgentsModelVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant1() => BetaManagedAgentsModelVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Powerful intelligence for coding, knowledge work, and long-running agents
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant2;
            return IsBetaManagedAgentsModelVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant2() => BetaManagedAgentsModelVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Frontier intelligence for ambitious tasks across coding, scientific discovery, and enterprise workflows
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant3;
            return IsBetaManagedAgentsModelVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant3() => BetaManagedAgentsModelVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Efficient model for coding and agents
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant4;
            return IsBetaManagedAgentsModelVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant4() => BetaManagedAgentsModelVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant4' but the value was {ToString()}.");

        /// <summary>
        /// Next generation of intelligence for the hardest knowledge work and coding problems
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant5;
            return IsBetaManagedAgentsModelVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant5() => BetaManagedAgentsModelVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant5' but the value was {ToString()}.");

        /// <summary>
        /// Powerful intelligence for long-running agents and coding
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant6;
            return IsBetaManagedAgentsModelVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant6() => BetaManagedAgentsModelVariant6 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant6' but the value was {ToString()}.");

        /// <summary>
        /// Powerful intelligence for long-running agents and coding
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant7;
            return IsBetaManagedAgentsModelVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant7() => BetaManagedAgentsModelVariant7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant7' but the value was {ToString()}.");

        /// <summary>
        /// Powerful intelligence for long-running agents and coding
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant8;
            return IsBetaManagedAgentsModelVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant8() => BetaManagedAgentsModelVariant8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant8' but the value was {ToString()}.");

        /// <summary>
        /// Powerful intelligence for long-running agents and coding
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
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant9;
            return IsBetaManagedAgentsModelVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant9() => BetaManagedAgentsModelVariant9 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant9' but the value was {ToString()}.");

        /// <summary>
        /// Best combination of speed and intelligence
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
        public bool TryPickBetaManagedAgentsModelVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant10;
            return IsBetaManagedAgentsModelVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant10() => BetaManagedAgentsModelVariant10 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant10' but the value was {ToString()}.");

        /// <summary>
        /// Fastest model with near-frontier intelligence
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant11 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant11))]
#endif
        public bool IsBetaManagedAgentsModelVariant11 => BetaManagedAgentsModelVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant11;
            return IsBetaManagedAgentsModelVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant11() => BetaManagedAgentsModelVariant11 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant11' but the value was {ToString()}.");

        /// <summary>
        /// Fastest model with near-frontier intelligence
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant12 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant12))]
#endif
        public bool IsBetaManagedAgentsModelVariant12 => BetaManagedAgentsModelVariant12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant12;
            return IsBetaManagedAgentsModelVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant12() => BetaManagedAgentsModelVariant12 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant12' but the value was {ToString()}.");

        /// <summary>
        /// Powerful intelligence for long-running agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant13 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant13 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant13))]
#endif
        public bool IsBetaManagedAgentsModelVariant13 => BetaManagedAgentsModelVariant13 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant13;
            return IsBetaManagedAgentsModelVariant13;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant13() => BetaManagedAgentsModelVariant13 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant13' but the value was {ToString()}.");

        /// <summary>
        /// Powerful intelligence for long-running agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant14 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant14))]
#endif
        public bool IsBetaManagedAgentsModelVariant14 => BetaManagedAgentsModelVariant14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant14;
            return IsBetaManagedAgentsModelVariant14;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant14() => BetaManagedAgentsModelVariant14 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant14' but the value was {ToString()}.");

        /// <summary>
        /// High-performance model for agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant15 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant15))]
#endif
        public bool IsBetaManagedAgentsModelVariant15 => BetaManagedAgentsModelVariant15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant15;
            return IsBetaManagedAgentsModelVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant15() => BetaManagedAgentsModelVariant15 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant15' but the value was {ToString()}.");

        /// <summary>
        /// High-performance model for agents and coding
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant16 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant16))]
#endif
        public bool IsBetaManagedAgentsModelVariant16 => BetaManagedAgentsModelVariant16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant16;
            return IsBetaManagedAgentsModelVariant16;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant16() => BetaManagedAgentsModelVariant16 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant16' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsModelVariant17 { get; init; }
#else
        public string? BetaManagedAgentsModelVariant17 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsModelVariant17))]
#endif
        public bool IsBetaManagedAgentsModelVariant17 => BetaManagedAgentsModelVariant17 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsModelVariant17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsModelVariant17;
            return IsBetaManagedAgentsModelVariant17;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsModelVariant17() => BetaManagedAgentsModelVariant17 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsModelVariant17' but the value was {ToString()}.");
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
        public static BetaManagedAgentsModel FromBetaManagedAgentsModelVariant1(string? value) => new BetaManagedAgentsModel(value);

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
            string? betaManagedAgentsModelVariant10,
            string? betaManagedAgentsModelVariant11,
            string? betaManagedAgentsModelVariant12,
            string? betaManagedAgentsModelVariant13,
            string? betaManagedAgentsModelVariant14,
            string? betaManagedAgentsModelVariant15,
            string? betaManagedAgentsModelVariant16,
            string? betaManagedAgentsModelVariant17
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
            BetaManagedAgentsModelVariant11 = betaManagedAgentsModelVariant11;
            BetaManagedAgentsModelVariant12 = betaManagedAgentsModelVariant12;
            BetaManagedAgentsModelVariant13 = betaManagedAgentsModelVariant13;
            BetaManagedAgentsModelVariant14 = betaManagedAgentsModelVariant14;
            BetaManagedAgentsModelVariant15 = betaManagedAgentsModelVariant15;
            BetaManagedAgentsModelVariant16 = betaManagedAgentsModelVariant16;
            BetaManagedAgentsModelVariant17 = betaManagedAgentsModelVariant17;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaManagedAgentsModelVariant17 as object ??
            BetaManagedAgentsModelVariant16 as object ??
            BetaManagedAgentsModelVariant15 as object ??
            BetaManagedAgentsModelVariant14 as object ??
            BetaManagedAgentsModelVariant13 as object ??
            BetaManagedAgentsModelVariant12 as object ??
            BetaManagedAgentsModelVariant11 as object ??
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
            BetaManagedAgentsModelVariant10?.ToString() ??
            BetaManagedAgentsModelVariant11?.ToString() ??
            BetaManagedAgentsModelVariant12?.ToString() ??
            BetaManagedAgentsModelVariant13?.ToString() ??
            BetaManagedAgentsModelVariant14?.ToString() ??
            BetaManagedAgentsModelVariant15?.ToString() ??
            BetaManagedAgentsModelVariant16?.ToString() ??
            BetaManagedAgentsModelVariant17?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaManagedAgentsModelVariant1 || IsBetaManagedAgentsModelVariant2 || IsBetaManagedAgentsModelVariant3 || IsBetaManagedAgentsModelVariant4 || IsBetaManagedAgentsModelVariant5 || IsBetaManagedAgentsModelVariant6 || IsBetaManagedAgentsModelVariant7 || IsBetaManagedAgentsModelVariant8 || IsBetaManagedAgentsModelVariant9 || IsBetaManagedAgentsModelVariant10 || IsBetaManagedAgentsModelVariant11 || IsBetaManagedAgentsModelVariant12 || IsBetaManagedAgentsModelVariant13 || IsBetaManagedAgentsModelVariant14 || IsBetaManagedAgentsModelVariant15 || IsBetaManagedAgentsModelVariant16 || IsBetaManagedAgentsModelVariant17;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant1 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant2 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant3 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant4 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant5 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant6 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant7 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant8 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant9 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant10 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant11 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant12 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant13 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant14 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant15 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant16 = null,
            global::System.Func<string, TResult>? betaManagedAgentsModelVariant17 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsModelVariant1 is { } __value0 && betaManagedAgentsModelVariant1 != null)
            {
                return betaManagedAgentsModelVariant1(__value0);
            }
            else if (BetaManagedAgentsModelVariant2 is { } __value1 && betaManagedAgentsModelVariant2 != null)
            {
                return betaManagedAgentsModelVariant2(__value1);
            }
            else if (BetaManagedAgentsModelVariant3 is { } __value2 && betaManagedAgentsModelVariant3 != null)
            {
                return betaManagedAgentsModelVariant3(__value2);
            }
            else if (BetaManagedAgentsModelVariant4 is { } __value3 && betaManagedAgentsModelVariant4 != null)
            {
                return betaManagedAgentsModelVariant4(__value3);
            }
            else if (BetaManagedAgentsModelVariant5 is { } __value4 && betaManagedAgentsModelVariant5 != null)
            {
                return betaManagedAgentsModelVariant5(__value4);
            }
            else if (BetaManagedAgentsModelVariant6 is { } __value5 && betaManagedAgentsModelVariant6 != null)
            {
                return betaManagedAgentsModelVariant6(__value5);
            }
            else if (BetaManagedAgentsModelVariant7 is { } __value6 && betaManagedAgentsModelVariant7 != null)
            {
                return betaManagedAgentsModelVariant7(__value6);
            }
            else if (BetaManagedAgentsModelVariant8 is { } __value7 && betaManagedAgentsModelVariant8 != null)
            {
                return betaManagedAgentsModelVariant8(__value7);
            }
            else if (BetaManagedAgentsModelVariant9 is { } __value8 && betaManagedAgentsModelVariant9 != null)
            {
                return betaManagedAgentsModelVariant9(__value8);
            }
            else if (BetaManagedAgentsModelVariant10 is { } __value9 && betaManagedAgentsModelVariant10 != null)
            {
                return betaManagedAgentsModelVariant10(__value9);
            }
            else if (BetaManagedAgentsModelVariant11 is { } __value10 && betaManagedAgentsModelVariant11 != null)
            {
                return betaManagedAgentsModelVariant11(__value10);
            }
            else if (BetaManagedAgentsModelVariant12 is { } __value11 && betaManagedAgentsModelVariant12 != null)
            {
                return betaManagedAgentsModelVariant12(__value11);
            }
            else if (BetaManagedAgentsModelVariant13 is { } __value12 && betaManagedAgentsModelVariant13 != null)
            {
                return betaManagedAgentsModelVariant13(__value12);
            }
            else if (BetaManagedAgentsModelVariant14 is { } __value13 && betaManagedAgentsModelVariant14 != null)
            {
                return betaManagedAgentsModelVariant14(__value13);
            }
            else if (BetaManagedAgentsModelVariant15 is { } __value14 && betaManagedAgentsModelVariant15 != null)
            {
                return betaManagedAgentsModelVariant15(__value14);
            }
            else if (BetaManagedAgentsModelVariant16 is { } __value15 && betaManagedAgentsModelVariant16 != null)
            {
                return betaManagedAgentsModelVariant16(__value15);
            }
            else if (BetaManagedAgentsModelVariant17 is { } __value16 && betaManagedAgentsModelVariant17 != null)
            {
                return betaManagedAgentsModelVariant17(__value16);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaManagedAgentsModelVariant1 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant2 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant3 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant4 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant5 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant6 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant7 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant8 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant9 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant10 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant11 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant12 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant13 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant14 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant15 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant16 = null,

            global::System.Action<string>? betaManagedAgentsModelVariant17 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsModelVariant1 is { } __value0)
            {
                betaManagedAgentsModelVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsModelVariant2 is { } __value1)
            {
                betaManagedAgentsModelVariant2?.Invoke(__value1);
            }
            else if (BetaManagedAgentsModelVariant3 is { } __value2)
            {
                betaManagedAgentsModelVariant3?.Invoke(__value2);
            }
            else if (BetaManagedAgentsModelVariant4 is { } __value3)
            {
                betaManagedAgentsModelVariant4?.Invoke(__value3);
            }
            else if (BetaManagedAgentsModelVariant5 is { } __value4)
            {
                betaManagedAgentsModelVariant5?.Invoke(__value4);
            }
            else if (BetaManagedAgentsModelVariant6 is { } __value5)
            {
                betaManagedAgentsModelVariant6?.Invoke(__value5);
            }
            else if (BetaManagedAgentsModelVariant7 is { } __value6)
            {
                betaManagedAgentsModelVariant7?.Invoke(__value6);
            }
            else if (BetaManagedAgentsModelVariant8 is { } __value7)
            {
                betaManagedAgentsModelVariant8?.Invoke(__value7);
            }
            else if (BetaManagedAgentsModelVariant9 is { } __value8)
            {
                betaManagedAgentsModelVariant9?.Invoke(__value8);
            }
            else if (BetaManagedAgentsModelVariant10 is { } __value9)
            {
                betaManagedAgentsModelVariant10?.Invoke(__value9);
            }
            else if (BetaManagedAgentsModelVariant11 is { } __value10)
            {
                betaManagedAgentsModelVariant11?.Invoke(__value10);
            }
            else if (BetaManagedAgentsModelVariant12 is { } __value11)
            {
                betaManagedAgentsModelVariant12?.Invoke(__value11);
            }
            else if (BetaManagedAgentsModelVariant13 is { } __value12)
            {
                betaManagedAgentsModelVariant13?.Invoke(__value12);
            }
            else if (BetaManagedAgentsModelVariant14 is { } __value13)
            {
                betaManagedAgentsModelVariant14?.Invoke(__value13);
            }
            else if (BetaManagedAgentsModelVariant15 is { } __value14)
            {
                betaManagedAgentsModelVariant15?.Invoke(__value14);
            }
            else if (BetaManagedAgentsModelVariant16 is { } __value15)
            {
                betaManagedAgentsModelVariant16?.Invoke(__value15);
            }
            else if (BetaManagedAgentsModelVariant17 is { } __value16)
            {
                betaManagedAgentsModelVariant17?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaManagedAgentsModelVariant1 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant2 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant3 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant4 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant5 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant6 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant7 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant8 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant9 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant10 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant11 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant12 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant13 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant14 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant15 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant16 = null,
            global::System.Action<string>? betaManagedAgentsModelVariant17 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsModelVariant1 is { } __value0)
            {
                betaManagedAgentsModelVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsModelVariant2 is { } __value1)
            {
                betaManagedAgentsModelVariant2?.Invoke(__value1);
            }
            else if (BetaManagedAgentsModelVariant3 is { } __value2)
            {
                betaManagedAgentsModelVariant3?.Invoke(__value2);
            }
            else if (BetaManagedAgentsModelVariant4 is { } __value3)
            {
                betaManagedAgentsModelVariant4?.Invoke(__value3);
            }
            else if (BetaManagedAgentsModelVariant5 is { } __value4)
            {
                betaManagedAgentsModelVariant5?.Invoke(__value4);
            }
            else if (BetaManagedAgentsModelVariant6 is { } __value5)
            {
                betaManagedAgentsModelVariant6?.Invoke(__value5);
            }
            else if (BetaManagedAgentsModelVariant7 is { } __value6)
            {
                betaManagedAgentsModelVariant7?.Invoke(__value6);
            }
            else if (BetaManagedAgentsModelVariant8 is { } __value7)
            {
                betaManagedAgentsModelVariant8?.Invoke(__value7);
            }
            else if (BetaManagedAgentsModelVariant9 is { } __value8)
            {
                betaManagedAgentsModelVariant9?.Invoke(__value8);
            }
            else if (BetaManagedAgentsModelVariant10 is { } __value9)
            {
                betaManagedAgentsModelVariant10?.Invoke(__value9);
            }
            else if (BetaManagedAgentsModelVariant11 is { } __value10)
            {
                betaManagedAgentsModelVariant11?.Invoke(__value10);
            }
            else if (BetaManagedAgentsModelVariant12 is { } __value11)
            {
                betaManagedAgentsModelVariant12?.Invoke(__value11);
            }
            else if (BetaManagedAgentsModelVariant13 is { } __value12)
            {
                betaManagedAgentsModelVariant13?.Invoke(__value12);
            }
            else if (BetaManagedAgentsModelVariant14 is { } __value13)
            {
                betaManagedAgentsModelVariant14?.Invoke(__value13);
            }
            else if (BetaManagedAgentsModelVariant15 is { } __value14)
            {
                betaManagedAgentsModelVariant15?.Invoke(__value14);
            }
            else if (BetaManagedAgentsModelVariant16 is { } __value15)
            {
                betaManagedAgentsModelVariant16?.Invoke(__value15);
            }
            else if (BetaManagedAgentsModelVariant17 is { } __value16)
            {
                betaManagedAgentsModelVariant17?.Invoke(__value16);
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
                BetaManagedAgentsModelVariant11,
                typeof(string),
                BetaManagedAgentsModelVariant12,
                typeof(string),
                BetaManagedAgentsModelVariant13,
                typeof(string),
                BetaManagedAgentsModelVariant14,
                typeof(string),
                BetaManagedAgentsModelVariant15,
                typeof(string),
                BetaManagedAgentsModelVariant16,
                typeof(string),
                BetaManagedAgentsModelVariant17,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant10, other.BetaManagedAgentsModelVariant10) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant11, other.BetaManagedAgentsModelVariant11) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant12, other.BetaManagedAgentsModelVariant12) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant13, other.BetaManagedAgentsModelVariant13) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant14, other.BetaManagedAgentsModelVariant14) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant15, other.BetaManagedAgentsModelVariant15) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant16, other.BetaManagedAgentsModelVariant16) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsModelVariant17, other.BetaManagedAgentsModelVariant17)
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
