using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "engArea")]
	public class EngArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/")]
		public List<eng.SimplePoint>? simplePoints;
		[XmlArray(Order=1)]
		[XmlArrayItem("crossing", Namespace = "https://erju.org/")]
		public List<eng.Crossing>? crossings;
		[XmlArray(Order=2)]
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/")]
		public List<eng.LevelCrossing>? levelCrossings;
		[XmlArray(Order=3)]
		[XmlArrayItem("baliseGroupItem", Namespace = "https://erju.org/")]
		public List<eng.BaliseGroup>? baliseGroup;
		[XmlArray(Order=4)]
		[XmlArrayItem("balis", Namespace = "https://erju.org/")]
		public List<eng.Balise>? balises;
		[XmlArray(Order=5)]
		[XmlArrayItem("sleeper", Namespace = "https://erju.org/")]
		public List<eng.Sleepers>? sleepers;
		[XmlArray(Order=6)]
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/")]
		public List<eng.DangerPoint>? dangerPoints;
		[XmlArray(Order=7)]
		[XmlArrayItem("foulingPoint", Namespace = "https://erju.org/")]
		public List<eng.FoulingPoint>? foulingPoints;
		[XmlArray(Order=8)]
		[XmlArrayItem("bufferStop", Namespace = "https://erju.org/")]
		public List<eng.BufferStop>? bufferStops;
		[XmlArray(Order=9)]
		[XmlArrayItem("mileageArea", Namespace = "https://erju.org/")]
		public List<eng.MileageArea>? mileageAreas;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("defaultSleepersType")]
		public eng.SleepersType defaultSleepersType {get;set;}
	}
}