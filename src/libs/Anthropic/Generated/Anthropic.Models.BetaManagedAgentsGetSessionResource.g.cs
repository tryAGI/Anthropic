#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The requested session resource.
    /// </summary>
    public readonly partial struct BetaManagedAgentsGetSessionResource : global::System.IEquatable<BetaManagedAgentsGetSessionResource>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"type":"github_repository","id":"sesrsc_011CZkZCKr6eXyl0gWMOdQiu","url":"https://github.com/example-org/example-repo","mount_path":"/workspace/example-repo","checkout":{"type":"branch","name":"main"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? GithubRepository { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? GithubRepository { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GithubRepository))]
#endif
        public bool IsGithubRepository => GithubRepository != null;

        /// <summary>
        /// Example: {"type":"file","id":"sesrsc_011CZkZBJq5dWxk9fVLNcPht","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileResource? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileResource? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsGetSessionResource(global::Anthropic.BetaManagedAgentsGitHubRepositoryResource value) => new BetaManagedAgentsGetSessionResource((global::Anthropic.BetaManagedAgentsGitHubRepositoryResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsGitHubRepositoryResource?(BetaManagedAgentsGetSessionResource @this) => @this.GithubRepository;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsGetSessionResource(global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? value)
        {
            GithubRepository = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsGetSessionResource(global::Anthropic.BetaManagedAgentsFileResource value) => new BetaManagedAgentsGetSessionResource((global::Anthropic.BetaManagedAgentsFileResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileResource?(BetaManagedAgentsGetSessionResource @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsGetSessionResource(global::Anthropic.BetaManagedAgentsFileResource? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsGetSessionResource(
            global::Anthropic.BetaManagedAgentsGetSessionResourceDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsGitHubRepositoryResource? githubRepository,
            global::Anthropic.BetaManagedAgentsFileResource? file
            )
        {
            Type = type;

            GithubRepository = githubRepository;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            GithubRepository as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GithubRepository?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGithubRepository && !IsFile || !IsGithubRepository && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsGitHubRepositoryResource?, TResult>? githubRepository = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsFileResource?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepository && githubRepository != null)
            {
                return githubRepository(GithubRepository!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsGitHubRepositoryResource?>? githubRepository = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsFileResource?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepository)
            {
                githubRepository?.Invoke(GithubRepository!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GithubRepository,
                typeof(global::Anthropic.BetaManagedAgentsGitHubRepositoryResource),
                File,
                typeof(global::Anthropic.BetaManagedAgentsFileResource),
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
        public bool Equals(BetaManagedAgentsGetSessionResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsGitHubRepositoryResource?>.Default.Equals(GithubRepository, other.GithubRepository) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileResource?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsGetSessionResource obj1, BetaManagedAgentsGetSessionResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsGetSessionResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsGetSessionResource obj1, BetaManagedAgentsGetSessionResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsGetSessionResource o && Equals(o);
        }
    }
}
