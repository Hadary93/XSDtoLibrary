using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "geoPosItem")]
	public class GeoPosItem
	{
		[XmlElement(Order=0)]		public ss026.NewCountry? newCountry {get;set;}
		[XmlAttribute("nid_bg")]
		public uint nid_bg {get;set;}
		[XmlAttribute("d_posoff")]
		public uint d_posoff {get;set;}
		[XmlAttribute("q_mposition")]
		public bool q_mposition {get;set;}
		[XmlAttribute("m_position")]
		public uint m_position {get;set;}
	}
}