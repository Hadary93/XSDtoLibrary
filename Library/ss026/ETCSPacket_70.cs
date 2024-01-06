using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_70")]
	public class ETCSPacket_70
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("routeSuitability", Namespace = "https://erju.org/")]
		public List<ss026.RouteSuitability>? routeSuitabilities;
		[XmlElement(Order=1)]
		public D_trackinitRef? d_trackinit {get;set;}
	}
}