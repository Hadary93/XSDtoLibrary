using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalSegment")]
	public class VerticalSegment
	{
		[XmlElement(Order=0)]		public infra.VerticalLine? line {get;set;}
		[XmlElement(Order=1)]		public infra.VerticalArc? arc {get;set;}
	}
}