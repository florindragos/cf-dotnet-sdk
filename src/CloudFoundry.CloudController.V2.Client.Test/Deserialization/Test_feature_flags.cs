//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class FeatureFlagsTest
    {


        [TestMethod]
        public void TestGetServiceInstanceCreationFeatureFlagResponse()
        {
            string json = @"{
  ""name"": ""service_instance_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/service_instance_creation""
}";

            GetServiceInstanceCreationFeatureFlagResponse obj = Utilities.DeserializeJson<GetServiceInstanceCreationFeatureFlagResponse>(json);

            Assert.AreEqual("service_instance_creation", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/service_instance_creation", TestUtil.ToTestableString(obj.Url), true);
        }

        [TestMethod]
        public void TestSetFeatureFlagResponse()
        {
            string json = @"{
  ""name"": ""user_org_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/user_org_creation""
}";

            SetFeatureFlagResponse obj = Utilities.DeserializeJson<SetFeatureFlagResponse>(json);

            Assert.AreEqual("user_org_creation", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/user_org_creation", TestUtil.ToTestableString(obj.Url), true);
        }

        [TestMethod]
        public void TestGetAppBitsUploadFeatureFlagResponse()
        {
            string json = @"{
  ""name"": ""app_bits_upload"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/app_bits_upload""
}";

            GetAppBitsUploadFeatureFlagResponse obj = Utilities.DeserializeJson<GetAppBitsUploadFeatureFlagResponse>(json);

            Assert.AreEqual("app_bits_upload", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/app_bits_upload", TestUtil.ToTestableString(obj.Url), true);
        }

        [TestMethod]
        public void TestGetAppScalingFeatureFlagResponse()
        {
            string json = @"{
  ""name"": ""app_scaling"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/app_scaling""
}";

            GetAppScalingFeatureFlagResponse obj = Utilities.DeserializeJson<GetAppScalingFeatureFlagResponse>(json);

            Assert.AreEqual("app_scaling", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/app_scaling", TestUtil.ToTestableString(obj.Url), true);
        }

        [TestMethod]
        public void TestGetPrivateDomainCreationFeatureFlagResponse()
        {
            string json = @"{
  ""name"": ""private_domain_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/private_domain_creation""
}";

            GetPrivateDomainCreationFeatureFlagResponse obj = Utilities.DeserializeJson<GetPrivateDomainCreationFeatureFlagResponse>(json);

            Assert.AreEqual("private_domain_creation", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/private_domain_creation", TestUtil.ToTestableString(obj.Url), true);
        }

        [TestMethod]
        public void TestGetAllFeatureFlagsResponse()
        {
            string json = @"[
  {
    ""name"": ""user_org_creation"",
    ""enabled"": false,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/user_org_creation""
  },
  {
    ""name"": ""private_domain_creation"",
    ""enabled"": false,
    ""error_message"": ""foobar"",
    ""url"": ""/v2/config/feature_flags/private_domain_creation""
  },
  {
    ""name"": ""app_bits_upload"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/app_bits_upload""
  },
  {
    ""name"": ""app_scaling"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/app_scaling""
  },
  {
    ""name"": ""route_creation"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/route_creation""
  },
  {
    ""name"": ""service_instance_creation"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/service_instance_creation""
  }
]";

            GetAllFeatureFlagsResponse[] obj = Utilities.DeserializeJsonArray<GetAllFeatureFlagsResponse>(json);

            Assert.AreEqual("user_org_creation", TestUtil.ToTestableString(obj[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj[0].ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/user_org_creation", TestUtil.ToTestableString(obj[0].Url), true);
            Assert.AreEqual("private_domain_creation", TestUtil.ToTestableString(obj[1].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].Enabled), true);
            Assert.AreEqual("foobar", TestUtil.ToTestableString(obj[1].ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/private_domain_creation", TestUtil.ToTestableString(obj[1].Url), true);
            Assert.AreEqual("app_bits_upload", TestUtil.ToTestableString(obj[2].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj[2].Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj[2].ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/app_bits_upload", TestUtil.ToTestableString(obj[2].Url), true);
            Assert.AreEqual("app_scaling", TestUtil.ToTestableString(obj[3].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj[3].Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj[3].ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/app_scaling", TestUtil.ToTestableString(obj[3].Url), true);
            Assert.AreEqual("route_creation", TestUtil.ToTestableString(obj[4].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj[4].Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj[4].ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/route_creation", TestUtil.ToTestableString(obj[4].Url), true);
            Assert.AreEqual("service_instance_creation", TestUtil.ToTestableString(obj[5].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj[5].Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj[5].ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/service_instance_creation", TestUtil.ToTestableString(obj[5].Url), true);
        }

        [TestMethod]
        public void TestGetUserOrgCreationFeatureFlagResponse()
        {
            string json = @"{
  ""name"": ""user_org_creation"",
  ""enabled"": false,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/user_org_creation""
}";

            GetUserOrgCreationFeatureFlagResponse obj = Utilities.DeserializeJson<GetUserOrgCreationFeatureFlagResponse>(json);

            Assert.AreEqual("user_org_creation", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/user_org_creation", TestUtil.ToTestableString(obj.Url), true);
        }

        [TestMethod]
        public void TestGetRouteCreationFeatureFlagResponse()
        {
            string json = @"{
  ""name"": ""route_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/route_creation""
}";

            GetRouteCreationFeatureFlagResponse obj = Utilities.DeserializeJson<GetRouteCreationFeatureFlagResponse>(json);

            Assert.AreEqual("route_creation", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
            Assert.AreEqual("/v2/config/feature_flags/route_creation", TestUtil.ToTestableString(obj.Url), true);
        }
    }
}
