using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_132")]
	public class ETCSPacket_132
	{
		[XmlAttribute("q_aspect")]
		public bool q_aspect {get;set;}
	}
}