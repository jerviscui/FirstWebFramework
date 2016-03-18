using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace WebApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string AddressAAA { get; set; }
    }
}