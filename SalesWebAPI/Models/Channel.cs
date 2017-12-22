using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SalesWebAPI.Models
{
    public class Channel
    {
        /// <summary>
        /// Destination Code or Channel
        /// </summary>
        [DataMember(IsRequired = true)]
        [JsonProperty(Order = 1)]
        public string DestCode { get; set; }

        /// <summary>
        /// List of paytypes for the channel
        /// </summary>
        [DataMember(IsRequired = true)]
        [JsonProperty(Order = 2)]
        public List<Pay> PayTypes { get; set; }

        /// <summary>
        /// Default Contstructor
        /// </summary>
        public Channel()
        {

        }
    }
}