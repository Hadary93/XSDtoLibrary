using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_6")]
	public class ETCSPacket_6
	{
		[XmlElement(Order=0)]		public ss026.ValidityPeriod? validityPeriod {get;set;}
		[XmlAttribute("nid_c")]
		public uint nid_c {get;set;}
	}
}