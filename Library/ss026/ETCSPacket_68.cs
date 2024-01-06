using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_68")]
	public class ETCSPacket_68
	{
		[XmlElement(Order=0)]
		public ss026.TrackCondSelection? trackCondSelection {get;set;}
	}
}