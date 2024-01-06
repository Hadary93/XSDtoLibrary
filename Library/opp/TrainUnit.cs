using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "trainUnit")]
	public class TrainUnit
	{
		[XmlElement(Order=0)]		public opp.PhysicalTrainUnitIdentifier? physicalTrainUnit {get;set;}
		[XmlElement(Order=1)]		public opp.OperationalTrainCategory? operationalTrainCategory {get;set;}
		[XmlArray(Order=2)]
		[XmlArrayItem("operationalConsist", Namespace = "https://erju.org/")]
		public List<opp.OperationalConsist>? operationalConsists;
		[XmlAttribute("nominalRotatingMass")]
		public uint nominalRotatingMass {get;set;}
		[XmlAttribute("regularBrakeWeightPercentage")]
		public uint regularBrakeWeightPercentage {get;set;}
		[XmlAttribute("emergencyBrakeWeightPercentage")]
		public uint emergencyBrakeWeightPercentage {get;set;}
		[XmlAttribute("brakePosition")]
		public opp.BrakePosition brakePosition {get;set;}
		[XmlAttribute("brakeModelType")]
		public opp.BrakeModelType brakeModelType {get;set;}
		[XmlAttribute("usedGradeOfAutomation")]
		public opp.GradeOfAutomation usedGradeOfAutomation {get;set;}
	}
}