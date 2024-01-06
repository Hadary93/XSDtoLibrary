using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "baliseAccuracy")]
	public class BaliseAccuracy
	{
		[XmlAttribute("baliseId")]
		public string baliseId {get;set;}
		[XmlAttribute("accuracy")]
		public uint accuracy {get;set;}
	}
}