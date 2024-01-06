using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_139")]
	public class ETCSPacket_139
	{
		[XmlAttribute("d_reverse")]
		public uint d_reverse {get;set;}
		[XmlAttribute("v_reverse")]
		public uint v_reverse {get;set;}
	}
}