using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nVP13")]
	public class NVP13
	{
		[XmlAttribute("a_nvp12")]
		public uint a_nvp12 {get;set;}
		[XmlAttribute("a_nvp23")]
		public uint a_nvp23 {get;set;}
	}
}