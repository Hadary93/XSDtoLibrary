using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_71")]
	public class ETCSPacket_71
	{
		[XmlAttribute("d_adhesion")]
		public uint d_adhesion {get;set;}
		[XmlAttribute("l_adhesion")]
		public uint l_adhesion {get;set;}
		[XmlAttribute("m_adhesion")]
		public bool m_adhesion {get;set;}
	}
}