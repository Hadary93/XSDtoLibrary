using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "linkItem")]
	public class LinkItem
	{
		[XmlElement(Order=0)]
		public ss026.CountryId? q_newcountry {get;set;}
		[XmlAttribute("d_link")]
		public uint d_link {get;set;}
		[XmlAttribute("nid_bg")]
		public uint nid_bg {get;set;}
		[XmlAttribute("q_linkorientation")]
		public bool q_linkorientation {get;set;}
		[XmlAttribute("q_linkreaction")]
		public ss026.LinkReaction q_linkreaction {get;set;}
		[XmlAttribute("q_locacc")]
		public uint q_locacc {get;set;}
	}
}