using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_39")]
	public class ETCSPacket_39
	{
		[XmlAttribute("d_traction")]
		public uint d_traction {get;set;}
		[XmlAttribute("m_voltage")]
		public ss026.TractionSystemVoltageType m_voltage {get;set;}
		[XmlAttribute("nid_ctraction")]
		public uint nid_ctraction {get;set;}
	}
}