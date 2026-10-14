
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsExecutionIdentityDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AwsRole,
        /// <summary>
        ///
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsExecutionIdentityDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsExecutionIdentityDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsExecutionIdentityDiscriminatorType.AwsRole => "aws_role",
                BetaManagedAgentsExecutionIdentityDiscriminatorType.ServiceAccount => "service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsExecutionIdentityDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws_role" => BetaManagedAgentsExecutionIdentityDiscriminatorType.AwsRole,
                "service_account" => BetaManagedAgentsExecutionIdentityDiscriminatorType.ServiceAccount,
                _ => null,
            };
        }
    }
}