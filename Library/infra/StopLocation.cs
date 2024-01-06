using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopLocation")]
	public class StopLocation
	{
		[XmlElement(Order=0)]
		public infra.StopTrainLimit? stopTrainLimit {get;set;}
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("trackEdge")]
		public string? trackEdge {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("sameDir")]
		public bool sameDir {get;set;}
		[XmlAttribute("trainLoadType")]
		public infra.TrainLoadType trainLoadType {get;set;}
		[XmlAttribute("doorOpeningSide")]
		public infra.DoorOpeningSide doorOpeningSide {get;set;}
	}
}