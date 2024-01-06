using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_72")]
	public class ETCSPacket_72
	{
		[XmlAttribute("q_textclass")]
		public ss026.TextClass q_textclass {get;set;}
		[XmlAttribute("q_textdisplay")]
		public bool q_textdisplay {get;set;}
		[XmlAttribute("d_textdisplay")]
		public uint d_textdisplay {get;set;}
		[XmlAttribute("m_modetextdisplay")]
		public ss026.DisplayOperatingMode m_modetextdisplay {get;set;}
		[XmlAttribute("m_leveltextdisplay")]
		public ss026.DisplayOperatingLevel m_leveltextdisplay {get;set;}
		[XmlAttribute("nid_ntc")]
		public uint nid_ntc {get;set;}
		[XmlAttribute("l_textdisplay")]
		public uint l_textdisplay {get;set;}
		[XmlAttribute("t_textdisplay")]
		public uint t_textdisplay {get;set;}
		[XmlAttribute("q_textconfirm")]
		public ss026.TextConfirmationType q_textconfirm {get;set;}
		[XmlAttribute("q_conftextdisplay")]
		public bool q_conftextdisplay {get;set;}
		[XmlAttribute("q_textreport")]
		public bool q_textreport {get;set;}
		[XmlAttribute("nid_textmessage")]
		public uint nid_textmessage {get;set;}
		[XmlAttribute("nid_c")]
		public uint nid_c {get;set;}
		[XmlAttribute("nid_rbc")]
		public uint nid_rbc {get;set;}
		[XmlAttribute("text")]
		public string text {get;set;}
	}
}