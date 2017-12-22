﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesWebAPI
{
    public class ConfigurationModel
    {
        /// <summary>
        /// Holds connection string to the Transactions DB
        /// </summary>
        public String TransactionsConnectionString { get; set; }

    }
}