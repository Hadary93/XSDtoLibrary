using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "staticSpeedProfileStart")]
	public class StaticSpeedProfileStart
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("specificStaticSpeedProfileItem", Namespace = "https://erju.org/")]
		public List<infra.SpecificStaticSpeedLimit>? specificStaticSpeedProfile;
		[XmlAttribute("speed")]
		public uint speed {get;set;}
		[XmlAttribute("trainEndApplicability")]
		public ato.TrainEndApplicability trainEndApplicability {get;set;}
	}
}