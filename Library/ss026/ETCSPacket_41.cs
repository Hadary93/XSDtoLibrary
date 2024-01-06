using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_41")]
	public class ETCSPacket_41
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("levelTransition", Namespace = "https://erju.org/")]
		public List<ss026.LevelTransitionWithAck>? levelTransitions;
		[XmlAttribute("d_leveltr")]
		public uint d_leveltr {get;set;}
		[XmlAttribute("m_leveltr")]
		public ss026.EtcsLevel m_leveltr {get;set;}
		[XmlAttribute("nid_ntc")]
		public uint nid_ntc {get;set;}
		[XmlAttribute("l_ackleveltr")]
		public uint l_ackleveltr {get;set;}
	}
}