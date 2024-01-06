using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "curveChange")]
	public class CurveChange
	{
		[XmlAttribute("pos")]
		public uint pos {get;set;}
		[XmlAttribute("curve")]
		public ato.CurveRadius curve {get;set;}
	}
}