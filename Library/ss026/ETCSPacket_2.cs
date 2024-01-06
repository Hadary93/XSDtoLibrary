using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_2")]
	public class ETCSPacket_2
	{
		[XmlAttribute("m_version")]
		public ss026.ETCSVersion m_version {get;set;}
	}
}