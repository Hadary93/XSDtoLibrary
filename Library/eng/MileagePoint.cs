using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileagePoint")]
	public class MileagePoint
	{
		[XmlAttribute("pos")]
		public double pos {get;set;}
		[XmlAttribute("mileage")]
		public double mileage {get;set;}
	}
}