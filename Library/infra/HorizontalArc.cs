using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalArc")]
	public class HorizontalArc
	{
		[XmlAttribute("pos")]
		public double pos {get;set;}
		[XmlAttribute("azimuth")]
		public double azimuth {get;set;}
		[XmlAttribute("radius")]
		public double radius {get;set;}
	}
}