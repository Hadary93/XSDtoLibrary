using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_69")]
	public class ETCSPacket_69
	{
		[XmlElement(Order=0)]		public ss026.TrackCondPlatformSelection? trackCondPlatformSelection {get;set;}
	}
}