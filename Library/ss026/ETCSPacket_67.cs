using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_67")]
	public class ETCSPacket_67
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("trackCondition", Namespace = "https://erju.org/")]
		public List<ss026.DLTrackCond>? trackConditions;
	}
}