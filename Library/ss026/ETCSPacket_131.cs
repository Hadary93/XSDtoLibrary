using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_131")]
	public class ETCSPacket_131
	{
		[XmlAttribute("d_rbctr")]
		public uint d_rbctr {get;set;}
		[XmlAttribute("nid_c")]
		public uint nid_c {get;set;}
		[XmlAttribute("nid_rbc")]
		public uint nid_rbc {get;set;}
		[XmlAttribute("nid_radio")]
		public uint nid_radio {get;set;}
		[XmlAttribute("q_sleepsession")]
		public bool q_sleepsession {get;set;}
	}
}