using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "crossing")]
	public class Crossing
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("foulingPoint", Namespace = "https://erju.org/")]
		public List<FoulingPointRef?>? foulingPoints;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}