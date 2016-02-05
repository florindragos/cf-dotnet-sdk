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
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupRunningDefaultsEndpoint
{
        [TestMethod]
        public void RemovingSecurityGroupAsDefaultForRunningAppsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SecurityGroupRunningDefaults.RemovingSecurityGroupAsDefaultForRunningApps(guid).Wait();

            }
        }

        [TestMethod]
        public void SetSecurityGroupAsDefaultForRunningAppsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""cd320f0d-be71-45cf-8dfd-564d68597936"",
    ""url"": ""/v2/config/running_security_groups/cd320f0d-be71-45cf-8dfd-564d68597936"",
    ""created_at"": ""2016-02-05T12:14:51Z"",
    ""updated_at"": ""2016-02-05T12:14:51Z""
  },
  ""entity"": {
    ""name"": ""name-1932"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": true,
    ""staging_default"": false
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroupRunningDefaults.SetSecurityGroupAsDefaultForRunningApps(guid).Result;


                Assert.AreEqual("cd320f0d-be71-45cf-8dfd-564d68597936", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/running_security_groups/cd320f0d-be71-45cf-8dfd-564d68597936", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1932", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);

            }
        }

        [TestMethod]
        public void ReturnSecurityGroupsUsedForRunningAppsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""27c49e41-fa3e-4b65-87d8-c12dbf65b080"",
        ""url"": ""/v2/config/running_security_groups/27c49e41-fa3e-4b65-87d8-c12dbf65b080"",
        ""created_at"": ""2016-02-05T12:14:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1931"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": true,
        ""staging_default"": false
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SecurityGroupRunningDefaults.ReturnSecurityGroupsUsedForRunningApps().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("27c49e41-fa3e-4b65-87d8-c12dbf65b080", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/running_security_groups/27c49e41-fa3e-4b65-87d8-c12dbf65b080", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1931", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].StagingDefault), true);

            }
        }

    }
}