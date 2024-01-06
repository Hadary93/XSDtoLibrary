using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "specificStaticSpeedLimit")]
	public class SpecificStaticSpeedLimit
	{
		[XmlElement(Order=0)]
		public infra.SpeedLimitType? specificLimitType {get;set;}
		[XmlAttribute("speed")]
		public uint speed {get;set;}
	}
}