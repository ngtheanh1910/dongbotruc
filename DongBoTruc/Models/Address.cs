using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DongBoTruc.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string AddressString { get; set; }
        public string EdocId { get; set; }
        public bool IsMe { get; set; }
        public string Alias { get; set; }
        public string GroupName { get; set; }
        public bool IsPublishEmail { get; set; }
        public int LevelEdocId { get; set; }
        public bool HasRecalled { get; set; }
    }
}