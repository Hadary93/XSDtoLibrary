using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "pBDSelection")]
	public class PBDSelection
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("pbd", Namespace = "https://erju.org/")]
		public List<ss026.PermittedBrakingDist>? pbds;
		[XmlElement(Order=1)]		public D_trackinitRef? d_trackinit {get;set;}
	}
}