using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "speedProfile")]
	public class SpeedProfile
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("staticSpeedProfileItem", Namespace = "https://erju.org/")]
		public List<infra.StaticSpeedLimit>? staticSpeedProfile;
		[XmlArray(Order=1)]
		[XmlArrayItem("axleLoadSpeedProfile", Namespace = "https://erju.org/")]
		public List<infra.AxleLoadSpeedProfile>? axleLoadSpeedProfiles;
	}
}