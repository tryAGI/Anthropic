
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsApiActorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsApiActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsApiActorType value)
        {
            return value switch
            {
                BetaManagedAgentsApiActorType.ApiActor => "api_actor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsApiActorType? ToEnum(string value)
        {
            return value switch
            {
                "api_actor" => BetaManagedAgentsApiActorType.ApiActor,
                _ => null,
            };
        }
    }
}