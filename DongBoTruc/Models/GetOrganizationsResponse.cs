using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DongBoTruc.Models
{
    [XmlRoot(Namespace = "http://www.e-doc.vn/Schema/", ElementName = "GetOrganizationsResponse")]
    public class GetOrganizationsResponse
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public GetOrganizationsResponse()
        {
            xmlns.Add("edXML", "http://www.e-doc.vn/Schema/");
            Organizations = new Organizations();
        }

        [XmlElement(ElementName = "Organizations")]
        public Organizations Organizations { get; set; }

        //public Organization this[string name]
        //{
        //    get { return organizations.FirstOrDefault(s => string.Equals(s.OrganId, name, StringComparison.OrdinalIgnoreCase)); }
        //}
    }
}