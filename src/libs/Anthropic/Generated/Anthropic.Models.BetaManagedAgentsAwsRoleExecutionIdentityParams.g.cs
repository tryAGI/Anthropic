
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An AWS IAM role principal.
    /// </summary>
    public sealed partial class BetaManagedAgentsAwsRoleExecutionIdentityParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"aws_role"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "aws_role";

        /// <summary>
        /// The IAM role's ARN, e.g. "arn:aws:iam::123456789012:role/my-agent-runner". Maximum 2048 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAwsRoleExecutionIdentityParams" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// The IAM role's ARN, e.g. "arn:aws:iam::123456789012:role/my-agent-runner". Maximum 2048 characters.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAwsRoleExecutionIdentityParams(
            string roleArn,
            string type = "aws_role")
        {
            this.Type = type;
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAwsRoleExecutionIdentityParams" /> class.
        /// </summary>
        public BetaManagedAgentsAwsRoleExecutionIdentityParams()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAwsRoleExecutionIdentityParams"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAwsRoleExecutionIdentityParams FromRoleArn(string roleArn)
        {
            return new BetaManagedAgentsAwsRoleExecutionIdentityParams
            {
                RoleArn = roleArn,
            };
        }

    }
}