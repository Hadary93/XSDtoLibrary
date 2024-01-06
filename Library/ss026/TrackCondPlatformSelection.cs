using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "trackCondPlatformSelection")]
	public class TrackCondPlatformSelection
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("tcspCond", Namespace = "https://erju.org/")]
		public List<ss026.TCSPCondition>? tcspConds;
		[XmlElement(Order=1)]		public D_trackinitRef? d_trackinit {get;set;}
	}
}