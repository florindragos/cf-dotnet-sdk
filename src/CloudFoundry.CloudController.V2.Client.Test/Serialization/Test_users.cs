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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class UsersTest
    {

        [TestMethod]
        public void TestUpdateUserRequest()
        {
            string json = @"{
  ""default_space_guid"": ""bbddd541-be00-4a79-bcda-7fdedb62945e""
}";

            UpdateUserRequest request = new UpdateUserRequest();

            request.DefaultSpaceGuid = new Guid("bbddd541-be00-4a79-bcda-7fdedb62945e");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
        [TestMethod]
        public void TestCreateUserRequest()
        {
            string json = @"{
  ""guid"": ""guid-10ae4a5f-c615-4d52-9d6c-3480a3a4c47e""
}";

            CreateUserRequest request = new CreateUserRequest();

            request.Guid = "guid-10ae4a5f-c615-4d52-9d6c-3480a3a4c47e";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
    }
}
