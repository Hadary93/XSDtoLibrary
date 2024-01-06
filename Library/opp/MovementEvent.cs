using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "movementEvent")]
	public class MovementEvent
	{
		[XmlElement(Order=0)]
		public infra.DirTrackEdgePoint? position {get;set;}
		[XmlArray(Order=1)]
		[XmlArrayItem("time", Namespace = "https://erju.org/")]
		public List<opp.MovementEventTime>? times;
		[XmlArray(Order=2)]
		[XmlArrayItem("blockingEvent", Namespace = "https://erju.org/")]
		public List<opp.OperationalEventRef>? blockingEvents;
		[XmlElement(Order=3)]
		public infra.LinkedPath? trackPathToNextEvent {get;set;}
		[XmlElement(Order=4)]
		public opp.StopDescription? stopDescription {get;set;}
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("type")]
		public opp.MovementType type {get;set;}
		[XmlAttribute("alignment")]
		public opp.AlignmentType alignment {get;set;}
	}
}