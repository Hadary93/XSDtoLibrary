using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalSegment")]
	public class HorizontalSegment
	{
		[XmlElement(Order=0)]		public infra.HorizontalLine? line {get;set;}
		[XmlElement(Order=1)]		public infra.HorizontalArc? arc {get;set;}
		[XmlElement(Order=2)]		public infra.HorizontalTransition? transition {get;set;}
	}
}