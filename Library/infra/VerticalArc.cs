using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalArc")]
	public class VerticalArc
	{
		[XmlAttribute("pos")]
		public double pos {get;set;}
		[XmlAttribute("slope")]
		public double slope {get;set;}
		[XmlAttribute("radius")]
		public double radius {get;set;}
	}
}