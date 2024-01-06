using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOSegment")]
	public class ATOSegment
	{
		[XmlElement(Order=0)]		public infra.TrackEdgeSection? trackSection {get;set;}
		[XmlElement(Order=1)]		public ato.SegmentProfile? segmentProfile {get;set;}
		[XmlAttribute("id")]
		public uint id {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
	}
}