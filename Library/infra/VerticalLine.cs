using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalLine")]
	public class VerticalLine
	{
		[XmlAttribute("pos")]
		public double pos {get;set;}
		[XmlAttribute("slope")]
		public double slope {get;set;}
	}
}