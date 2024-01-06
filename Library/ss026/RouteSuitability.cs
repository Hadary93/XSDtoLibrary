using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "routeSuitability")]
	public class RouteSuitability
	{
		[XmlElement(Order=0)]
		public LoadingGaugeRef? loadingGauge {get;set;}
		[XmlElement(Order=1)]
		public MaxAxleLoadRef? maxAxleLoad {get;set;}
		[XmlElement(Order=2)]
		public ss026.TractionSystem? voltage {get;set;}
	}
}