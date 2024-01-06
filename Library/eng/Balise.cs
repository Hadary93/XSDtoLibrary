using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "balise")]
	public class Balise
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("etcsPacket", Namespace = "https://erju.org/")]
		public List<ss026.BalisePacket>? etcsPackets;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("fixed")]
		public bool _fixed {get;set;}
		[XmlAttribute("q_updown")]
		public bool q_updown {get;set;}
		[XmlAttribute("m_dup")]
		public eng.DuplicationType m_dup {get;set;}
		[XmlAttribute("m_mcount")]
		public uint m_mcount {get;set;}
		[XmlAttribute("verticallyOriented")]
		public bool verticallyOriented {get;set;}
		[XmlAttribute("standardSize")]
		public bool standardSize {get;set;}
		[XmlAttribute("sleeperFastening")]
		public string sleeperFastening {get;set;}
		[XmlAttribute("baliseMountingSystem")]
		public string baliseMountingSystem {get;set;}
		[XmlAttribute("designType")]
		public string designType {get;set;}
		[XmlAttribute("locationReferenceMarker")]
		public string locationReferenceMarker {get;set;}
	}
}