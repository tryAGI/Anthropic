
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An AWS IAM role principal as returned in API responses.
    /// </summary>
    public sealed partial class BetaManagedAgentsAwsRoleExecutionIdentity
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"aws_role"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "aws_role";

        /// <summary>
        /// The IAM role's ARN.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAwsRoleExecutionIdentity" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// The IAM role's ARN.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAwsRoleExecutionIdentity(
            string roleArn,
            string type = "aws_role")
        {
            this.Type = type;
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAwsRoleExecutionIdentity" /> class.
        /// </summary>
        public BetaManagedAgentsAwsRoleExecutionIdentity()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsAwsRoleExecutionIdentity"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsAwsRoleExecutionIdentity FromRoleArn(string roleArn)
        {
            return new BetaManagedAgentsAwsRoleExecutionIdentity
            {
                RoleArn = roleArn,
            };
        }

    }
}