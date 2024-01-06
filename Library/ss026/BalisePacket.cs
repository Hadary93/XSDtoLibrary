using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "balisePacket")]
	public class BalisePacket
	{
		[XmlElement(Order=0)]		public ss026.Packet? packet {get;set;}
		[XmlAttribute("nid")]
		public uint nid {get;set;}
		[XmlAttribute("q_dir")]
		public ss026.QDir q_dir {get;set;}
	}
}