using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "tCSPCondition")]
	public class TCSPCondition
	{
		[XmlAttribute("d_trackcond")]
		public uint d_trackcond {get;set;}
		[XmlAttribute("l_trackcond")]
		public uint l_trackcond {get;set;}
		[XmlAttribute("m_platform")]
		public ss026.PlatformType m_platform {get;set;}
		[XmlAttribute("q_platform")]
		public ss026.PlatformPosition q_platform {get;set;}
	}
}