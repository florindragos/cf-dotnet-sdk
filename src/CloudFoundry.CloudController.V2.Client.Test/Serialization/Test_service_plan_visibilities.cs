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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicePlanVisibilitiesTest
    {

        [TestMethod]
        public void TestUpdateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""ceb7c49d-fb92-4e46-9380-f4622c34bd82"",
  ""organization_guid"": ""c7c03be7-24c1-4c63-b537-4b9df0247605""
}";

            UpdateServicePlanVisibilityRequest request = new UpdateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("ceb7c49d-fb92-4e46-9380-f4622c34bd82");
            request.OrganizationGuid = new Guid("c7c03be7-24c1-4c63-b537-4b9df0247605");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateServicePlanVisibilityRequest()
        {
            string json = @"{
  ""service_plan_guid"": ""25b7e4d5-037c-414b-8467-9c496fdd8850"",
  ""organization_guid"": ""d59a36a5-83aa-4b37-bca3-41bd770a7c52""
}";

            CreateServicePlanVisibilityRequest request = new CreateServicePlanVisibilityRequest();

            request.ServicePlanGuid = new Guid("25b7e4d5-037c-414b-8467-9c496fdd8850");
            request.OrganizationGuid = new Guid("d59a36a5-83aa-4b37-bca3-41bd770a7c52");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
