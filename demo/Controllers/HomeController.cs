﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
  
        public class Customer
        {
            public string CustomerName { get; set; }
            public string Address { get; set; }
        
        public override string ToString()
{
     return this.CustomerName+"|"+this.Address;
}}
        public class HomeController : Controller
    {
            public Customer GetCustomer()
            {
                Customer c = new Customer();
                c.CustomerName = "Customer 1";
                c.Address = "Address1";
                return c;
            }
       

        }
        }
        


    

