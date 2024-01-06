using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalLine")]
	public class HorizontalLine
	{
		[XmlAttribute("pos")]
		public double pos {get;set;}
		[XmlAttribute("azimuth")]
		public double azimuth {get;set;}
	}
}