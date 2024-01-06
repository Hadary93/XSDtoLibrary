using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "currentChange")]
	public class CurrentChange
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("current")]
		public uint current {get;set;}
	}
}