
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsFederatedActorAwsProvider
    {
        /// <summary>
        /// The AWS account the organization is bound to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        /// The AWS-signed ARN of the IAM principal that made the requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_principal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedPrincipal { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"aws"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "aws";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorAwsProvider" /> class.
        /// </summary>
        /// <param name="accountId">
        /// The AWS account the organization is bound to.
        /// </param>
        /// <param name="signedPrincipal">
        /// The AWS-signed ARN of the IAM principal that made the requests.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFederatedActorAwsProvider(
            string accountId,
            string signedPrincipal,
            string type = "aws")
        {
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.SignedPrincipal = signedPrincipal ?? throw new global::System.ArgumentNullException(nameof(signedPrincipal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorAwsProvider" /> class.
        /// </summary>
        public BetaAnalyticsFederatedActorAwsProvider()
        {
        }

    }
}