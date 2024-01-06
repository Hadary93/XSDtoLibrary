using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKV")]
	public class NKV
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("item", Namespace = "https://erju.org/")]
		public List<ss026.NKVItem>? items;
		[XmlArray(Order=1)]
		[XmlArrayItem("qvItemItem", Namespace = "https://erju.org/")]
		public List<ss026.NKVSubItem>? qvItem;
		[XmlArray(Order=2)]
		[XmlArrayItem("lmkvr", Namespace = "https://erju.org/")]
		public List<ss026.LMKVR>? lmkvrs;
		[XmlAttribute("q_nvkint")]
		public bool q_nvkint {get;set;}
		[XmlAttribute("q_nvkvintset")]
		public ss026.KVType q_nvkvintset {get;set;}
		[XmlAttribute("a_nvp12")]
		public uint a_nvp12 {get;set;}
		[XmlAttribute("a_nvp23")]
		public uint a_nvp23 {get;set;}
		[XmlAttribute("v_nvkvint")]
		public uint v_nvkvint {get;set;}
		[XmlAttribute("m_nvkvint")]
		public double m_nvkvint {get;set;}
		[XmlAttribute("m_nvkvint_2")]
		public uint m_nvkvint_2 {get;set;}
		[XmlAttribute("m_nvkrint")]
		public uint m_nvkrint {get;set;}
	}
}