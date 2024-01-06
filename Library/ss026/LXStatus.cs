using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "lXStatus")]
	public class LXStatus
	{
		[XmlAttribute("v_lx")]
		public uint v_lx {get;set;}
		[XmlAttribute("q_stoplx")]
		public bool q_stoplx {get;set;}
		[XmlAttribute("l_stoplx")]
		public uint l_stoplx {get;set;}
	}
}