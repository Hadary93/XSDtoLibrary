using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "trackCondSelection")]
	public class TrackCondSelection
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("dlmCond", Namespace = "https://erju.org/")]
		public List<ss026.DLMCondition>? dlmConds;
		[XmlElement(Order=1)]		public D_trackinitRef? d_trackinit {get;set;}
	}
}