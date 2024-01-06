using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "warningMeasureEvent")]
	public class WarningMeasureEvent
	{
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("warningArea")]
		public string warningArea {get;set;}
		[XmlAttribute("activation")]
		public bool activation {get;set;}
		[XmlAttribute("alignment")]
		public opp.AlignmentType alignment {get;set;}
	}
}