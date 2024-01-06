using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "cantSamplePoint")]
	public class CantSamplePoint
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("appliedCant")]
		public double appliedCant {get;set;}
		[XmlAttribute("cant")]
		public int cant {get;set;}
	}
}