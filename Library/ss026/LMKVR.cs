using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "lMKVR")]
	public class LMKVR
	{
		[XmlAttribute("l_nvkrint_l")]
		public uint l_nvkrint_l {get;set;}
		[XmlAttribute("m_nvkrint_l")]
		public uint m_nvkrint_l {get;set;}
	}
}