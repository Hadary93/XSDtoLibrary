using System.Xml.Serialization;
namespace map
{
	[XmlRoot(Namespace = "https://erju.org/map", ElementName = "funcElementRef")]
	public class FuncElementRef
	{
		[XmlElement(Order=0)]
		public SimplePointRef? simplePoint {get;set;}
		[XmlElement(Order=1)]
		public EtcsMarkerRef? etcsMarker {get;set;}
		[XmlElement(Order=2)]
		public StopLocationRef? stopLocation {get;set;}
		[XmlElement(Order=3)]
		public TimingPointRef? timingPoint {get;set;}
		[XmlElement(Order=4)]
		public OperationalPointRef? operationalPoint {get;set;}
		[XmlElement(Order=5)]
		public BaliseRef? balise {get;set;}
	}
}