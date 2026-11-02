
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A field that must stay the same across a Thread's turns differs from the value stored with the Thread; the message names each such field. Send the stored values, or replay the full conversation with `thread: {"type": "create"}` to change them.
    /// </summary>
    public sealed partial class ThreadFingerprintMismatchErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread_fingerprint_mismatch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "thread_fingerprint_mismatch";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadFingerprintMismatchErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadFingerprintMismatchErrorDetails(
            string errorCode = "thread_fingerprint_mismatch")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadFingerprintMismatchErrorDetails" /> class.
        /// </summary>
        public ThreadFingerprintMismatchErrorDetails()
        {
        }

    }
}