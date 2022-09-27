using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DongBoTruc.Models
{
    [XmlRoot(Namespace = "http://www.e-doc.vn/Schema/")]
    public class Organization
    {
        //[XmlNamespaceDeclarations]
        //public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public string OrganId { get; set; }
        public string OrganName { get; set; }
        public string OrganizationInCharge { get; set; }
        public string OrganAdd { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public bool agency { get; set; }
        public bool send_vpcp { get; set; }
        public bool is_integrator_center { get; set; }
        public string domain_new { get; set; }

        public bool isChecked { get; set; }
        public Organization()
        {
            //xmlns.Add("edXML", "http://www.e-doc.vn/Schema/");
            //OrganName = "";
            //OrganizationInCharge = "";
            //OrganAdd = "";
            //Email = "";
            //Fax = "";
            //Website = "";
            //Telephone = "";
            //agency = true;
            //send_vpcp = true;
            //is_integrator_center = true;
            //domain_new = "";
            isChecked = false;
        }
    }
}