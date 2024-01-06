using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "curveSamplePoint")]
	public class CurveSamplePoint
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("radius")]
		public int radius {get;set;}
	}
}