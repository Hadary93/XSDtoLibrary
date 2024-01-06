using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "limitedDynamicBrakeForce")]
	public class LimitedDynamicBrakeForce
	{
		[XmlElement(Order=0)]		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute("dynamicBrakeForceLimit")]
		public uint dynamicBrakeForceLimit {get;set;}
	}
}