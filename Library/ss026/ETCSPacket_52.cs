using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_52")]
	public class ETCSPacket_52
	{
		[XmlElement(Order=0)]		public ss026.PBDSelection? pbdSelection {get;set;}
	}
}