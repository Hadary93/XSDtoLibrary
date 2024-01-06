using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "stopDescription")]
	public class StopDescription
	{
		[XmlElement(Order=0)]		public opp.StopTimes? stopTimes {get;set;}
		[XmlArray(Order=1)]
		[XmlArrayItem("trainUnitActivity", Namespace = "https://erju.org/")]
		public List<opp.TrainUnitActivity>? trainUnitActivities;
		[XmlArray(Order=2)]
		[XmlArrayItem("platformEdge", Namespace = "https://erju.org/")]
		public List<PlatformEdgeRef?>? platformEdges;
		[XmlArray(Order=3)]
		[XmlArrayItem("passengerTransferActivity", Namespace = "https://erju.org/")]
		public List<opp.PassengerTransferActivity>? passengerTransferActivities;
		[XmlAttribute("stopType")]
		public opp.StopType stopType {get;set;}
		[XmlAttribute("stopSkipped")]
		public bool stopSkipped {get;set;}
		[XmlAttribute("openingDoorSide")]
		public opp.DoorSide openingDoorSide {get;set;}
		[XmlAttribute("centralisedOpening")]
		public bool centralisedOpening {get;set;}
		[XmlAttribute("centralisedClosing")]
		public bool centralisedClosing {get;set;}
		[XmlAttribute("changeOfGradeOfAutomation")]
		public bool changeOfGradeOfAutomation {get;set;}
		[XmlAttribute("relaxedCoupler")]
		public bool relaxedCoupler {get;set;}
		[XmlAttribute("holdTrain")]
		public bool holdTrain {get;set;}
	}
}