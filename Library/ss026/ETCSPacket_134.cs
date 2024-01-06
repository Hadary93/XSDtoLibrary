using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_134")]
	public class ETCSPacket_134
	{
		[XmlAttribute("nid_loop")]
		public uint nid_loop {get;set;}
		[XmlAttribute("d_loop")]
		public uint d_loop {get;set;}
		[XmlAttribute("l_loop")]
		public uint l_loop {get;set;}
		[XmlAttribute("q_loopdir")]
		public bool q_loopdir {get;set;}
		[XmlAttribute("q_sscode")]
		public uint q_sscode {get;set;}
	}
}