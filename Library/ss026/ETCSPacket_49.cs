using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_49")]
	public class ETCSPacket_49
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("balis", Namespace = "https://erju.org/")]
		public List<ss026.CountryBalise>? balises;
	}
}