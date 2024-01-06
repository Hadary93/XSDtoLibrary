using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "dLMCondition")]
	public class DLMCondition
	{
		[XmlAttribute("d_trackcond")]
		public uint d_trackcond {get;set;}
		[XmlAttribute("l_trackcond")]
		public uint l_trackcond {get;set;}
		[XmlAttribute("m_trackcond")]
		public ss026.TrackCondType m_trackcond {get;set;}
	}
}