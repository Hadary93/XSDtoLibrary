using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "staticSpeedProfileChange")]
	public class StaticSpeedProfileChange
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("specificStaticSpeedProfileItem", Namespace = "https://erju.org/")]
		public List<infra.SpecificStaticSpeedLimit>? specificStaticSpeedProfile;
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("speed")]
		public uint speed {get;set;}
		[XmlAttribute("trainEndApplicability")]
		public ato.TrainEndApplicability trainEndApplicability {get;set;}
	}
}