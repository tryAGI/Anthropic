
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Does the incoming JWT qualify?<br/>
    /// All populated fields must pass; omitted fields are skipped. At least one<br/>
    /// of `subject_prefix` (other than a wildcard-only value like `*`), `claims`,<br/>
    /// or `condition` is required; `audience` alone is not sufficient.
    /// </summary>
    public sealed partial class BetaRuleMatch
    {
        /// <summary>
        /// Exact match against the `aud` claim (any element if array). When omitted, the JWT's `aud` must still equal Anthropic's expected audience for the issuer; setting this field overrides that default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// Exact-match `{claim: value}` pairs against top-level claims. Only string-valued claims can be matched; use `condition` for non-string claims.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        public global::System.Collections.Generic.Dictionary<string, string>? Claims { get; set; }

        /// <summary>
        /// CEL expression over claims for logic the structural fields can't express. Must evaluate to a boolean and may reference only the `claims` variable; a constant-true expression (such as `true`) is rejected with 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// Match the verified JWT `sub` claim. Exact match unless the value ends with `*`, in which case it is a prefix match. Example: `repo:my-org/my-repo:ref:refs/heads/main`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_prefix")]
        public string? SubjectPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRuleMatch" /> class.
        /// </summary>
        /// <param name="audience">
        /// Exact match against the `aud` claim (any element if array). When omitted, the JWT's `aud` must still equal Anthropic's expected audience for the issuer; setting this field overrides that default.
        /// </param>
        /// <param name="claims">
        /// Exact-match `{claim: value}` pairs against top-level claims. Only string-valued claims can be matched; use `condition` for non-string claims.
        /// </param>
        /// <param name="condition">
        /// CEL expression over claims for logic the structural fields can't express. Must evaluate to a boolean and may reference only the `claims` variable; a constant-true expression (such as `true`) is rejected with 400.
        /// </param>
        /// <param name="subjectPrefix">
        /// Match the verified JWT `sub` claim. Exact match unless the value ends with `*`, in which case it is a prefix match. Example: `repo:my-org/my-repo:ref:refs/heads/main`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRuleMatch(
            string? audience,
            global::System.Collections.Generic.Dictionary<string, string>? claims,
            string? condition,
            string? subjectPrefix)
        {
            this.Audience = audience;
            this.Claims = claims;
            this.Condition = condition;
            this.SubjectPrefix = subjectPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRuleMatch" /> class.
        /// </summary>
        public BetaRuleMatch()
        {
        }

    }
}