using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "timingPoint")]
	public class TimingPoint
	{
		[XmlAttribute("nidTP")]
		public uint nidTP {get;set;}
		[XmlAttribute("name")]
		public string? name {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("stopLocationTolerance")]
		public ato.StopLocationTolerance stopLocationTolerance {get;set;}
		[XmlAttribute("stoppingPointReachDistance")]
		public ato.StopLocationTolerance stoppingPointReachDistance {get;set;}
	}
}