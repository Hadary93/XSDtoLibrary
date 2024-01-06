using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eTCSMarker")]
	public class ETCSMarker
	{
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("trackEdge")]
		public string trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
		[XmlAttribute("markerFunctionStop")]
		public bool markerFunctionStop {get;set;}
	}
}