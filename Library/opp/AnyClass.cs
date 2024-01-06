using System.Xml.Serialization;
namespace opp
{
	[XmlRoot(Namespace = "https://erju.org/opp", ElementName = "anyClass")]
	public class AnyClass
	{
		[XmlAttribute("className")]
		public string? className {get;set;}
		[XmlAttribute("content")]
		public string? content {get;set;}
	}
}