using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "axleLoadSpeedProfile")]
	public class AxleLoadSpeedProfile
	{
		[XmlAttribute("startPos")]
		public uint startPos {get;set;}
		[XmlAttribute("endPos")]
		public uint endPos {get;set;}
		[XmlAttribute("speed")]
		public uint speed {get;set;}
		[XmlAttribute("axleLoadCategory")]
		public infra.AxleLoadCategory axleLoadCategory {get;set;}
	}
}