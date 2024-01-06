using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "tractionSystem")]
	public class TractionSystem
	{
		[XmlAttribute("d_voltage")]
		public ss026.TractionSystemVoltageType d_voltage {get;set;}
		[XmlAttribute("nid_ctraction")]
		public uint nid_ctraction {get;set;}
	}
}