using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "countryBalise")]
	public class CountryBalise
	{
		[XmlAttribute("q_newcountry_k")]
		public bool q_newcountry_k {get;set;}
		[XmlAttribute("nid_c_k")]
		public uint nid_c_k {get;set;}
		[XmlAttribute("nid_bg_k")]
		public uint nid_bg_k {get;set;}
	}
}