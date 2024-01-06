using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_133")]
	public class ETCSPacket_133
	{
		[XmlAttribute("q_riu")]
		public bool q_riu {get;set;}
		[XmlAttribute("nid_c")]
		public uint nid_c {get;set;}
		[XmlAttribute("nid_riu")]
		public uint nid_riu {get;set;}
		[XmlAttribute("nid_radio")]
		public uint nid_radio {get;set;}
		[XmlAttribute("d_infill")]
		public uint d_infill {get;set;}
		[XmlAttribute("nid_bg")]
		public uint nid_bg {get;set;}
	}
}