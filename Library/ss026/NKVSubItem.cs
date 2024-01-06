using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKVSubItem")]
	public class NKVSubItem
	{
		[XmlElement(Order=0)]		public ss026.NVP13? nvp13 {get;set;}
		[XmlArray(Order=1)]
		[XmlArrayItem("mvv", Namespace = "https://erju.org/")]
		public List<ss026.VMM>? mvvs;
	}
}