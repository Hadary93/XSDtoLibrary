using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "segmentSection")]
	public class SegmentSection
	{
		[XmlAttribute("range")]
		public ato.RangeType range {get;set;}
		[XmlAttribute("pStart")]
		public uint pStart {get;set;}
		[XmlAttribute("pEnd")]
		public uint pEnd {get;set;}
	}
}