using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_0")]
	public class ETCSPacket_0
	{
		[XmlAttribute("nid_vbcmk")]
		public uint nid_vbcmk {get;set;}
	}
}