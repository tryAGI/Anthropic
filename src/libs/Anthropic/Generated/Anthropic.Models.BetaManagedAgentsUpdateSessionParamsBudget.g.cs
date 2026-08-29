
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Enforced spend ceiling for the session. Set an object to replace the budget of a session that was created with one, or `null` to remove it; omit to preserve. A budget cannot be added to a session created without one (rejected with reason `budget_create_only`), and a removed budget cannot be re-added. Allowed in any non-terminated status. Lowering `max_list_cost` to at or below the session's consumed list cost is rejected with reason `budget_not_raised`, and every model the session can run must have a public list price or the request is rejected with reason `model_not_budgetable`.
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateSessionParamsBudget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}