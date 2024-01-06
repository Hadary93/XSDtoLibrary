using System.Xml.Serialization;
namespace map
{
	[XmlRoot(Namespace = "https://erju.org/map", ElementName = "trackEdgeCoordinate")]
	public class TrackEdgeCoordinate
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("x")]
		public double x {get;set;}
		[XmlAttribute("y")]
		public double y {get;set;}
		[XmlAttribute("z")]
		public double z {get;set;}
		[XmlAttribute("accPos")]
		public uint accPos {get;set;}
		[XmlAttribute("accX")]
		public double accX {get;set;}
		[XmlAttribute("accY")]
		public double accY {get;set;}
		[XmlAttribute("accZ")]
		public double accZ {get;set;}
	}
}