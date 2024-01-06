using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "fieldObjectController")]
	public class FieldObjectController
	{
		[XmlElement(Order=0)]
		public tp.ControlledInfraElement? controlledInfraElement {get;set;}
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("ipAddresses")]
		public string? ipAddresses {get;set;}
	}
}