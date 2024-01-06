using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKVItem")]
	public class NKVItem
	{
		[XmlAttribute("v_nvkvint")]
		public uint v_nvkvint {get;set;}
		[XmlAttribute("m_nvkvint")]
		public uint m_nvkvint {get;set;}
	}
}