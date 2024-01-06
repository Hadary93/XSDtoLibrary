using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "specificRestriction")]
	public class SpecificRestriction
	{
		[XmlElement(Order=0)]
		public opp.TrainGroupSpec? appliedToTrips {get;set;}
		[XmlElement(Order=1)]
		public opp.RestrictedAspects? restrictedAspects {get;set;}
	}
}