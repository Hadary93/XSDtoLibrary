using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_141")]
	public class ETCSPacket_141
	{
		[XmlAttribute("g_tsr")]
		public int g_tsr {get;set;}
	}
}