using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "gradientChange")]
	public class GradientChange
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("gradient")]
		public int gradient {get;set;}
	}
}