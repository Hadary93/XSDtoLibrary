using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_180")]
	public class ETCSPacket_180
	{
		[XmlAttribute("q_lssma")]
		public bool q_lssma {get;set;}
		[XmlAttribute("t_lssma")]
		public uint t_lssma {get;set;}
	}
}