using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_65")]
	public class ETCSPacket_65
	{
		[XmlAttribute("nid_tsr")]
		public uint nid_tsr {get;set;}
		[XmlAttribute("d_tsr")]
		public uint d_tsr {get;set;}
		[XmlAttribute("l_tsr")]
		public uint l_tsr {get;set;}
		[XmlAttribute("q_front")]
		public bool q_front {get;set;}
		[XmlAttribute("v_tsr")]
		public uint v_tsr {get;set;}
	}
}