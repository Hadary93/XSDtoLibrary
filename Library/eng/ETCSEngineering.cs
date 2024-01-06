using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "eTCSEngineering")]
	public class ETCSEngineering
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("area", Namespace = "https://erju.org/")]
		public List<eng.EngArea>? areas;
		[XmlArray(Order=1)]
		[XmlArrayItem("mileageArea", Namespace = "https://erju.org/")]
		public List<eng.MileageArea>? mileageAreas;
		[XmlArray(Order=2)]
		[XmlArrayItem("locationAccuracyArea", Namespace = "https://erju.org/")]
		public List<eng.LocationAccuracyArea>? locationAccuracyAreas;
	}
}