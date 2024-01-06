using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_3")]
	public class ETCSPacket_3
	{
		[XmlElement(Order=0)]		public ss026.NKV? nkvItem {get;set;}
		[XmlAttribute("d_validnv")]
		public uint d_validnv {get;set;}
		[XmlAttribute("nid_c")]
		public uint nid_c {get;set;}
		[XmlAttribute("nid_c_k")]
		public uint nid_c_k {get;set;}
		[XmlAttribute("v_nvshunt")]
		public uint v_nvshunt {get;set;}
		[XmlAttribute("v_nvstff")]
		public uint v_nvstff {get;set;}
		[XmlAttribute("v_nvonsight")]
		public uint v_nvonsight {get;set;}
		[XmlAttribute("v_nvlimsuperv")]
		public uint v_nvlimsuperv {get;set;}
		[XmlAttribute("v_nvunfit")]
		public uint v_nvunfit {get;set;}
		[XmlAttribute("v_nvrel")]
		public uint v_nvrel {get;set;}
		[XmlAttribute("d_nvroll")]
		public uint d_nvroll {get;set;}
		[XmlAttribute("q_nvsbtsmperm")]
		public bool q_nvsbtsmperm {get;set;}
		[XmlAttribute("q_nvemrrls")]
		public bool q_nvemrrls {get;set;}
		[XmlAttribute("q_nvguiperm")]
		public bool q_nvguiperm {get;set;}
		[XmlAttribute("q_nvsbfbperm")]
		public bool q_nvsbfbperm {get;set;}
		[XmlAttribute("q_nvinhsmicperm")]
		public bool q_nvinhsmicperm {get;set;}
		[XmlAttribute("v_nvallowovtrp")]
		public uint v_nvallowovtrp {get;set;}
		[XmlAttribute("v_nvsupovtrp")]
		public uint v_nvsupovtrp {get;set;}
		[XmlAttribute("d_nvovtrp")]
		public uint d_nvovtrp {get;set;}
		[XmlAttribute("t_nvovtrp")]
		public uint t_nvovtrp {get;set;}
		[XmlAttribute("d_nvpotrp")]
		public uint d_nvpotrp {get;set;}
		[XmlAttribute("m_nvcontact")]
		public ss026.NVContact m_nvcontact {get;set;}
		[XmlAttribute("t_nvcontact")]
		public uint t_nvcontact {get;set;}
		[XmlAttribute("m_nvderun")]
		public bool m_nvderun {get;set;}
		[XmlAttribute("d_nvstff")]
		public uint d_nvstff {get;set;}
		[XmlAttribute("q_nvdriver_adhes")]
		public bool q_nvdriver_adhes {get;set;}
		[XmlAttribute("a_nvmaxredadh1")]
		public uint a_nvmaxredadh1 {get;set;}
		[XmlAttribute("a_nvmaxredadh2")]
		public uint a_nvmaxredadh2 {get;set;}
		[XmlAttribute("a_nvmaxredadh3")]
		public uint a_nvmaxredadh3 {get;set;}
		[XmlAttribute("q_nvlocacc")]
		public uint q_nvlocacc {get;set;}
		[XmlAttribute("m_nvavadh")]
		public uint m_nvavadh {get;set;}
		[XmlAttribute("m_nvebcl")]
		public uint m_nvebcl {get;set;}
	}
}