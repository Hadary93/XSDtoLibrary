using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "unprotectedLX")]
	public class UnprotectedLX
	{
		[XmlAttribute("pNominal")]
		public uint pNominal {get;set;}
		[XmlAttribute("pReverse")]
		public uint pReverse {get;set;}
	}
}