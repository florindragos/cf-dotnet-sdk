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

using CloudFoundry.CloudController.V3.Client;
using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V3.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class DropletsExperimentalTest
    {


        [TestMethod]
        public void TestFiltersDropletsByStatesAppGuidsResponse()
        {
            string json = @"{
  ""pagination"": {
    ""total_results"": 2,
    ""first"": {
      ""href"": ""/v3/droplets?app_guids=71f80c08-cae8-41c8-b92c-bb58f132b179=-created_at=1=2=STAGED%2CFAILED""
    },
    ""last"": {
      ""href"": ""/v3/droplets?app_guids=71f80c08-cae8-41c8-b92c-bb58f132b179=-created_at=1=2=STAGED%2CFAILED""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""1c5b5cdd-ae53-449e-8175-5a80880a029b"",
      ""state"": ""STAGED"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-2479"",
          ""stack"": ""name-2480""
        }
      },
      ""memory_limit"": 123,
      ""disk_limit"": 456,
      ""result"": {
        ""buildpack"": ""https://github.com/cloudfoundry/detected-buildpack.git"",
        ""stack"": null,
        ""process_types"": {
          ""web"": ""started""
        },
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": ""my-hash""
        },
        ""execution_metadata"": ""black-box-secrets""
      },
      ""environment_variables"": {

      },
      ""created_at"": ""1970-01-01T00:00:02Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/b0b5caa6-ca02-4f2e-a6a2-be4d175b1bc6""
        },
        ""package"": {
          ""href"": ""/v3/packages/326e8e05-a85f-4ec3-8481-da1eccf2bd2a""
        },
        ""app"": {
          ""href"": ""/v3/apps/71f80c08-cae8-41c8-b92c-bb58f132b179""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/71f80c08-cae8-41c8-b92c-bb58f132b179/current_droplet"",
          ""method"": ""PUT""
        }
      }
    },
    {
      ""guid"": ""1c5b5cdd-ae53-449e-8175-5a80880a029b"",
      ""state"": ""FAILED"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-2483"",
          ""stack"": ""name-2484""
        }
      },
      ""memory_limit"": null,
      ""disk_limit"": null,
      ""result"": {
        ""buildpack"": ""https://github.com/cloudfoundry/my-buildpack.git"",
        ""stack"": null,
        ""process_types"": null,
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": ""my-hash""
        },
        ""execution_metadata"": null
      },
      ""environment_variables"": {

      },
      ""created_at"": ""1970-01-01T00:00:02Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/bff1505f-c645-4ce0-993d-848cfaf07c15""
        },
        ""package"": {
          ""href"": ""/v3/packages/326e8e05-a85f-4ec3-8481-da1eccf2bd2a""
        },
        ""app"": {
          ""href"": ""/v3/apps/71f80c08-cae8-41c8-b92c-bb58f132b179""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/71f80c08-cae8-41c8-b92c-bb58f132b179/current_droplet"",
          ""method"": ""PUT""
        }
      }
    }
  ]
}";

            PagedResponseCollection<FiltersDropletsByStatesAppGuidsResponse> page = Utilities.DeserializePage<FiltersDropletsByStatesAppGuidsResponse>(json, null);

            Assert.AreEqual("1c5b5cdd-ae53-449e-8175-5a80880a029b", TestUtil.ToTestableString(page[0].Guid), true);
            Assert.AreEqual("STAGED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Error), true);
            Assert.AreEqual("123", TestUtil.ToTestableString(page[0].MemoryLimit), true);
            Assert.AreEqual("456", TestUtil.ToTestableString(page[0].DiskLimit), true);
            Assert.AreEqual("1970-01-01T00:00:02Z", TestUtil.ToTestableString(page[0].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].UpdatedAt), true);
            Assert.AreEqual("1c5b5cdd-ae53-449e-8175-5a80880a029b", TestUtil.ToTestableString(page[1].Guid), true);
            Assert.AreEqual("FAILED", TestUtil.ToTestableString(page[1].State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].Error), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].MemoryLimit), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].DiskLimit), true);
            Assert.AreEqual("1970-01-01T00:00:02Z", TestUtil.ToTestableString(page[1].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].UpdatedAt), true);
        }

        [TestMethod]
        public void TestGetDropletResponse()
        {
            string json = @"{
  ""guid"": ""1a527fb7-0ab7-4b2f-8e90-90f9a51e1941"",
  ""state"": ""STAGED"",
  ""error"": ""example error"",
  ""lifecycle"": {
    ""type"": ""buildpack"",
    ""data"": {
      ""buildpack"": ""name-2441"",
      ""stack"": ""name-2442""
    }
  },
  ""memory_limit"": null,
  ""disk_limit"": null,
  ""result"": {
    ""buildpack"": ""http://buildpack.git.url.com"",
    ""stack"": null,
    ""process_types"": null,
    ""hash"": {
      ""type"": ""sha1"",
      ""value"": null
    },
    ""execution_metadata"": null
  },
  ""environment_variables"": {
    ""cloud"": ""foundry""
  },
  ""created_at"": ""2016-07-07T09:17:17Z"",
  ""updated_at"": null,
  ""links"": {
    ""self"": {
      ""href"": ""/v3/droplets/28722cfd-25ed-4549-b8bd-d95ed61da888""
    },
    ""package"": {
      ""href"": ""/v3/packages/10dbd5a6-b25e-4f19-ba94-122094f4734f""
    },
    ""app"": {
      ""href"": ""/v3/apps/81134907-8a13-497a-ac16-1cbf9c1f9dab""
    },
    ""assign_current_droplet"": {
      ""href"": ""/v3/apps/81134907-8a13-497a-ac16-1cbf9c1f9dab/current_droplet"",
      ""method"": ""PUT""
    }
  }
}";

            GetDropletResponse obj = Utilities.DeserializeJson<GetDropletResponse>(json);

            Assert.AreEqual("1a527fb7-0ab7-4b2f-8e90-90f9a51e1941", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("example error", TestUtil.ToTestableString(obj.Error), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DiskLimit), true);
            Assert.AreEqual("2016-07-07T09:17:17Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestListAllDropletsResponse()
        {
            string json = @"{
  ""pagination"": {
    ""total_results"": 2,
    ""first"": {
      ""href"": ""/v3/droplets?order_by=-created_at=1=2""
    },
    ""last"": {
      ""href"": ""/v3/droplets?order_by=-created_at=1=2""
    },
    ""next"": null,
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""14a47ed7-79ca-4d00-91c7-89fca182766e"",
      ""state"": ""STAGED"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-2461"",
          ""stack"": ""name-2462""
        }
      },
      ""memory_limit"": 123,
      ""disk_limit"": 456,
      ""result"": {
        ""buildpack"": ""https://github.com/cloudfoundry/detected-buildpack.git"",
        ""stack"": null,
        ""process_types"": {
          ""web"": ""started""
        },
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": ""my-hash""
        },
        ""execution_metadata"": ""black-box-secrets""
      },
      ""environment_variables"": {

      },
      ""created_at"": ""1970-01-01T00:00:02Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/b6ed93a7-702a-42bb-9507-7d570aa577f7""
        },
        ""package"": {
          ""href"": ""/v3/packages/95e8b98c-74a9-47ac-a3bd-1ddd0a023a3f""
        },
        ""app"": {
          ""href"": ""/v3/apps/e3f24fb2-8329-4159-8b81-772dd07e8ef2""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/e3f24fb2-8329-4159-8b81-772dd07e8ef2/current_droplet"",
          ""method"": ""PUT""
        }
      }
    },
    {
      ""guid"": ""14a47ed7-79ca-4d00-91c7-89fca182766e"",
      ""state"": ""STAGING"",
      ""error"": null,
      ""lifecycle"": {
        ""type"": ""buildpack"",
        ""data"": {
          ""buildpack"": ""name-2463"",
          ""stack"": ""name-2464""
        }
      },
      ""memory_limit"": null,
      ""disk_limit"": null,
      ""result"": {
        ""buildpack"": ""name-2451"",
        ""stack"": null,
        ""process_types"": null,
        ""hash"": {
          ""type"": ""sha1"",
          ""value"": null
        },
        ""execution_metadata"": null
      },
      ""environment_variables"": {
        ""yuu"": ""huuu""
      },
      ""created_at"": ""1970-01-01T00:00:01Z"",
      ""updated_at"": null,
      ""links"": {
        ""self"": {
          ""href"": ""/v3/droplets/6690198d-6ffd-41db-95be-069ccc79de19""
        },
        ""package"": {
          ""href"": ""/v3/packages/95e8b98c-74a9-47ac-a3bd-1ddd0a023a3f""
        },
        ""app"": {
          ""href"": ""/v3/apps/e3f24fb2-8329-4159-8b81-772dd07e8ef2""
        },
        ""assign_current_droplet"": {
          ""href"": ""/v3/apps/e3f24fb2-8329-4159-8b81-772dd07e8ef2/current_droplet"",
          ""method"": ""PUT""
        },
        ""buildpack"": {
          ""href"": ""/v2/buildpacks/b72a779c-29e8-47d2-9e0e-d3d638b9158b""
        }
      }
    }
  ]
}";

            PagedResponseCollection<ListAllDropletsResponse> page = Utilities.DeserializePage<ListAllDropletsResponse>(json, null);

            Assert.AreEqual("14a47ed7-79ca-4d00-91c7-89fca182766e", TestUtil.ToTestableString(page[0].Guid), true);
            Assert.AreEqual("STAGED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Error), true);
            Assert.AreEqual("123", TestUtil.ToTestableString(page[0].MemoryLimit), true);
            Assert.AreEqual("456", TestUtil.ToTestableString(page[0].DiskLimit), true);
            Assert.AreEqual("1970-01-01T00:00:02Z", TestUtil.ToTestableString(page[0].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].UpdatedAt), true);
            Assert.AreEqual("14a47ed7-79ca-4d00-91c7-89fca182766e", TestUtil.ToTestableString(page[1].Guid), true);
            Assert.AreEqual("STAGING", TestUtil.ToTestableString(page[1].State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].Error), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].MemoryLimit), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].DiskLimit), true);
            Assert.AreEqual("1970-01-01T00:00:01Z", TestUtil.ToTestableString(page[1].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].UpdatedAt), true);
        }
    }
}
