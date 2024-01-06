using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalTransition")]
	public class HorizontalTransition
	{
		[XmlAttribute("pos")]
		public double pos {get;set;}
		[XmlAttribute("azimuth")]
		public double azimuth {get;set;}
		[XmlAttribute("radius")]
		public double radius {get;set;}
		[XmlAttribute("type")]
		public infra.TransitionType type {get;set;}
	}
}