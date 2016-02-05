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
    public class PackagesExperimentalTest
    {


        [TestMethod]
        public void TestGetPackageResponse()
        {
            string json = @"{
  ""guid"": ""guid-f5c39b02-c774-430f-be28-10287de93fd7"",
  ""type"": ""bits"",
  ""hash"": null,
  ""url"": null,
  ""state"": ""AWAITING_UPLOAD"",
  ""error"": null,
  ""created_at"": ""2016-02-05T12:14:40Z"",
  ""updated_at"": null,
  ""_links"": {
    ""self"": {
      ""href"": ""/v3/packages/guid-f5c39b02-c774-430f-be28-10287de93fd7""
    },
    ""upload"": {
      ""href"": ""/v3/packages/guid-f5c39b02-c774-430f-be28-10287de93fd7/upload"",
      ""method"": ""POST""
    },
    ""app"": {
      ""href"": ""/v3/apps/guid-c7389e12-67ab-4718-b1b1-9254e01dccaf""
    }
  }
}";

            GetPackageResponse obj = Utilities.DeserializeJson<GetPackageResponse>(json);

            Assert.AreEqual("guid-f5c39b02-c774-430f-be28-10287de93fd7", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("bits", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Hash), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("AWAITING_UPLOAD", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Error), true);
            Assert.AreEqual("2016-02-05T12:14:40Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestCreatePackageResponse()
        {
            string json = @"{
  ""guid"": ""ca5cd311-0d28-475c-9475-12b348772d18"",
  ""type"": ""docker"",
  ""hash"": null,
  ""url"": ""docker://cloudfoundry/runtime-ci"",
  ""state"": ""READY"",
  ""error"": null,
  ""created_at"": ""2016-02-05T12:14:41Z"",
  ""updated_at"": null,
  ""_links"": {
    ""self"": {
      ""href"": ""/v3/packages/ca5cd311-0d28-475c-9475-12b348772d18""
    },
    ""app"": {
      ""href"": ""/v3/apps/guid-9230b2e8-96a8-4b12-9d6c-762df2822c76""
    }
  }
}";

            CreatePackageResponse obj = Utilities.DeserializeJson<CreatePackageResponse>(json);

            Assert.AreEqual("ca5cd311-0d28-475c-9475-12b348772d18", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("docker", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Hash), true);
            Assert.AreEqual("docker://cloudfoundry/runtime-ci", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("READY", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Error), true);
            Assert.AreEqual("2016-02-05T12:14:41Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestListAllPackagesResponse()
        {
            string json = @"{
  ""pagination"": {
    ""total_results"": 3,
    ""first"": {
      ""href"": ""/v3/packages?page=1=2""
    },
    ""last"": {
      ""href"": ""/v3/packages?page=2=2""
    },
    ""next"": {
      ""href"": ""/v3/packages?page=2=2""
    },
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""guid-f3924d59-57ac-459a-aa06-afd8ae99c0b3"",
      ""type"": ""bits"",
      ""hash"": null,
      ""url"": null,
      ""state"": ""AWAITING_UPLOAD"",
      ""error"": null,
      ""created_at"": ""2016-02-05T12:14:41Z"",
      ""updated_at"": null,
      ""_links"": {
        ""self"": {
          ""href"": ""/v3/packages/guid-f3924d59-57ac-459a-aa06-afd8ae99c0b3""
        },
        ""upload"": {
          ""href"": ""/v3/packages/guid-f3924d59-57ac-459a-aa06-afd8ae99c0b3/upload"",
          ""method"": ""POST""
        },
        ""app"": {
          ""href"": ""/v3/apps/guid-a3e62c7d-3a73-4f70-a61a-32ae2b1dc969""
        }
      }
    },
    {
      ""guid"": ""guid-0a10be20-eeb3-4303-9ecd-d94d1ff3d243"",
      ""type"": ""docker"",
      ""hash"": null,
      ""url"": ""http://docker-repo/my-image"",
      ""state"": ""READY"",
      ""error"": null,
      ""created_at"": ""2016-02-05T12:14:41Z"",
      ""updated_at"": null,
      ""_links"": {
        ""self"": {
          ""href"": ""/v3/packages/guid-0a10be20-eeb3-4303-9ecd-d94d1ff3d243""
        },
        ""app"": {
          ""href"": ""/v3/apps/guid-a3e62c7d-3a73-4f70-a61a-32ae2b1dc969""
        }
      }
    }
  ]
}";

            PagedResponseCollection<ListAllPackagesResponse> page = Utilities.DeserializePage<ListAllPackagesResponse>(json, null);

            Assert.AreEqual("guid-f3924d59-57ac-459a-aa06-afd8ae99c0b3", TestUtil.ToTestableString(page[0].Guid), true);
            Assert.AreEqual("bits", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Hash), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Url), true);
            Assert.AreEqual("AWAITING_UPLOAD", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Error), true);
            Assert.AreEqual("2016-02-05T12:14:41Z", TestUtil.ToTestableString(page[0].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].UpdatedAt), true);
            Assert.AreEqual("guid-0a10be20-eeb3-4303-9ecd-d94d1ff3d243", TestUtil.ToTestableString(page[1].Guid), true);
            Assert.AreEqual("docker", TestUtil.ToTestableString(page[1].Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].Hash), true);
            Assert.AreEqual("http://docker-repo/my-image", TestUtil.ToTestableString(page[1].Url), true);
            Assert.AreEqual("READY", TestUtil.ToTestableString(page[1].State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].Error), true);
            Assert.AreEqual("2016-02-05T12:14:41Z", TestUtil.ToTestableString(page[1].CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].UpdatedAt), true);
        }

        [TestMethod]
        public void TestStagePackageResponse()
        {
            string json = @"{
  ""guid"": ""whatuuid"",
  ""state"": ""PENDING"",
  ""hash"": null,
  ""buildpack_git_url"": ""http://github.com/myorg/awesome-buildpack"",
  ""failure_reason"": null,
  ""detected_start_command"": null,
  ""procfile"": null,
  ""environment_variables"": {
    ""VCAP_APPLICATION"": {
      ""limits"": {
        ""mem"": 1024,
        ""disk"": 4096,
        ""fds"": 16384
      },
      ""application_version"": ""whatuuid"",
      ""application_name"": ""name-403"",
      ""application_uris"": [

      ],
      ""version"": ""whatuuid"",
      ""name"": ""name-403"",
      ""space_name"": ""name-400"",
      ""space_id"": ""d811aafd-8a00-4734-875b-fb98dd51c702"",
      ""uris"": [

      ],
      ""users"": null
    },
    ""CF_STACK"": ""trusty64""
  },
  ""created_at"": ""2016-02-05T12:14:40Z"",
  ""updated_at"": null,
  ""_links"": {
    ""self"": {
      ""href"": ""/v3/droplets/whatuuid""
    },
    ""package"": {
      ""href"": ""/v3/packages/guid-37e71b68-5658-4d0f-b610-7fe3cfabd607""
    },
    ""app"": {
      ""href"": ""/v3/apps/guid-7d4a0b3b-4290-4ce6-92de-f51351782b05""
    }
  }
}";

            StagePackageResponse obj = Utilities.DeserializeJson<StagePackageResponse>(json);

            Assert.AreEqual("whatuuid", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("PENDING", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Hash), true);
            Assert.AreEqual("http://github.com/myorg/awesome-buildpack", TestUtil.ToTestableString(obj.BuildpackGitUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.FailureReason), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DetectedStartCommand), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Procfile), true);
            Assert.AreEqual("2016-02-05T12:14:40Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }
    }
}
