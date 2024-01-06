using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "dLTrackCond")]
	public class DLTrackCond
	{
		[XmlAttribute("d_trackcond")]
		public uint d_trackcond {get;set;}
		[XmlAttribute("l_trackcond")]
		public uint l_trackcond {get;set;}
	}
}