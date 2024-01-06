using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "balise")]
	public class Balise
	{
		[XmlAttribute("positionInGroup")]
		public uint positionInGroup {get;set;}
		[XmlAttribute("pos")]
		public uint pos {get;set;}
	}
}