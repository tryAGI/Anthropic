
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The end-user that the profile represents enrolls in a program.
    /// </summary>
    public sealed partial class UserProfileEnrollEndUserAction
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enroll_end_user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enroll_end_user";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEnrollEndUserAction" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileEnrollEndUserAction(
            string type = "enroll_end_user")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEnrollEndUserAction" /> class.
        /// </summary>
        public UserProfileEnrollEndUserAction()
        {
        }

    }
}