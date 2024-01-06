using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "allocationSection")]
	public class AllocationSection
	{
		[XmlElement(Order=0)]		public infra.LinkedPath? linearLocation {get;set;}
		[XmlArray(Order=1)]
		[XmlArrayItem("dependencie", Namespace = "https://erju.org/")]
		public List<DependencieRef?>? dependencies;
		[XmlAttribute("id")]
		public string id {get;set;}
		[XmlAttribute("name")]
		public string name {get;set;}
	}
}