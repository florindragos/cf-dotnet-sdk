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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class AppsTest
    {

        [TestMethod]
        public void TestAssignDropletAsAppsCurrentDropletRequest()
        {
            string json = @"{
  ""desired_droplet_guid"": ""guid-71f0b415-c533-499f-b2e6-5b23458f0d94""
}";

            AssignDropletAsAppsCurrentDropletRequest request = new AssignDropletAsAppsCurrentDropletRequest();

            request.DesiredDropletGuid = "guid-71f0b415-c533-499f-b2e6-5b23458f0d94";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateAppRequest()
        {
            string json = @"{
  ""name"": ""new_name"",
  ""environment_variables"": {
    ""MY_ENV_VAR"": ""foobar"",
    ""FOOBAR"": ""MY_ENV_VAR""
  }
}";

            UpdateAppRequest request = new UpdateAppRequest();

            request.Name = "new_name";
            request.EnvironmentVariables = TestUtil.GetJsonDictonary(@"{""MY_ENV_VAR"":""foobar"",""FOOBAR"":""MY_ENV_VAR""}");

            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestScalingProcessFromItsAppRequest()
        {
            string json = @"{
  ""instances"": 3
}";

            ScalingProcessFromItsAppRequest request = new ScalingProcessFromItsAppRequest();

            request.Instances = 3;
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateAppRequest()
        {
            string json = @"{
  ""name"": ""my_app"",
  ""space_guid"": ""7f257247-1447-47cd-8791-5066b6574499"",
  ""environment_variables"": {
    ""open"": ""source""
  }
}";

            CreateAppRequest request = new CreateAppRequest();

            request.Name = "my_app";
            request.SpaceGuid = new Guid("7f257247-1447-47cd-8791-5066b6574499");
            request.EnvironmentVariables = TestUtil.GetJsonDictonary(@"{""open"":""source""}");

            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
