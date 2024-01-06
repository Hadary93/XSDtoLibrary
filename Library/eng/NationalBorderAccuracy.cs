using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "nationalBorderAccuracy")]
	public class NationalBorderAccuracy
	{
		[XmlAttribute("nationalBorderId")]
		public string? nationalBorderId {get;set;}
		[XmlAttribute("accuracy")]
		public uint accuracy {get;set;}
	}
}