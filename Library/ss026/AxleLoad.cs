using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoad")]
	public class AxleLoad
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("axleLoadDLRestriction", Namespace = "https://erju.org/")]
		public List<ss026.AxleLoadDLRestriction>? axleLoadDLRestrictions;
		[XmlAttribute("d_axleload")]
		public uint d_axleload {get;set;}
		[XmlAttribute("l_axleload")]
		public uint l_axleload {get;set;}
		[XmlAttribute("q_front")]
		public bool q_front {get;set;}
	}
}