using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "tunnel")]
	public class Tunnel
	{
		[XmlElement(Order=0)]
		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute("type")]
		public ato.TunnelType type {get;set;}
	}
}