using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "passengerTransferActivity")]
	public class PassengerTransferActivity
	{
		[XmlAttribute("waitingForEvent")]
		public string waitingForEvent {get;set;}
		[XmlAttribute("transferDuration")]
		public uint transferDuration {get;set;}
	}
}