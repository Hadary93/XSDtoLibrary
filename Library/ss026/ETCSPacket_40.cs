using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_40")]
	public class ETCSPacket_40
	{
		[XmlAttribute("d_current")]
		public uint d_current {get;set;}
		[XmlAttribute("m_current")]
		public uint m_current {get;set;}
	}
}