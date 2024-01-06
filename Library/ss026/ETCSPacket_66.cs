using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_66")]
	public class ETCSPacket_66
	{
		[XmlAttribute("nid_tsr")]
		public uint nid_tsr {get;set;}
	}
}