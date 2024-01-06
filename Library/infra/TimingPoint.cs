using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "timingPoint")]
	public class TimingPoint
	{
		[XmlElement(Order=0)]
		public infra.TPActiveObject? activeObject {get;set;}
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
	}
}