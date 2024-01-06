using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_79")]
	public class ETCSPacket_79
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("geoPosItem", Namespace = "https://erju.org/")]
		public List<ss026.GeoPosItem>? geoPosItems;
	}
}