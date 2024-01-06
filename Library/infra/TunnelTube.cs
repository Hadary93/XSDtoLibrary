using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tunnelTube")]
	public class TunnelTube
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackSections;
		[XmlAttribute("crossSection")]
		public uint crossSection {get;set;}
	}
}