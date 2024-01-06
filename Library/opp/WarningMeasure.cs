using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "warningMeasure")]
	public class WarningMeasure
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("area", Namespace = "https://erju.org/")]
		public List<opp.WarningArea>? areas;
		[XmlArray(Order=1)]
		[XmlArrayItem("event", Namespace = "https://erju.org/")]
		public List<opp.WarningMeasureEvent>? events;
		[XmlAttribute("id")]
		public string? id {get;set;}
	}
}