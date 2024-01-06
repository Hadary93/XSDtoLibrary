using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOArea")]
	public class ATOArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("segment", Namespace = "https://erju.org/")]
		public List<ato.ATOSegment>? segments;
		[XmlArray(Order=1)]
		[XmlArrayItem("timingPointsMappingItem", Namespace = "https://erju.org/")]
		public List<ato.TimingPointMapping>? timingPointsMapping;
		[XmlAttribute("id")]
		public string id {get;set;}
	}
}