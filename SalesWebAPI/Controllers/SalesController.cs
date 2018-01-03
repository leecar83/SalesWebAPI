using SalesWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalesWebAPI.Controllers
{
    /// <summary>
    /// Main Controller for sales data
    /// </summary>
    public class SalesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Posts a Restaurant sales data object to the database(updates or adds)
        /// </summary>
        /// <param name="sales">Sales Object</param>
        /// <returns></returns>
        public int Post([FromBody]RestaurantSales sales)
        {
            return sales.UploadData();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
