using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SalesWebAPI.Models
{
    /// <summary>
    /// Class to hold Paytype
    /// </summary>
    public class Pay
    {
        /// <summary>
        /// Paytype
        /// </summary>
        [DataMember(IsRequired = true)]
        [JsonProperty(Order = 1)]
        public string PayType { get; set; }

        /// <summary>
        /// The sales for the paytype
        /// </summary>
        [DataMember(IsRequired = true)]
        [JsonProperty(Order = 2)]
        public String Sales { get; set; }

        /// <summary>
        /// Default Contstructor
        /// </summary>
        public Pay()
        {

        }
    }
}