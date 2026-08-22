
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 5-field POSIX cron schedule. Literal wall-clock matching in the configured timezone.<br/>
    /// Example: {"type":"cron","expression":"0 9 * * 1-5","timezone":"America/Los_Angeles"}
    /// </summary>
    public sealed partial class BetaManagedAgentsCronScheduleParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCronScheduleParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCronScheduleParamsType Type { get; set; }

        /// <summary>
        /// 5-field POSIX cron expression: minute hour day-of-month month day-of-week (e.g., "0 9 * * 1-5" for weekdays at 9am). Day-of-week is 0-7 where 0 and 7 both mean Sunday. Extended cron syntax - seconds or year fields, and the special characters L, W, #, and ? - is not supported, nor are predefined shortcuts (@daily).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        /// Required. IANA timezone identifier (e.g., "America/Los_Angeles", "UTC"). Validated against the IANA timezone database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCronScheduleParams" /> class.
        /// </summary>
        /// <param name="expression">
        /// 5-field POSIX cron expression: minute hour day-of-month month day-of-week (e.g., "0 9 * * 1-5" for weekdays at 9am). Day-of-week is 0-7 where 0 and 7 both mean Sunday. Extended cron syntax - seconds or year fields, and the special characters L, W, #, and ? - is not supported, nor are predefined shortcuts (@daily).
        /// </param>
        /// <param name="timezone">
        /// Required. IANA timezone identifier (e.g., "America/Los_Angeles", "UTC"). Validated against the IANA timezone database.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCronScheduleParams(
            string expression,
            string timezone,
            global::Anthropic.BetaManagedAgentsCronScheduleParamsType type)
        {
            this.Type = type;
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCronScheduleParams" /> class.
        /// </summary>
        public BetaManagedAgentsCronScheduleParams()
        {
        }

    }
}