using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadSelection")]
	public class AxleLoadSelection
	{
		[XmlElement(Order=0)]		public ss026.AxleLoad? axleLoad {get;set;}
		[XmlElement(Order=1)]		public D_trackinitRef? d_trackinit {get;set;}
	}
}