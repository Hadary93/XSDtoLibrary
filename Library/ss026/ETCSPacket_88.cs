using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_88")]
	public class ETCSPacket_88
	{
		[XmlElement(Order=0)]
		public ss026.LXStatus? lxStatus {get;set;}
		[XmlAttribute("nid_lx")]
		public uint nid_lx {get;set;}
		[XmlAttribute("d_lx")]
		public uint d_lx {get;set;}
		[XmlAttribute("l_lx")]
		public uint l_lx {get;set;}
	}
}