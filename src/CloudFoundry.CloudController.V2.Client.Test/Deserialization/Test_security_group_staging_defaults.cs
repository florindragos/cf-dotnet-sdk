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
    public class SecurityGroupStagingDefaultsTest
    {


        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForStagingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""cf962de3-9114-436a-b822-dec3701ce9d8"",
    ""url"": ""/v2/config/staging_security_groups/cf962de3-9114-436a-b822-dec3701ce9d8"",
    ""created_at"": ""2016-02-05T12:14:47Z"",
    ""updated_at"": ""2016-02-05T12:14:47Z""
  },
  ""entity"": {
    ""name"": ""name-1668"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": false,
    ""staging_default"": true
  }
}";

            SetSecurityGroupAsDefaultForStagingResponse obj = Utilities.DeserializeJson<SetSecurityGroupAsDefaultForStagingResponse>(json);

            Assert.AreEqual("cf962de3-9114-436a-b822-dec3701ce9d8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/staging_security_groups/cf962de3-9114-436a-b822-dec3701ce9d8", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:47Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-05T12:14:47Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1668", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.StagingDefault), true);
        }

        [TestMethod]
        public void TestReturnSecurityGroupsUsedForStagingResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""bfa6e793-1734-4e83-a041-2f7293f15022"",
        ""url"": ""/v2/config/staging_security_groups/bfa6e793-1734-4e83-a041-2f7293f15022"",
        ""created_at"": ""2016-02-05T12:14:47Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1667"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": true
      }
    }
  ]
}";

            PagedResponseCollection<ReturnSecurityGroupsUsedForStagingResponse> page = Utilities.DeserializePage<ReturnSecurityGroupsUsedForStagingResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("bfa6e793-1734-4e83-a041-2f7293f15022", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/staging_security_groups/bfa6e793-1734-4e83-a041-2f7293f15022", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:47Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1667", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }
    }
}
