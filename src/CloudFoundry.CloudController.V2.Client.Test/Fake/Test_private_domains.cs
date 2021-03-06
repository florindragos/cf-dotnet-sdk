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
    public class PrivateDomainsEndpoint
{
        [TestMethod]
        public void RetrievePrivateDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""0092b149-ca9d-4e2c-9f36-eab07b08a6d5"",
    ""url"": ""/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5"",
    ""created_at"": ""2016-02-09T10:21:53Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""vcap.me"",
    ""owning_organization_guid"": ""21b05e41-2a93-45aa-8b06-b5512532a29a"",
    ""owning_organization_url"": ""/v2/organizations/21b05e41-2a93-45aa-8b06-b5512532a29a"",
    ""shared_organizations_url"": ""/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5/shared_organizations""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PrivateDomains.RetrievePrivateDomain(guid).Result;


                Assert.AreEqual("0092b149-ca9d-4e2c-9f36-eab07b08a6d5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("21b05e41-2a93-45aa-8b06-b5512532a29a", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/21b05e41-2a93-45aa-8b06-b5512532a29a", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);

            }
        }

        [TestMethod]
        public void FilterPrivateDomainsByNameTest()
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
        ""guid"": ""8a11b917-e6ef-49fe-8e7c-b1d52ff5fd75"",
        ""url"": ""/v2/private_domains/8a11b917-e6ef-49fe-8e7c-b1d52ff5fd75"",
        ""created_at"": ""2016-02-09T10:21:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""my-domain.com"",
        ""owning_organization_guid"": ""120a9d3e-9bd4-4401-b469-181c0c33d531"",
        ""owning_organization_url"": ""/v2/organizations/120a9d3e-9bd4-4401-b469-181c0c33d531"",
        ""shared_organizations_url"": ""/v2/private_domains/8a11b917-e6ef-49fe-8e7c-b1d52ff5fd75/shared_organizations""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.PrivateDomains.FilterPrivateDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("8a11b917-e6ef-49fe-8e7c-b1d52ff5fd75", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/8a11b917-e6ef-49fe-8e7c-b1d52ff5fd75", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:56Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-domain.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("120a9d3e-9bd4-4401-b469-181c0c33d531", TestUtil.ToTestableString(obj[0].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/120a9d3e-9bd4-4401-b469-181c0c33d531", TestUtil.ToTestableString(obj[0].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/8a11b917-e6ef-49fe-8e7c-b1d52ff5fd75/shared_organizations", TestUtil.ToTestableString(obj[0].SharedOrganizationsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllPrivateDomainsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""0092b149-ca9d-4e2c-9f36-eab07b08a6d5"",
        ""url"": ""/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5"",
        ""created_at"": ""2016-02-09T10:21:53Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""21b05e41-2a93-45aa-8b06-b5512532a29a"",
        ""owning_organization_url"": ""/v2/organizations/21b05e41-2a93-45aa-8b06-b5512532a29a"",
        ""shared_organizations_url"": ""/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""59f7b1b4-3f46-4045-85c9-3a1cbb701d98"",
        ""url"": ""/v2/private_domains/59f7b1b4-3f46-4045-85c9-3a1cbb701d98"",
        ""created_at"": ""2016-02-09T10:21:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-53.example.com"",
        ""owning_organization_guid"": ""0e665765-c6dd-4cfb-8a6e-180d518340b3"",
        ""owning_organization_url"": ""/v2/organizations/0e665765-c6dd-4cfb-8a6e-180d518340b3"",
        ""shared_organizations_url"": ""/v2/private_domains/59f7b1b4-3f46-4045-85c9-3a1cbb701d98/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5f4f9856-8fdb-4c27-8555-5e6848d16bea"",
        ""url"": ""/v2/private_domains/5f4f9856-8fdb-4c27-8555-5e6848d16bea"",
        ""created_at"": ""2016-02-09T10:21:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-54.example.com"",
        ""owning_organization_guid"": ""3289d627-3544-4a16-a2a1-215cecae6e4d"",
        ""owning_organization_url"": ""/v2/organizations/3289d627-3544-4a16-a2a1-215cecae6e4d"",
        ""shared_organizations_url"": ""/v2/private_domains/5f4f9856-8fdb-4c27-8555-5e6848d16bea/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""06c624bb-c5c3-4e60-94c4-7d852b03e6b3"",
        ""url"": ""/v2/private_domains/06c624bb-c5c3-4e60-94c4-7d852b03e6b3"",
        ""created_at"": ""2016-02-09T10:21:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-55.example.com"",
        ""owning_organization_guid"": ""82269e63-2062-4191-894a-749ac041919d"",
        ""owning_organization_url"": ""/v2/organizations/82269e63-2062-4191-894a-749ac041919d"",
        ""shared_organizations_url"": ""/v2/private_domains/06c624bb-c5c3-4e60-94c4-7d852b03e6b3/shared_organizations""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.PrivateDomains.ListAllPrivateDomains().Result;

                Assert.AreEqual("4", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("0092b149-ca9d-4e2c-9f36-eab07b08a6d5", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:53Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("21b05e41-2a93-45aa-8b06-b5512532a29a", TestUtil.ToTestableString(obj[0].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/21b05e41-2a93-45aa-8b06-b5512532a29a", TestUtil.ToTestableString(obj[0].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/0092b149-ca9d-4e2c-9f36-eab07b08a6d5/shared_organizations", TestUtil.ToTestableString(obj[0].SharedOrganizationsUrl), true);
                Assert.AreEqual("59f7b1b4-3f46-4045-85c9-3a1cbb701d98", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/59f7b1b4-3f46-4045-85c9-3a1cbb701d98", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:56Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-53.example.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("0e665765-c6dd-4cfb-8a6e-180d518340b3", TestUtil.ToTestableString(obj[1].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/0e665765-c6dd-4cfb-8a6e-180d518340b3", TestUtil.ToTestableString(obj[1].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/59f7b1b4-3f46-4045-85c9-3a1cbb701d98/shared_organizations", TestUtil.ToTestableString(obj[1].SharedOrganizationsUrl), true);
                Assert.AreEqual("5f4f9856-8fdb-4c27-8555-5e6848d16bea", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/5f4f9856-8fdb-4c27-8555-5e6848d16bea", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:56Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-54.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("3289d627-3544-4a16-a2a1-215cecae6e4d", TestUtil.ToTestableString(obj[2].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/3289d627-3544-4a16-a2a1-215cecae6e4d", TestUtil.ToTestableString(obj[2].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/5f4f9856-8fdb-4c27-8555-5e6848d16bea/shared_organizations", TestUtil.ToTestableString(obj[2].SharedOrganizationsUrl), true);
                Assert.AreEqual("06c624bb-c5c3-4e60-94c4-7d852b03e6b3", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/06c624bb-c5c3-4e60-94c4-7d852b03e6b3", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:56Z", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-55.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("82269e63-2062-4191-894a-749ac041919d", TestUtil.ToTestableString(obj[3].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/82269e63-2062-4191-894a-749ac041919d", TestUtil.ToTestableString(obj[3].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/06c624bb-c5c3-4e60-94c4-7d852b03e6b3/shared_organizations", TestUtil.ToTestableString(obj[3].SharedOrganizationsUrl), true);

            }
        }

        [TestMethod]
        public void CreatePrivateDomainOwnedByGivenOrganizationTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5741faeb-cf7d-4735-afc6-f969dec1dae9"",
    ""url"": ""/v2/private_domains/5741faeb-cf7d-4735-afc6-f969dec1dae9"",
    ""created_at"": ""2016-02-09T10:21:56Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""26617dad-a614-4c3d-baf7-e0785b9b58e0"",
    ""owning_organization_url"": ""/v2/organizations/26617dad-a614-4c3d-baf7-e0785b9b58e0"",
    ""shared_organizations_url"": ""/v2/private_domains/5741faeb-cf7d-4735-afc6-f969dec1dae9/shared_organizations""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreatePrivateDomainOwnedByGivenOrganizationRequest value = new CreatePrivateDomainOwnedByGivenOrganizationRequest();


                var obj = cfClient.PrivateDomains.CreatePrivateDomainOwnedByGivenOrganization(value).Result;


                Assert.AreEqual("5741faeb-cf7d-4735-afc6-f969dec1dae9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/5741faeb-cf7d-4735-afc6-f969dec1dae9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("26617dad-a614-4c3d-baf7-e0785b9b58e0", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/26617dad-a614-4c3d-baf7-e0785b9b58e0", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/private_domains/5741faeb-cf7d-4735-afc6-f969dec1dae9/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSharedOrganizationsForPrivateDomainTest()
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
        ""guid"": ""65fb7ec0-cac6-4f93-aa34-addc94dfc2c2"",
        ""url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2"",
        ""created_at"": ""2016-02-09T10:21:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2038"",
        ""billing_enabled"": false,
        ""quota_definition_guid"": ""c7b6d6cc-0344-497e-978c-d40a9f1228fe"",
        ""status"": ""active"",
        ""quota_definition_url"": ""/v2/quota_definitions/c7b6d6cc-0344-497e-978c-d40a9f1228fe"",
        ""spaces_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/spaces"",
        ""domains_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/domains"",
        ""private_domains_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/private_domains"",
        ""users_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/users"",
        ""managers_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/managers"",
        ""billing_managers_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/billing_managers"",
        ""auditors_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/auditors"",
        ""app_events_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/app_events"",
        ""space_quota_definitions_url"": ""/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/space_quota_definitions""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PrivateDomains.ListAllSharedOrganizationsForPrivateDomain(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("65fb7ec0-cac6-4f93-aa34-addc94dfc2c2", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-09T10:21:56Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2038", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].BillingEnabled), true);
                Assert.AreEqual("c7b6d6cc-0344-497e-978c-d40a9f1228fe", TestUtil.ToTestableString(obj[0].QuotaDefinitionGuid), true);
                Assert.AreEqual("active", TestUtil.ToTestableString(obj[0].Status), true);
                Assert.AreEqual("/v2/quota_definitions/c7b6d6cc-0344-497e-978c-d40a9f1228fe", TestUtil.ToTestableString(obj[0].QuotaDefinitionUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/spaces", TestUtil.ToTestableString(obj[0].SpacesUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/private_domains", TestUtil.ToTestableString(obj[0].PrivateDomainsUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/users", TestUtil.ToTestableString(obj[0].UsersUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/billing_managers", TestUtil.ToTestableString(obj[0].BillingManagersUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/organizations/65fb7ec0-cac6-4f93-aa34-addc94dfc2c2/space_quota_definitions", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionsUrl), true);

            }
        }

        [TestMethod]
        public void DeletePrivateDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.PrivateDomains.DeletePrivateDomain(guid).Wait();

            }
        }

    }
}