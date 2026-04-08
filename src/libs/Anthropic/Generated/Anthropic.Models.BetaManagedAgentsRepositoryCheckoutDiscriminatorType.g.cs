
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsRepositoryCheckoutDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Branch,
        /// <summary>
        /// 
        /// </summary>
        Commit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsRepositoryCheckoutDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsRepositoryCheckoutDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsRepositoryCheckoutDiscriminatorType.Branch => "branch",
                BetaManagedAgentsRepositoryCheckoutDiscriminatorType.Commit => "commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsRepositoryCheckoutDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => BetaManagedAgentsRepositoryCheckoutDiscriminatorType.Branch,
                "commit" => BetaManagedAgentsRepositoryCheckoutDiscriminatorType.Commit,
                _ => null,
            };
        }
    }
}