
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInviteStatusSchema
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Deleted,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInviteStatusSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInviteStatusSchema value)
        {
            return value switch
            {
                BetaInviteStatusSchema.Accepted => "accepted",
                BetaInviteStatusSchema.Deleted => "deleted",
                BetaInviteStatusSchema.Expired => "expired",
                BetaInviteStatusSchema.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInviteStatusSchema? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => BetaInviteStatusSchema.Accepted,
                "deleted" => BetaInviteStatusSchema.Deleted,
                "expired" => BetaInviteStatusSchema.Expired,
                "pending" => BetaInviteStatusSchema.Pending,
                _ => null,
            };
        }
    }
}