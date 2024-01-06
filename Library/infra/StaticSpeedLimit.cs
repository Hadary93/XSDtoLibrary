using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "staticSpeedLimit")]
	public class StaticSpeedLimit
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("specificStaticSpeedLimit", Namespace = "https://erju.org/")]
		public List<infra.SpecificStaticSpeedLimit>? specificStaticSpeedLimits;
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("speed")]
		public uint speed {get;set;}
	}
}