using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadRestriction")]
	public class AxleLoadRestriction
	{
		[XmlAttribute("m_axleloadcat_n")]
		public ss026.AxleLoadCategory m_axleloadcat_n {get;set;}
		[XmlAttribute("v_axleload_n")]
		public uint v_axleload_n {get;set;}
	}
}