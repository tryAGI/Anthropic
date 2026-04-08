#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsRepositoryCheckout : global::System.IEquatable<BetaManagedAgentsRepositoryCheckout>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"type":"branch","name":"main"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsBranchCheckout? Branch { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsBranchCheckout? Branch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branch))]
#endif
        public bool IsBranch => Branch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCommitCheckout? Commit { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCommitCheckout? Commit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Commit))]
#endif
        public bool IsCommit => Commit != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRepositoryCheckout(global::Anthropic.BetaManagedAgentsBranchCheckout value) => new BetaManagedAgentsRepositoryCheckout((global::Anthropic.BetaManagedAgentsBranchCheckout?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsBranchCheckout?(BetaManagedAgentsRepositoryCheckout @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRepositoryCheckout(global::Anthropic.BetaManagedAgentsBranchCheckout? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRepositoryCheckout(global::Anthropic.BetaManagedAgentsCommitCheckout value) => new BetaManagedAgentsRepositoryCheckout((global::Anthropic.BetaManagedAgentsCommitCheckout?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCommitCheckout?(BetaManagedAgentsRepositoryCheckout @this) => @this.Commit;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRepositoryCheckout(global::Anthropic.BetaManagedAgentsCommitCheckout? value)
        {
            Commit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRepositoryCheckout(
            global::Anthropic.BetaManagedAgentsRepositoryCheckoutDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsBranchCheckout? branch,
            global::Anthropic.BetaManagedAgentsCommitCheckout? commit
            )
        {
            Type = type;

            Branch = branch;
            Commit = commit;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Commit as object ??
            Branch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Branch?.ToString() ??
            Commit?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBranch && !IsCommit || !IsBranch && IsCommit;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsBranchCheckout?, TResult>? branch = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsCommitCheckout?, TResult>? commit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBranch && branch != null)
            {
                return branch(Branch!);
            }
            else if (IsCommit && commit != null)
            {
                return commit(Commit!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsBranchCheckout?>? branch = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsCommitCheckout?>? commit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBranch)
            {
                branch?.Invoke(Branch!);
            }
            else if (IsCommit)
            {
                commit?.Invoke(Commit!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Branch,
                typeof(global::Anthropic.BetaManagedAgentsBranchCheckout),
                Commit,
                typeof(global::Anthropic.BetaManagedAgentsCommitCheckout),
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
        public bool Equals(BetaManagedAgentsRepositoryCheckout other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBranchCheckout?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCommitCheckout?>.Default.Equals(Commit, other.Commit) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsRepositoryCheckout obj1, BetaManagedAgentsRepositoryCheckout obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsRepositoryCheckout>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsRepositoryCheckout obj1, BetaManagedAgentsRepositoryCheckout obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsRepositoryCheckout o && Equals(o);
        }
    }
}
