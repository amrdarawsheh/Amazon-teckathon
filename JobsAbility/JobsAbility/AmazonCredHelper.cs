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
        private const string AwsAccessKeyId = "AKIAIJWV5GBB4ERUVUHA";
        private const string AwsSecretAccessKey = "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";
        static AmazonCredHelper()
        {
            AwsCredintals = new Amazon.Runtime.BasicAWSCredentials(AwsAccessKeyId, AwsSecretAccessKey);
        }
        public static Amazon.Runtime.AWSCredentials AwsCredintals;
    }
}
