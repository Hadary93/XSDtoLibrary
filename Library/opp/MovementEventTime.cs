using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "movementEventTime")]
	public class MovementEventTime
	{
		[XmlAttribute("type")]
		public opp.MovementEventTimeType type {get;set;}
		[XmlAttribute("dateTime")]
		public string? dateTime {get;set;}
	}
}