using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_137")]
	public class ETCSPacket_137
	{
		[XmlAttribute("q_srstop")]
		public bool q_srstop {get;set;}
	}
}