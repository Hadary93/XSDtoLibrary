using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "locationAccuracyArea")]
	public class LocationAccuracyArea
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("balis", Namespace = "https://erju.org/")]
		public List<eng.BaliseAccuracy>? balises;
		[XmlArray(Order=1)]
		[XmlArrayItem("etcsMarker", Namespace = "https://erju.org/")]
		public List<eng.EtcsMarkerAccuracy>? etcsMarkers;
		[XmlArray(Order=2)]
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/")]
		public List<eng.StopLocationAccuracy>? stopLocations;
		[XmlArray(Order=3)]
		[XmlArrayItem("nationalBorder", Namespace = "https://erju.org/")]
		public List<eng.NationalBorderAccuracy>? nationalBorders;
		[XmlArray(Order=4)]
		[XmlArrayItem("bufferStop", Namespace = "https://erju.org/")]
		public List<eng.BufferStopAccuracy>? bufferStops;
		[XmlAttribute("id")]
		public string? id {get;set;}
	}
}