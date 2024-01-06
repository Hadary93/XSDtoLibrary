using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "baliseGroup")]
	public class BaliseGroup
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("balis", Namespace = "https://erju.org/")]
		public List<infra.Balise>? balises;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("nidBG")]
		public uint nidBG {get;set;}
		[XmlAttribute("nidC")]
		public uint nidC {get;set;}
		[XmlAttribute("bgFunction")]
		public infra.BaliseGroupFunction bgFunction {get;set;}
	}
}