using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Microsoft.Extensions.Configuration;

namespace JobsAbility
{
    abstract public class AmazonCredHelper
    {
        private static string AwsAccessKeyId = "AKIAJBM7TCH5LK72ICOA";
        private static string AwsSecretAccessKey = "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";
        static AmazonCredHelper()
        {
            AwsAccessKeyId = Config.GetValue("AwsAccessKeyId");
            AwsSecretAccessKey = Config.GetValue("AwsSecretAccessKey");
            AwsCredintals = new Amazon.Runtime.BasicAWSCredentials(AwsAccessKeyId, AwsSecretAccessKey);
        }
        public static Amazon.Runtime.AWSCredentials AwsCredintals;
    }
}
