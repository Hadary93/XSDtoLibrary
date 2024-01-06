using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "trainProtectionArea")]
	public class TrainProtectionArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("dpsGroup", Namespace = "https://erju.org/")]
		public List<tp.DriveProtectionSectionGroup>? dpsGroups;
		[XmlArray(Order=1)]
		[XmlArrayItem("allocationSection", Namespace = "https://erju.org/")]
		public List<tp.AllocationSection>? allocationSections;
		[XmlArray(Order=2)]
		[XmlArrayItem("fieldObjectController", Namespace = "https://erju.org/")]
		public List<tp.FieldObjectController>? fieldObjectControllers;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}