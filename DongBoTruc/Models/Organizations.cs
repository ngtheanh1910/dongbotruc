using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DongBoTruc.Models
{
    [XmlRoot(Namespace = "http://www.e-doc.vn/Schema/", ElementName = "Organizations")]
    public class Organizations
    {
        //[XmlNamespaceDeclarations]
        //public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public Organizations()
        {
            //xmlns.Add("edXML", "http://www.e-doc.vn/Schema/");
            organizations = new List<Organization>();
        }

        [XmlElement(ElementName = "Organization")]
        public List<Organization> organizations { get; set; }

        //public Organization this[string name]
        //{
        //    get { return organizations.FirstOrDefault(s => string.Equals(s.OrganId, name, StringComparison.OrdinalIgnoreCase)); }
        //}
    }
}