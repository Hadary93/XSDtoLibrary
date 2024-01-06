using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_5")]
	public class ETCSPacket_5
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("link", Namespace = "https://erju.org/")]
		public List<ss026.LinkItem>? links;
	}
}