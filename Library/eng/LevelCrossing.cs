using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "levelCrossing")]
	public class LevelCrossing
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/")]
		public List<DangerPointRef?>? dangerPoints;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}