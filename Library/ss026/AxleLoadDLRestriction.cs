using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadDLRestriction")]
	public class AxleLoadDLRestriction
	{
		[XmlArray(Order=0)]
		[XmlArrayItem("restriction", Namespace = "https://erju.org/")]
		public List<ss026.AxleLoadRestriction>? restrictions;
		[XmlAttribute("d_axleload_k")]
		public uint d_axleload_k {get;set;}
		[XmlAttribute("l_axleload_k")]
		public uint l_axleload_k {get;set;}
		[XmlAttribute("q_front_k")]
		public bool q_front_k {get;set;}
	}
}