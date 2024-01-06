using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "atoArea")]
	public class AtoArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("timingPoint", Namespace = "https://erju.org/")]
		public List<infra.TimingPoint>? timingPoints;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string? versionTimestamp {get;set;}
	}
}