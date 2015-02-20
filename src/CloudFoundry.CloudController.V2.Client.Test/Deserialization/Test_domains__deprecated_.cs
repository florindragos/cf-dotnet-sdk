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
    public class DomainsDeprecatedTest
    {


        [TestMethod]
        public void TestCreatesDomainOwnedByGivenOrganizationDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""651c62e8-b235-47a1-9bf2-ae9b08eb796f"",
    ""url"": ""/v2/domains/651c62e8-b235-47a1-9bf2-ae9b08eb796f"",
    ""created_at"": ""2015-02-19T03:52:37+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""87dcf00c-0a3c-4f1c-abb0-9a64934f2afe"",
    ""owning_organization_url"": ""/v2/organizations/87dcf00c-0a3c-4f1c-abb0-9a64934f2afe"",
    ""spaces_url"": ""/v2/domains/651c62e8-b235-47a1-9bf2-ae9b08eb796f/spaces""
  }
}";

            CreatesDomainOwnedByGivenOrganizationDeprecatedResponse obj = Utilities.DeserializeJson<CreatesDomainOwnedByGivenOrganizationDeprecatedResponse>(json);

            Assert.AreEqual("651c62e8-b235-47a1-9bf2-ae9b08eb796f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/651c62e8-b235-47a1-9bf2-ae9b08eb796f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:37+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("87dcf00c-0a3c-4f1c-abb0-9a64934f2afe", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/87dcf00c-0a3c-4f1c-abb0-9a64934f2afe", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/domains/651c62e8-b235-47a1-9bf2-ae9b08eb796f/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestRetrieveDomainDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""80499b4b-a7cf-4a28-b39d-5db443c4ec54"",
    ""url"": ""/v2/domains/80499b4b-a7cf-4a28-b39d-5db443c4ec54"",
    ""created_at"": ""2015-02-19T03:52:37+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""domain-14.example.com""
  }
}";

            RetrieveDomainDeprecatedResponse obj = Utilities.DeserializeJson<RetrieveDomainDeprecatedResponse>(json);

            Assert.AreEqual("80499b4b-a7cf-4a28-b39d-5db443c4ec54", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/80499b4b-a7cf-4a28-b39d-5db443c4ec54", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:37+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-14.example.com", TestUtil.ToTestableString(obj.Name), true);
        }

        [TestMethod]
        public void TestListAllDomainsDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""859d4bbf-7168-4605-9bf2-3ca30eaabe89"",
        ""url"": ""/v2/domains/859d4bbf-7168-4605-9bf2-3ca30eaabe89"",
        ""created_at"": ""2015-02-19T03:52:35+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""a5ad3443-8491-4ccc-bc05-899f96595902"",
        ""url"": ""/v2/domains/a5ad3443-8491-4ccc-bc05-899f96595902"",
        ""created_at"": ""2015-02-19T03:52:35+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""eab0aacf-8df4-493f-a016-e325f3db7840"",
        ""url"": ""/v2/domains/eab0aacf-8df4-493f-a016-e325f3db7840"",
        ""created_at"": ""2015-02-19T03:52:35+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""c8bd4b24-f577-4e9b-a29b-79a472f14c81"",
        ""owning_organization_url"": ""/v2/organizations/c8bd4b24-f577-4e9b-a29b-79a472f14c81"",
        ""spaces_url"": ""/v2/domains/eab0aacf-8df4-493f-a016-e325f3db7840/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""1d1a1af0-5294-42df-aac0-7035c6d44410"",
        ""url"": ""/v2/domains/1d1a1af0-5294-42df-aac0-7035c6d44410"",
        ""created_at"": ""2015-02-19T03:52:37+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-10.example.com""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllDomainsDeprecatedResponse> page = Utilities.DeserializePage<ListAllDomainsDeprecatedResponse>(json);

            Assert.AreEqual("4", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("859d4bbf-7168-4605-9bf2-3ca30eaabe89", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/859d4bbf-7168-4605-9bf2-3ca30eaabe89", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:35+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("a5ad3443-8491-4ccc-bc05-899f96595902", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/a5ad3443-8491-4ccc-bc05-899f96595902", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:35+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("eab0aacf-8df4-493f-a016-e325f3db7840", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/eab0aacf-8df4-493f-a016-e325f3db7840", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:35+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("c8bd4b24-f577-4e9b-a29b-79a472f14c81", TestUtil.ToTestableString(page[2].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/c8bd4b24-f577-4e9b-a29b-79a472f14c81", TestUtil.ToTestableString(page[2].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/domains/eab0aacf-8df4-493f-a016-e325f3db7840/spaces", TestUtil.ToTestableString(page[2].SpacesUrl), true);
            Assert.AreEqual("1d1a1af0-5294-42df-aac0-7035c6d44410", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/1d1a1af0-5294-42df-aac0-7035c6d44410", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:37+00:00", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-10.example.com", TestUtil.ToTestableString(page[3].Name), true);
        }

        [TestMethod]
        public void TestListAllSpacesForDomainDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""ae1ce7c6-7df2-469e-9675-096ab6e07460"",
        ""url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460"",
        ""created_at"": ""2015-02-19T03:52:37+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-160"",
        ""organization_guid"": ""eb80cb19-4811-40e9-af35-8c330a456d31"",
        ""space_quota_definition_guid"": null,
        ""organization_url"": ""/v2/organizations/eb80cb19-4811-40e9-af35-8c330a456d31"",
        ""developers_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/developers"",
        ""managers_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/managers"",
        ""auditors_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/auditors"",
        ""apps_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/apps"",
        ""routes_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/routes"",
        ""domains_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/domains"",
        ""service_instances_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/service_instances"",
        ""app_events_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/app_events"",
        ""events_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/events"",
        ""security_groups_url"": ""/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/security_groups""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpacesForDomainDeprecatedResponse> page = Utilities.DeserializePage<ListAllSpacesForDomainDeprecatedResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("ae1ce7c6-7df2-469e-9675-096ab6e07460", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:37+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-160", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("eb80cb19-4811-40e9-af35-8c330a456d31", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionGuid), true);
            Assert.AreEqual("/v2/organizations/eb80cb19-4811-40e9-af35-8c330a456d31", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/developers", TestUtil.ToTestableString(page[0].DevelopersUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/spaces/ae1ce7c6-7df2-469e-9675-096ab6e07460/security_groups", TestUtil.ToTestableString(page[0].SecurityGroupsUrl), true);
        }

        [TestMethod]
        public void TestCreatesSharedDomainDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""9b7a8d0d-43e7-41a4-a5b6-469699c5730f"",
    ""url"": ""/v2/domains/9b7a8d0d-43e7-41a4-a5b6-469699c5730f"",
    ""created_at"": ""2015-02-19T03:52:37+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com"",
    ""owning_organization_guid"": null
  }
}";

            CreatesSharedDomainDeprecatedResponse obj = Utilities.DeserializeJson<CreatesSharedDomainDeprecatedResponse>(json);

            Assert.AreEqual("9b7a8d0d-43e7-41a4-a5b6-469699c5730f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/9b7a8d0d-43e7-41a4-a5b6-469699c5730f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-02-19T03:52:37+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
        }
    }
}
