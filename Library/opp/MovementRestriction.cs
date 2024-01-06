using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "movementRestriction")]
	public class MovementRestriction
	{
		[XmlElement(Order=0)]
		public infra.DirTrackEdgePoint? startPoint {get;set;}
		[XmlElement(Order=1)]
		public infra.DirTrackEdgePoint? endPoint {get;set;}
		[XmlElement(Order=2)]
		public opp.SpecificMovementRestriction? specificRestriction {get;set;}
	}
}