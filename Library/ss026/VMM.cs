using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "vMM")]
	public class VMM
	{
		[XmlAttribute("v_nvkvint_k_m")]
		public uint v_nvkvint_k_m {get;set;}
		[XmlAttribute("m_nvkvint_k_m")]
		public uint m_nvkvint_k_m {get;set;}
		[XmlAttribute("m_nvkvint_k_m_2")]
		public uint m_nvkvint_k_m_2 {get;set;}
	}
}