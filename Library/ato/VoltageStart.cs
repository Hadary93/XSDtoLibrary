using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageStart")]
	public class VoltageStart
	{
		[XmlAttribute("voltage")]
		public infra.VoltageType voltage {get;set;}
		[XmlAttribute("nidC")]
		public uint nidC {get;set;}
	}
}