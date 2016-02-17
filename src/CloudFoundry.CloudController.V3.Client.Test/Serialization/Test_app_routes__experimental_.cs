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
    public class AppRoutesExperimentalTest
    {

        [TestMethod]
        public void TestUnmapRouteRequest()
        {
            string json = @"{
  ""route_guid"": ""d45b41a6-f546-482f-867b-8d07def13b9b""
}";

            UnmapRouteRequest request = new UnmapRouteRequest();

            request.RouteGuid = new Guid("d45b41a6-f546-482f-867b-8d07def13b9b");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestMapRouteRequest()
        {
            string json = @"{
  ""route_guid"": ""8dfbdb9c-9883-4b54-90dc-e1d4f70da6b3""
}";

            MapRouteRequest request = new MapRouteRequest();

            request.RouteGuid = new Guid("8dfbdb9c-9883-4b54-90dc-e1d4f70da6b3");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
