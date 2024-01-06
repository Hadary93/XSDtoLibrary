using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "specificMovementRestriction")]
	public class SpecificMovementRestriction
	{
		[XmlElement(Order=0)]		public MaxSpeedRef? maxSpeed {get;set;}
		[XmlElement(Order=1)]		public AdhesionCategoryRef? adhesionCategory {get;set;}
	}
}