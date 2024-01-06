using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "linkedPath")]
	public class LinkedPath
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("dirTrackEdge", Namespace = "https://erju.org/")]
		public List<infra.DirTrackEdge>? dirTrackEdges;
		[XmlAttribute("skipFromPathStart")]
		public uint skipFromPathStart {get;set;}
		[XmlAttribute("skipFromPathEnd")]
		public uint skipFromPathEnd {get;set;}
	}
}