using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "permittedBrakingDist")]
	public class PermittedBrakingDist
	{
		[XmlAttribute("d_pbd")]
		public uint d_pbd {get;set;}
		[XmlAttribute("q_gdir")]
		public bool q_gdir {get;set;}
		[XmlAttribute("g_pbdsr")]
		public uint g_pbdsr {get;set;}
		[XmlAttribute("q_pbdsr")]
		public bool q_pbdsr {get;set;}
		[XmlAttribute("d_pbdsr")]
		public uint d_pbdsr {get;set;}
		[XmlAttribute("l_pbdsr")]
		public uint l_pbdsr {get;set;}
	}
}