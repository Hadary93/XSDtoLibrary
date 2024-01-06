using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_138")]
	public class ETCSPacket_138
	{
		[XmlAttribute("d_startreverse")]
		public uint d_startreverse {get;set;}
		[XmlAttribute("l_reversearea")]
		public uint l_reversearea {get;set;}
	}
}