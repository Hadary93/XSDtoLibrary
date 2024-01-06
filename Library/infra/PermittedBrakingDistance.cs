using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "permittedBrakingDistance")]
	public class PermittedBrakingDistance
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/")]
		public List<infra.TrackEdgeSection>? trackSections;
		[XmlAttribute("pbdDist")]
		public uint pbdDist {get;set;}
		[XmlAttribute("brakeType")]
		public infra.BrakeType brakeType {get;set;}
		[XmlAttribute("pbdGradient")]
		public int pbdGradient {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
	}
}