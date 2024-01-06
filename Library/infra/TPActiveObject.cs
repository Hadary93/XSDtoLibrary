using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tPActiveObject")]
	public class TPActiveObject
	{
		[XmlElement(Order=0)]
		public EtcsMarkerRef? etcsMarker {get;set;}
		[XmlElement(Order=1)]
		public StopLocationRef? stopLocation {get;set;}
		[XmlElement(Order=2)]
		public TimeMeasurePointRef? timeMeasurePoint {get;set;}
	}
}