using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "operationalEventRef")]
	public class OperationalEventRef
	{
		[XmlElement(Order=0)]		public MovementEventRef? movementEvent {get;set;}
		[XmlElement(Order=1)]		public RestrictionEventRef? restrictionEvent {get;set;}
		[XmlElement(Order=2)]		public WarningMeasureEventRef? warningMeasureEvent {get;set;}
	}
}