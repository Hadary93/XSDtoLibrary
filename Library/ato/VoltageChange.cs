using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageChange")]
	public class VoltageChange
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("voltage")]
		public infra.VoltageType voltage {get;set;}
		[XmlAttribute("nidC")]
		public uint nidC {get;set;}
	}
}