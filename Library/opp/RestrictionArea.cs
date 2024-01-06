using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "restrictionArea")]
	public class RestrictionArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/")]
		public List<infra.DirTrackEdgeSection>? trackEdgeSections;
		[XmlArray(Order=1)]
		[XmlArrayItem("specificRestriction", Namespace = "https://erju.org/")]
		public List<opp.SpecificRestriction>? specificRestrictions;
	}
}