using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "restrictedAspects")]
	public class RestrictedAspects
	{
		[XmlAttribute("temporarySpeedRestriction")]
		public uint temporarySpeedRestriction {get;set;}
		[XmlAttribute("allowedDrivingModes")]
		public opp.TrainDrivingMode allowedDrivingModes {get;set;}
		[XmlAttribute("nonStoppingArea")]
		public bool nonStoppingArea {get;set;}
		[XmlAttribute("operationalRadioHole")]
		public bool operationalRadioHole {get;set;}
		[XmlAttribute("maxAdhesion")]
		public opp.AdhesionRate maxAdhesion {get;set;}
	}
}