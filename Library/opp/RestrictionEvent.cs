using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "restrictionEvent")]
	public class RestrictionEvent
	{
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("restrictions")]
		public string? restrictions {get;set;}
		[XmlAttribute("start")]
		public bool start {get;set;}
		[XmlAttribute("alignment")]
		public opp.AlignmentType alignment {get;set;}
	}
}