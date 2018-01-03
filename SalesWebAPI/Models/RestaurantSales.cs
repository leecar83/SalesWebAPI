using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SalesWebAPI.Models
{
    /// <summary>
    /// Represents ones restaurant sales data object
    /// </summary>
    [DataContract]
    public class RestaurantSales
    {
        /// <summary>
        /// Restaurant Number
        /// </summary>
        [DataMember(IsRequired = true)]
        [JsonProperty(Order = 1)]
        public int RestNumber { get; set; }

        /// <summary>
        /// Business Hour
        /// </summary>
        [DataMember(IsRequired = true)]
        [JsonProperty(Order = 2)]
        public List<int> BusinessHour { get; set; }

        /// <summary>
        /// List of Channels or Destination Types
        /// </summary>
        [DataMember(IsRequired = true)]
        [JsonProperty(Order = 3)]
        public List<Channel> Channels { get; set; }

        /// <summary>
        /// Data Access object for accessing the data layer
        /// </summary>
        DataAccess dataAccess = new DataAccess();

        /// <summary>
        /// Default Constor
        /// </summary>
        public RestaurantSales()
        {
            
        }

        /// <summary>
        /// Uploads daily sales data to DataBase
        /// </summary>
        /// <returns>Restaurant Number</returns>
        public int UploadData()
        {
            foreach (Channel channel in Channels)
            {
                foreach (Pay pay in channel.PayTypes)
                {
                    try
                    {
                        HourlyRecordModel hourlyRecord = new HourlyRecordModel();
                        hourlyRecord.RestNum = RestNumber;
                        hourlyRecord.setBusinsessHourFromArray(BusinessHour.ToArray());
                        hourlyRecord.Sales = Decimal.Parse(pay.Sales);
                        hourlyRecord.DestCode = channel.DestCode;
                        hourlyRecord.PayType = pay.PayType;
                        if (hourlyRecord.propertiesNotNull())
                        {
                            dataAccess.addHourlyRecord(hourlyRecord);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return RestNumber;
        }
    }
}