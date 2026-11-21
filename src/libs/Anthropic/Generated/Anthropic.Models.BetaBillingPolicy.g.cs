
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Declares which organization is billed for the request.
    /// </summary>
    public sealed partial class BetaBillingPolicy
    {
        /// <summary>
        /// Who is billed. `self`, the default, bills your organization, as if `billing_policy` were omitted. `user_profile` bills the customer behind the user profile the request names; if that customer has not linked an Anthropic organization to the profile, or has not allowed your organization to bill it, the request is rejected rather than billed to you.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bill_to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaBillToJsonConverter))]
        public global::Anthropic.BetaBillTo? BillTo { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"billing_policy"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "billing_policy";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBillingPolicy" /> class.
        /// </summary>
        /// <param name="billTo">
        /// Who is billed. `self`, the default, bills your organization, as if `billing_policy` were omitted. `user_profile` bills the customer behind the user profile the request names; if that customer has not linked an Anthropic organization to the profile, or has not allowed your organization to bill it, the request is rejected rather than billed to you.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBillingPolicy(
            global::Anthropic.BetaBillTo? billTo,
            string type = "billing_policy")
        {
            this.BillTo = billTo;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBillingPolicy" /> class.
        /// </summary>
        public BetaBillingPolicy()
        {
        }

    }
}