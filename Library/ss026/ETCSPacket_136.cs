using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_136")]
	public class ETCSPacket_136
	{
		[XmlElement(Order=0)]		public ss026.NewCountry? newCountry {get;set;}
		[XmlAttribute("nid_bg")]
		public uint nid_bg {get;set;}
	}
}