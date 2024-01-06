using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_46")]
	public class ETCSPacket_46
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("levelTransition", Namespace = "https://erju.org/")]
		public List<ss026.LevelTransition>? levelTransitions;
		[XmlAttribute("m_leveltr")]
		public ss026.EtcsLevel m_leveltr {get;set;}
		[XmlAttribute("nid_ntc")]
		public uint nid_ntc {get;set;}
	}
}