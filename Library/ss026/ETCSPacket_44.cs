using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_44")]
	public class ETCSPacket_44
	{
		[XmlAttribute("nid_xuser")]
		public uint nid_xuser {get;set;}
		[XmlAttribute("nid_ntc")]
		public uint nid_ntc {get;set;}
		[XmlAttribute("otherData")]
		public string otherData {get;set;}
	}
}