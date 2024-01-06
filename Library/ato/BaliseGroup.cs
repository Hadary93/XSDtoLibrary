using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "baliseGroup")]
	public class BaliseGroup
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("balis", Namespace = "https://erju.org/")]
		public List<ato.Balise>? balises;
		[XmlAttribute("nidBG")]
		public uint nidBG {get;set;}
		[XmlAttribute("nidCQualifier")]
		public bool nidCQualifier {get;set;}
		[XmlAttribute("nidC")]
		public uint nidC {get;set;}
	}
}