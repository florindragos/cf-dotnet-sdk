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
    public class ServiceAuthTokensDeprecatedEndpoint
{
        [TestMethod]
        public void RetrieveServiceAuthTokenDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""215b089a-4a3e-4a80-9339-1e2354d73ebc"",
    ""url"": ""/v2/service_auth_tokens/215b089a-4a3e-4a80-9339-1e2354d73ebc"",
    ""created_at"": ""2016-02-05T12:14:51Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-70"",
    ""provider"": ""provider-7""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceAuthTokensDeprecated.RetrieveServiceAuthTokenDeprecated(guid).Result;


                Assert.AreEqual("215b089a-4a3e-4a80-9339-1e2354d73ebc", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/215b089a-4a3e-4a80-9339-1e2354d73ebc", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-70", TestUtil.ToTestableString(obj.Label), true);
                Assert.AreEqual("provider-7", TestUtil.ToTestableString(obj.Provider), true);

            }
        }

        [TestMethod]
        public void ListAllServiceAuthTokensDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""4e85a425-47e7-4840-a93f-758a48e9097c"",
        ""url"": ""/v2/service_auth_tokens/4e85a425-47e7-4840-a93f-758a48e9097c"",
        ""created_at"": ""2016-02-05T12:14:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-67"",
        ""provider"": ""provider-4""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9e4f88f9-9566-44f3-95ee-d1fb2e7b66c5"",
        ""url"": ""/v2/service_auth_tokens/9e4f88f9-9566-44f3-95ee-d1fb2e7b66c5"",
        ""created_at"": ""2016-02-05T12:14:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-68"",
        ""provider"": ""provider-5""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""789bedf4-7ee6-442e-8fd4-72c10145d00c"",
        ""url"": ""/v2/service_auth_tokens/789bedf4-7ee6-442e-8fd4-72c10145d00c"",
        ""created_at"": ""2016-02-05T12:14:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-69"",
        ""provider"": ""provider-6""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.ListAllServiceAuthTokensDeprecated().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("4e85a425-47e7-4840-a93f-758a48e9097c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/4e85a425-47e7-4840-a93f-758a48e9097c", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-67", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("provider-4", TestUtil.ToTestableString(obj[0].Provider), true);
                Assert.AreEqual("9e4f88f9-9566-44f3-95ee-d1fb2e7b66c5", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/9e4f88f9-9566-44f3-95ee-d1fb2e7b66c5", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-68", TestUtil.ToTestableString(obj[1].Label), true);
                Assert.AreEqual("provider-5", TestUtil.ToTestableString(obj[1].Provider), true);
                Assert.AreEqual("789bedf4-7ee6-442e-8fd4-72c10145d00c", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/789bedf4-7ee6-442e-8fd4-72c10145d00c", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-69", TestUtil.ToTestableString(obj[2].Label), true);
                Assert.AreEqual("provider-6", TestUtil.ToTestableString(obj[2].Provider), true);

            }
        }

        [TestMethod]
        public void DeleteServiceAuthTokenDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceAuthTokensDeprecated.DeleteServiceAuthTokenDeprecated(guid).Wait();

            }
        }

        [TestMethod]
        public void FilterResultSetByLabelDeprecatedTest()
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
        ""guid"": ""f3c1a0d4-d592-4929-b22a-f4d619c2229c"",
        ""url"": ""/v2/service_auth_tokens/f3c1a0d4-d592-4929-b22a-f4d619c2229c"",
        ""created_at"": ""2016-02-05T12:14:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""Nic-Token"",
        ""provider"": ""provider-13""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.FilterResultSetByLabelDeprecated().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("f3c1a0d4-d592-4929-b22a-f4d619c2229c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/f3c1a0d4-d592-4929-b22a-f4d619c2229c", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("Nic-Token", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("provider-13", TestUtil.ToTestableString(obj[0].Provider), true);

            }
        }

        [TestMethod]
        public void FilterResultSetByProviderDeprecatedTest()
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
        ""guid"": ""8e94b501-cd2a-43ad-8c3a-66175e9b03e1"",
        ""url"": ""/v2/service_auth_tokens/8e94b501-cd2a-43ad-8c3a-66175e9b03e1"",
        ""created_at"": ""2016-02-05T12:14:51Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-79"",
        ""provider"": ""Face-Offer""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.FilterResultSetByProviderDeprecated().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("8e94b501-cd2a-43ad-8c3a-66175e9b03e1", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/8e94b501-cd2a-43ad-8c3a-66175e9b03e1", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:51Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-79", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("Face-Offer", TestUtil.ToTestableString(obj[0].Provider), true);

            }
        }

    }
}