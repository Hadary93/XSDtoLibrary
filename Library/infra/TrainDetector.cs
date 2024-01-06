using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainDetector")]
	public class TrainDetector
	{
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("trackEdge")]
		public string trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("type")]
		public infra.TrainDetectorType type {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
	}
}