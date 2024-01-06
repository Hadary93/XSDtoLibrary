using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "modeProfileItem")]
	public class ModeProfileItem
	{
		[XmlAttribute("d_mamode")]
		public uint d_mamode {get;set;}
		[XmlAttribute("m_mamode")]
		public ss026.MAMode m_mamode {get;set;}
		[XmlAttribute("v_mamode")]
		public uint v_mamode {get;set;}
		[XmlAttribute("l_mamode")]
		public uint l_mamode {get;set;}
		[XmlAttribute("l_ackmamode")]
		public uint l_ackmamode {get;set;}
		[XmlAttribute("q_mamode")]
		public bool q_mamode {get;set;}
	}
}