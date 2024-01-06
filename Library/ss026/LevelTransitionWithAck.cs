using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "levelTransitionWithAck")]
	public class LevelTransitionWithAck
	{
		[XmlAttribute("m_leveltr")]
		public ss026.EtcsLevel m_leveltr {get;set;}
		[XmlAttribute("nid_ntc_k")]
		public uint nid_ntc_k {get;set;}
		[XmlAttribute("l_ackleveltr_k")]
		public uint l_ackleveltr_k {get;set;}
	}
}