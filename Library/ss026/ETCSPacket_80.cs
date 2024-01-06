using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_80")]
	public class ETCSPacket_80
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("modeProfile", Namespace = "https://erju.org/")]
		public List<ss026.ModeProfileItem>? modeProfiles;
	}
}