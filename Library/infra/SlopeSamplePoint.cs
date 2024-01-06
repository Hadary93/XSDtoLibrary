using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "slopeSamplePoint")]
	public class SlopeSamplePoint
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("slope")]
		public int slope {get;set;}
	}
}