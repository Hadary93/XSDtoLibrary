using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_16")]
	public class ETCSPacket_16
	{
		[XmlAttribute("l_section")]
		public uint l_section {get;set;}
	}
}