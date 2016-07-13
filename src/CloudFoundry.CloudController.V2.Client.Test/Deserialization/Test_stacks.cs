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
    public class StacksTest
    {


        [TestMethod]
        public void TestCreateStackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ee32715d-bb69-4216-8f97-3d7a395cac14"",
    ""url"": ""/v2/stacks/4882d7e7-21c6-4fb1-94cf-91e9b7ea52de"",
    ""created_at"": ""2016-07-07T09:17:17Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example_stack"",
    ""description"": ""Description for the example stack""
  }
}";

            CreateStackResponse obj = Utilities.DeserializeJson<CreateStackResponse>(json);

            Assert.AreEqual("ee32715d-bb69-4216-8f97-3d7a395cac14", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/4882d7e7-21c6-4fb1-94cf-91e9b7ea52de", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:17:17Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("example_stack", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("Description for the example stack", TestUtil.ToTestableString(obj.Description), true);
        }

        [TestMethod]
        public void TestListAllStacksResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""a13c38a6-6926-44a9-9527-68fbd27f1286"",
        ""url"": ""/v2/stacks/7a14c36f-8147-450d-8d1f-5920e1a1cb46"",
        ""created_at"": ""2016-07-07T09:16:48Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cflinuxfs2"",
        ""description"": ""cflinuxfs2""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""a13c38a6-6926-44a9-9527-68fbd27f1286"",
        ""url"": ""/v2/stacks/51ce774e-3af7-483b-bd2d-5e3d1b70b445"",
        ""created_at"": ""2016-07-07T09:16:48Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default-stack-name"",
        ""description"": ""default-stack-description""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""a13c38a6-6926-44a9-9527-68fbd27f1286"",
        ""url"": ""/v2/stacks/e12dea27-b6c1-4631-bbf7-b7ae4c73c366"",
        ""created_at"": ""2016-07-07T09:16:48Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cider"",
        ""description"": ""cider-description""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllStacksResponse> page = Utilities.DeserializePage<ListAllStacksResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("a13c38a6-6926-44a9-9527-68fbd27f1286", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/7a14c36f-8147-450d-8d1f-5920e1a1cb46", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:16:48Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("a13c38a6-6926-44a9-9527-68fbd27f1286", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/51ce774e-3af7-483b-bd2d-5e3d1b70b445", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:16:48Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("default-stack-name", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("default-stack-description", TestUtil.ToTestableString(page[1].Description), true);
            Assert.AreEqual("a13c38a6-6926-44a9-9527-68fbd27f1286", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/e12dea27-b6c1-4631-bbf7-b7ae4c73c366", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:16:48Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("cider", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("cider-description", TestUtil.ToTestableString(page[2].Description), true);
        }

        [TestMethod]
        public void TestRetrieveStackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c0f9f4cb-061e-49b9-8ec7-5cceef372f29"",
    ""url"": ""/v2/stacks/7a14c36f-8147-450d-8d1f-5920e1a1cb46"",
    ""created_at"": ""2016-07-07T09:16:48Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""cflinuxfs2"",
    ""description"": ""cflinuxfs2""
  }
}";

            RetrieveStackResponse obj = Utilities.DeserializeJson<RetrieveStackResponse>(json);

            Assert.AreEqual("c0f9f4cb-061e-49b9-8ec7-5cceef372f29", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/stacks/7a14c36f-8147-450d-8d1f-5920e1a1cb46", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-07T09:16:48Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Description), true);
        }
    }
}
