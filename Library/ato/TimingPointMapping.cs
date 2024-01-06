using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "timingPointMapping")]
	public class TimingPointMapping
	{
		[XmlAttribute("infraTimingPoint")]
		public string infraTimingPoint {get;set;}
		[XmlAttribute("atoTimingPoint")]
		public string atoTimingPoint {get;set;}
	}
}