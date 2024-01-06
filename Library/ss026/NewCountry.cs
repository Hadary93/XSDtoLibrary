using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "newCountry")]
	public class NewCountry
	{
		[XmlAttribute("nid_c")]
		public uint nid_c {get;set;}
	}
}