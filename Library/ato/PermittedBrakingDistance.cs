using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "permittedBrakingDistance")]
	public class PermittedBrakingDistance
	{
		[XmlElement(Order=0)]
		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute("value")]
		public uint value {get;set;}
		[XmlAttribute("byEmergencyBrake")]
		public bool byEmergencyBrake {get;set;}
		[XmlAttribute("gradient")]
		public int gradient {get;set;}
	}
}