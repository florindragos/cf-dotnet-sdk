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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicesTest
    {


        [TestMethod]
        public void TestRetrieveServiceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""63f44fd4-de96-4fbc-a853-9ed65e62176c"",
    ""url"": ""/v2/services/63f44fd4-de96-4fbc-a853-9ed65e62176c"",
    ""created_at"": ""2016-02-05T12:14:55Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-88"",
    ""provider"": null,
    ""url"": null,
    ""description"": ""desc-214"",
    ""long_description"": null,
    ""version"": null,
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""8a235f72-63f8-4c92-9d7f-0afb85264773"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""ef3dc938-8cb8-48e6-a080-63502b364b00"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/63f44fd4-de96-4fbc-a853-9ed65e62176c/service_plans""
  }
}";

            RetrieveServiceResponse obj = Utilities.DeserializeJson<RetrieveServiceResponse>(json);

            Assert.AreEqual("63f44fd4-de96-4fbc-a853-9ed65e62176c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/63f44fd4-de96-4fbc-a853-9ed65e62176c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-88", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("desc-214", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("8a235f72-63f8-4c92-9d7f-0afb85264773", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("ef3dc938-8cb8-48e6-a080-63502b364b00", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/63f44fd4-de96-4fbc-a853-9ed65e62176c/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestUpdateServiceDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""59fb9241-208b-4d1e-9d5f-c8820fb9d520"",
    ""url"": ""/v2/services/59fb9241-208b-4d1e-9d5f-c8820fb9d520"",
    ""created_at"": ""2016-02-05T12:14:54Z"",
    ""updated_at"": ""2016-02-05T12:14:54Z""
  },
  ""entity"": {
    ""label"": ""SomeMysqlService"",
    ""provider"": ""MySql Provider"",
    ""url"": ""http://myql.provider.com"",
    ""description"": ""Mysql stores things for you"",
    ""long_description"": null,
    ""version"": ""2.0"",
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""e9826824-49ff-4f67-9d4d-50528d5a8bcd"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""5183d40c-5438-40c4-9382-a47f0cde4352"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/59fb9241-208b-4d1e-9d5f-c8820fb9d520/service_plans""
  }
}";

            UpdateServiceDeprecatedResponse obj = Utilities.DeserializeJson<UpdateServiceDeprecatedResponse>(json);

            Assert.AreEqual("59fb9241-208b-4d1e-9d5f-c8820fb9d520", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/59fb9241-208b-4d1e-9d5f-c8820fb9d520", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:54Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-05T12:14:54Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("SomeMysqlService", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("MySql Provider", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("http://myql.provider.com", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("Mysql stores things for you", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("2.0", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("e9826824-49ff-4f67-9d4d-50528d5a8bcd", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("5183d40c-5438-40c4-9382-a47f0cde4352", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/59fb9241-208b-4d1e-9d5f-c8820fb9d520/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestListAllServicesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""a580afb6-3e4e-424b-af0e-6f01fc066379"",
        ""url"": ""/v2/services/a580afb6-3e4e-424b-af0e-6f01fc066379"",
        ""created_at"": ""2016-02-05T12:14:55Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-87"",
        ""provider"": null,
        ""url"": null,
        ""description"": ""desc-213"",
        ""long_description"": null,
        ""version"": null,
        ""info_url"": null,
        ""active"": true,
        ""bindable"": true,
        ""unique_id"": ""e8f721a5-0b0a-4076-b98e-26260e70ef94"",
        ""extra"": null,
        ""tags"": [

        ],
        ""requires"": [

        ],
        ""documentation_url"": null,
        ""service_broker_guid"": ""79a6cada-a433-45ab-8ba6-fd2c22e371e4"",
        ""plan_updateable"": false,
        ""service_plans_url"": ""/v2/services/a580afb6-3e4e-424b-af0e-6f01fc066379/service_plans""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicesResponse> page = Utilities.DeserializePage<ListAllServicesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("a580afb6-3e4e-424b-af0e-6f01fc066379", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/a580afb6-3e4e-424b-af0e-6f01fc066379", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:55Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-87", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Provider), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Url), true);
            Assert.AreEqual("desc-213", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].LongDescription), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Bindable), true);
            Assert.AreEqual("e8f721a5-0b0a-4076-b98e-26260e70ef94", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DocumentationUrl), true);
            Assert.AreEqual("79a6cada-a433-45ab-8ba6-fd2c22e371e4", TestUtil.ToTestableString(page[0].ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].PlanUpdateable), true);
            Assert.AreEqual("/v2/services/a580afb6-3e4e-424b-af0e-6f01fc066379/service_plans", TestUtil.ToTestableString(page[0].ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlansForServiceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""fb548f89-dfa9-49fa-bbb1-1edc43dcc559"",
        ""url"": ""/v2/service_plans/fb548f89-dfa9-49fa-bbb1-1edc43dcc559"",
        ""created_at"": ""2016-02-05T12:14:55Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2293"",
        ""free"": false,
        ""description"": ""desc-217"",
        ""service_guid"": ""ef408646-72be-4b69-8776-f6c689a595a8"",
        ""extra"": null,
        ""unique_id"": ""ae550683-096b-474f-979f-e0222b76c90c"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/ef408646-72be-4b69-8776-f6c689a595a8"",
        ""service_instances_url"": ""/v2/service_plans/fb548f89-dfa9-49fa-bbb1-1edc43dcc559/service_instances""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlansForServiceResponse> page = Utilities.DeserializePage<ListAllServicePlansForServiceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("fb548f89-dfa9-49fa-bbb1-1edc43dcc559", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/fb548f89-dfa9-49fa-bbb1-1edc43dcc559", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:55Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2293", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Free), true);
            Assert.AreEqual("desc-217", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("ef408646-72be-4b69-8776-f6c689a595a8", TestUtil.ToTestableString(page[0].ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("ae550683-096b-474f-979f-e0222b76c90c", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("/v2/services/ef408646-72be-4b69-8776-f6c689a595a8", TestUtil.ToTestableString(page[0].ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/fb548f89-dfa9-49fa-bbb1-1edc43dcc559/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ef44e760-a0cb-4e13-95a0-aa906fbed340"",
    ""url"": ""/v2/services/ef44e760-a0cb-4e13-95a0-aa906fbed340"",
    ""created_at"": ""2016-02-05T12:14:55Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""SomeMysqlService"",
    ""provider"": ""MySql Provider"",
    ""url"": ""http://myql.provider.com"",
    ""description"": ""Mysql stores things for you"",
    ""long_description"": null,
    ""version"": ""2.0"",
    ""info_url"": null,
    ""active"": false,
    ""bindable"": true,
    ""unique_id"": null,
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": null,
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/ef44e760-a0cb-4e13-95a0-aa906fbed340/service_plans""
  }
}";

            CreateServiceDeprecatedResponse obj = Utilities.DeserializeJson<CreateServiceDeprecatedResponse>(json);

            Assert.AreEqual("ef44e760-a0cb-4e13-95a0-aa906fbed340", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/ef44e760-a0cb-4e13-95a0-aa906fbed340", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("SomeMysqlService", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("MySql Provider", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("http://myql.provider.com", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("Mysql stores things for you", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("2.0", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/ef44e760-a0cb-4e13-95a0-aa906fbed340/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }
    }
}
