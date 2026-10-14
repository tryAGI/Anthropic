
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsExecutionIdentityParamsDiscriminatorType
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
    public static class BetaManagedAgentsExecutionIdentityParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsExecutionIdentityParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsExecutionIdentityParamsDiscriminatorType.AwsRole => "aws_role",
                BetaManagedAgentsExecutionIdentityParamsDiscriminatorType.ServiceAccount => "service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsExecutionIdentityParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws_role" => BetaManagedAgentsExecutionIdentityParamsDiscriminatorType.AwsRole,
                "service_account" => BetaManagedAgentsExecutionIdentityParamsDiscriminatorType.ServiceAccount,
                _ => null,
            };
        }
    }
}