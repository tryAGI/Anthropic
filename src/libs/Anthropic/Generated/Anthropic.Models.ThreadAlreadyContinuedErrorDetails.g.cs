
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The response that `previous_message_id` names has already been continued, and each response can be continued only once. Continue from the Thread's most recent response `id`.
    /// </summary>
    public sealed partial class ThreadAlreadyContinuedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread_already_continued"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "thread_already_continued";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadAlreadyContinuedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadAlreadyContinuedErrorDetails(
            string errorCode = "thread_already_continued")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadAlreadyContinuedErrorDetails" /> class.
        /// </summary>
        public ThreadAlreadyContinuedErrorDetails()
        {
        }

    }
}