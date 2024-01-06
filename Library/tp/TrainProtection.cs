using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "trainProtection")]
	public class TrainProtection
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("tpAreaItem", Namespace = "https://erju.org/")]
		public List<tp.TrainProtectionArea>? tpArea;
	}
}