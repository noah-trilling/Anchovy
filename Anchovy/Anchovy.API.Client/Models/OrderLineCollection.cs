﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Anchovy.API.Client.Models;
using Newtonsoft.Json.Linq;

namespace Anchovy.API.Client.Models
{
    public static partial class OrderLineCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<OrderLine> DeserializeJson(JToken inputObject)
        {
            IList<OrderLine> deserializedObject = new List<OrderLine>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                OrderLine orderLine = new OrderLine();
                orderLine.DeserializeJson(iListValue);
                deserializedObject.Add(orderLine);
            }
            return deserializedObject;
        }
    }
}
