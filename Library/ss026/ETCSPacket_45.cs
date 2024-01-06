using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_45")]
	public class ETCSPacket_45
	{
		[XmlAttribute("nid_mn")]
		public uint nid_mn {get;set;}
	}
}