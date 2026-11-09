
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="type">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse(
            global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError error,
            string? requestId,
            string type = "error")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse" /> class.
        /// </summary>
        public UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse FromError(global::Anthropic.UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponseError error)
        {
            return new UpdateRbacGroupV1OrganizationsRbacGroupsGroupIdPostResponse
            {
                Error = error,
            };
        }

    }
}