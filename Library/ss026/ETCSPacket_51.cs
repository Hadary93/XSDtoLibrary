using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_51")]
	public class ETCSPacket_51
	{
		[XmlElement(Order=0)]
		public ss026.AxleLoadSelection? axleLoadSelection {get;set;}
	}
}