using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "simplePoint")]
	public class SimplePoint
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("foulingPoint", Namespace = "https://erju.org/")]
		public List<FoulingPointRef>? foulingPoints;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("tipShift")]
		public double tipShift {get;set;}
		[XmlAttribute("bladeLength")]
		public double bladeLength {get;set;}
	}
}