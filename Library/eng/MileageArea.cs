using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageArea")]
	public class MileageArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("mileageLine", Namespace = "https://erju.org/")]
		public List<eng.MileageLine>? mileageLines;
		[XmlAttribute("id")]
		public string? id {get;set;}
	}
}