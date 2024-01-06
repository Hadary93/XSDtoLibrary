using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "countryId")]
	public class CountryId
	{
		[XmlAttribute("nid_c")]
		public uint nid_c {get;set;}
	}
}