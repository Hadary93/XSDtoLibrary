using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "axleLoadSpeedProfile")]
	public class AxleLoadSpeedProfile
	{
		[XmlElement(Order=0)]
		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute("speed")]
		public uint speed {get;set;}
		[XmlAttribute("trainEndApplicability")]
		public ato.TrainEndApplicability trainEndApplicability {get;set;}
		[XmlAttribute("axleLoadCategory")]
		public infra.AxleLoadCategory axleLoadCategory {get;set;}
	}
}