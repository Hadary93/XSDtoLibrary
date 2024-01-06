using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "functionalArea")]
	public class FunctionalArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("opPoint", Namespace = "https://erju.org/")]
		public List<infra.OperationalPoint>? opPoints;
		[XmlArray(Order=1)]
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/")]
		public List<infra.SimplePoint>? simplePoints;
		[XmlArray(Order=2)]
		[XmlArrayItem("slipCrossing", Namespace = "https://erju.org/")]
		public List<infra.SlipCrossing>? slipCrossings;
		[XmlArray(Order=3)]
		[XmlArrayItem("derailer", Namespace = "https://erju.org/")]
		public List<infra.Derailer>? derailers;
		[XmlArray(Order=4)]
		[XmlArrayItem("crossing", Namespace = "https://erju.org/")]
		public List<infra.Crossing>? crossings;
		[XmlArray(Order=5)]
		[XmlArrayItem("trainDetector", Namespace = "https://erju.org/")]
		public List<infra.TrainDetector>? trainDetectors;
		[XmlArray(Order=6)]
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/")]
		public List<infra.BaliseGroup>? baliseGroups;
		[XmlArray(Order=7)]
		[XmlArrayItem("etcsMarker", Namespace = "https://erju.org/")]
		public List<infra.ETCSMarker>? etcsMarkers;
		[XmlArray(Order=8)]
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/")]
		public List<infra.StopLocation>? stopLocations;
		[XmlArray(Order=9)]
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/")]
		public List<infra.Tunnel>? tunnels;
		[XmlArray(Order=10)]
		[XmlArrayItem("bridge", Namespace = "https://erju.org/")]
		public List<infra.Bridge>? bridges;
		[XmlArray(Order=11)]
		[XmlArrayItem("underpass", Namespace = "https://erju.org/")]
		public List<infra.Underpass>? underpasses;
		[XmlArray(Order=12)]
		[XmlArrayItem("tvp", Namespace = "https://erju.org/")]
		public List<infra.TvpSection>? tvps;
		[XmlArray(Order=13)]
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/")]
		public List<infra.LevelCrossing>? levelCrossings;
		[XmlArray(Order=14)]
		[XmlArrayItem("nationalBorder", Namespace = "https://erju.org/")]
		public List<infra.NationalBorder>? nationalBorders;
		[XmlArray(Order=15)]
		[XmlArrayItem("bufferStop", Namespace = "https://erju.org/")]
		public List<infra.BufferStop>? bufferStops;
		[XmlAttribute("id")]
		public string? id {get;set;}
		[XmlAttribute("versionTimestamp")]
		public string? versionTimestamp {get;set;}
	}
}